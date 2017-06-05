using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Universal_API
{
    public partial class Selection : Form
    {
        private const string BASE_URL = "https://api.coinmarketcap.com/v1/ticker/";
        public Selection()
        {
            InitializeComponent();

            //Center controls for better UI look.
            CenterControl(pnl_Currencies);
            CenterControl(btn_Submit);
            CenterControl(txt_Enter);

            foreach (Label l in Controls.OfType<Label>())
            {
                CenterControl(l);
            }

            pb_bitcoin.Click += Pb_Click;
            pb_ethereum.Click += Pb_Click;
            pb_ripple.Click += Pb_Click;
            pb_nem.Click += Pb_Click;
            pb_ethereum_classic.Click += Pb_Click;
            pb_dogecoin.Click += Pb_Click;

            AcceptButton = btn_Submit;
            Shown += Form1_Shown;

            btn_Submit.Click += Btn_Submit_Click;

            txt_Enter.AcceptsReturn = true;
            txt_Enter.GotFocus += Txt_Enter_GotFocus;
            txt_Enter.LostFocus += Txt_Enter_LostFocus;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            pnl_Currencies.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string formattedString = "";
            foreach (char c in txt_Enter.Text)
            {
                if (c == ' ')
                {
                    formattedString += "-";
                }
                else
                {
                    formattedString += c.ToString().ToLower();
                }
            }
            HandleAPIRequest(formattedString, true);
        }

        private void Txt_Enter_GotFocus(object sender, EventArgs e)
        {
            if (txt_Enter.Text == "Enter the name of a cryptocurrency here.")
            {
                txt_Enter.Clear();
            }
        }

        private void Txt_Enter_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Enter.Text))
            {
                txt_Enter.Text = "Enter the name of a cryptocurrency here.";
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            string currencyNameFormatted = String.Empty;
            int underscoreCount = 0;
            PictureBox currentPB = (PictureBox)sender;
            foreach (char c in currentPB.Name)
            {
                if (c == '_') underscoreCount++;
            }
            if (underscoreCount == 0) return;
            if (underscoreCount == 1)
            {
                string[] splitter = currentPB.Name.Split('_');
                currencyNameFormatted = splitter[1];
            }
            else if (underscoreCount > 1)
            {
                string name = currentPB.Name;
                string nameNoPrefix = name.Remove(0, 3);
                string newString = nameNoPrefix.Replace('_', '-'); //In CoinMarketCap's API, spaces in names are represented as dashes.
                currencyNameFormatted = newString;
            }
            HandleAPIRequest(currencyNameFormatted, true);
        }

        private void CenterControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
        }

        public static List<String> HandleAPIRequest(string currency, bool createForm = false)
        {
            string apiURL = BASE_URL + currency + "/";
            WebRequest wr = WebRequest.Create(apiURL);
            WebResponse response = null;
            try { response = wr.GetResponse(); } catch (WebException) { MessageBox.Show("The cryptocurrency name you entered is either not in CoinMarketCap's database, doesn't exist or you do not have an active Internet connection. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            System.IO.Stream stream = response.GetResponseStream();
            System.IO.StreamReader dataReader = new System.IO.StreamReader(stream);
            string allData = dataReader.ReadToEnd();

            //If the user manually defines a cryptocurrency, check to make sure it's actually valid.


            //This line gets rid of the brackets at the top and bottom of the page to make it proper JSON.
            allData = allData.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });

            dynamic jsonData = JObject.Parse(allData);
            string properName = jsonData.name;
            string symbol = jsonData.symbol;
            string currentPriceUSD = jsonData.price_usd;
            string change1h = jsonData.percent_change_1h;
            string change24h = jsonData.percent_change_24h;
            string change7d = jsonData.percent_change_7d;

            List<String> data = new List<String>();
            data.Add(properName);
            data.Add(symbol);
            data.Add(currentPriceUSD);
            data.Add(change1h);
            data.Add(change24h);
            data.Add(change7d);

            if (createForm)
            {
                Currency c = new Currency(currency);
                c.Show();
            }

            return data;
        }
    }
}
