namespace Universal_API
{
    partial class Currency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_CurrencyPlaceholder = new System.Windows.Forms.Label();
            this.lbl_Currency_1H = new System.Windows.Forms.Label();
            this.lbl_Currency_7D = new System.Windows.Forms.Label();
            this.lbl_Currency_24H = new System.Windows.Forms.Label();
            this.lbl_Currency_CurrentPrice = new System.Windows.Forms.Label();
            this.tmr_UpdateValues = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_CurrencyPlaceholder
            // 
            this.lbl_CurrencyPlaceholder.AutoSize = true;
            this.lbl_CurrencyPlaceholder.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrencyPlaceholder.Location = new System.Drawing.Point(100, 10);
            this.lbl_CurrencyPlaceholder.Name = "lbl_CurrencyPlaceholder";
            this.lbl_CurrencyPlaceholder.Size = new System.Drawing.Size(349, 34);
            this.lbl_CurrencyPlaceholder.TabIndex = 0;
            this.lbl_CurrencyPlaceholder.Text = "CURRENCY_PLACEHOLDER";
            // 
            // lbl_Currency_1H
            // 
            this.lbl_Currency_1H.AutoSize = true;
            this.lbl_Currency_1H.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency_1H.Location = new System.Drawing.Point(90, 115);
            this.lbl_Currency_1H.Name = "lbl_Currency_1H";
            this.lbl_Currency_1H.Size = new System.Drawing.Size(399, 34);
            this.lbl_Currency_1H.TabIndex = 1;
            this.lbl_Currency_1H.Text = "CURRENCY_1H_PLACEHOLDER";
            // 
            // lbl_Currency_7D
            // 
            this.lbl_Currency_7D.AutoSize = true;
            this.lbl_Currency_7D.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency_7D.Location = new System.Drawing.Point(89, 183);
            this.lbl_Currency_7D.Name = "lbl_Currency_7D";
            this.lbl_Currency_7D.Size = new System.Drawing.Size(400, 34);
            this.lbl_Currency_7D.TabIndex = 2;
            this.lbl_Currency_7D.Text = "CURRENCY_7D_PLACEHOLDER";
            // 
            // lbl_Currency_24H
            // 
            this.lbl_Currency_24H.AutoSize = true;
            this.lbl_Currency_24H.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency_24H.Location = new System.Drawing.Point(89, 149);
            this.lbl_Currency_24H.Name = "lbl_Currency_24H";
            this.lbl_Currency_24H.Size = new System.Drawing.Size(416, 34);
            this.lbl_Currency_24H.TabIndex = 3;
            this.lbl_Currency_24H.Text = "CURRENCY_24H_PLACEHOLDER";
            // 
            // lbl_Currency_CurrentPrice
            // 
            this.lbl_Currency_CurrentPrice.AutoSize = true;
            this.lbl_Currency_CurrentPrice.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency_CurrentPrice.Location = new System.Drawing.Point(34, 62);
            this.lbl_Currency_CurrentPrice.Name = "lbl_Currency_CurrentPrice";
            this.lbl_Currency_CurrentPrice.Size = new System.Drawing.Size(557, 34);
            this.lbl_Currency_CurrentPrice.TabIndex = 4;
            this.lbl_Currency_CurrentPrice.Text = "CURRENCY_CURRENTPRICE_PLACEHOLDER";
            // 
            // tmr_UpdateValues
            // 
            this.tmr_UpdateValues.Enabled = true;
            this.tmr_UpdateValues.Interval = 5000;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 241);
            this.Controls.Add(this.lbl_Currency_CurrentPrice);
            this.Controls.Add(this.lbl_Currency_24H);
            this.Controls.Add(this.lbl_Currency_7D);
            this.Controls.Add(this.lbl_Currency_1H);
            this.Controls.Add(this.lbl_CurrencyPlaceholder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Currency";
            this.ShowIcon = false;
            this.Text = "Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CurrencyPlaceholder;
        private System.Windows.Forms.Label lbl_Currency_1H;
        private System.Windows.Forms.Label lbl_Currency_7D;
        private System.Windows.Forms.Label lbl_Currency_24H;
        private System.Windows.Forms.Label lbl_Currency_CurrentPrice;
        private System.Windows.Forms.Timer tmr_UpdateValues;
    }
}