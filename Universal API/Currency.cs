using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_API
{
    public partial class Currency : Form
    {
        private string currency;
        private string currencyProperName;
        private string currencySymbol;
        private string currencyOriginalPrice;
        private string currencyCurrentPrice;
        private string currencyChange1h;
        private string currencyChange24h;
        private string currencyChange7d;
        private List<String> dynamicData;

        public Currency(string currency)
        {
            InitializeComponent();

            this.currency = currency;

            tmr_UpdateValues.Tick += Tmr_UpdateValues_Tick;

            UpdateValues(true);
        }

        private void UpdateValues(bool firstUpdate = false)
        {
            dynamicData = Selection.HandleAPIRequest(currency);

            currencyProperName = dynamicData[0];
            if (firstUpdate) Text = currencyProperName;
            currencySymbol = dynamicData[1];
            if (firstUpdate) currencyOriginalPrice = dynamicData[2];
            currencyCurrentPrice = dynamicData[2];
            currencyChange1h = dynamicData[3];
            currencyChange24h = dynamicData[4];
            currencyChange7d = dynamicData[5];

            SetLabels();
        }

        private void SetLabels()
        {
            lbl_CurrencyPlaceholder.Text = currencyProperName;
            lbl_Currency_CurrentPrice.Text = "Current Price (USD): " + currencyCurrentPrice;
            lbl_Currency_1H.Text = "Change past hour: " + currencyChange1h + "%";
            lbl_Currency_24H.Text = "Change past 24 hours: " + currencyChange24h + "%";
            lbl_Currency_7D.Text = "Change past week: " + currencyChange7d + "%";

            foreach (Label l in Controls.OfType<Label>())
            {
                CenterControl(l);
            }

            DetermineLabelColors(lbl_Currency_CurrentPrice, Convert.ToDouble(currencyCurrentPrice), Convert.ToDouble(currencyOriginalPrice));
            DetermineLabelColors(lbl_Currency_1H, Convert.ToDouble(currencyChange1h));
            DetermineLabelColors(lbl_Currency_24H, Convert.ToDouble(currencyChange24h));
            DetermineLabelColors(lbl_Currency_7D, Convert.ToDouble(currencyChange7d));
        }

        private void CenterControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
        }

        private void DetermineLabelColors(Label label, double amount, double comparisonAmount = 0)
        {
            if (amount < comparisonAmount) label.ForeColor = Color.Red;
            if (amount == comparisonAmount) label.ForeColor = Color.Black;
            else if (amount > comparisonAmount) label.ForeColor = Color.Green;
        }

        private void Tmr_UpdateValues_Tick(object sender, EventArgs e)
        {
            UpdateValues();
        }
    }
}
