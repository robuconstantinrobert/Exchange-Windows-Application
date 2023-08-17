
namespace proiectPAW3
{
    partial class ExchangeCurrency
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
            this.btnExchange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFirstCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExchange.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.Location = new System.Drawing.Point(478, 98);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(111, 62);
            this.btnExchange.TabIndex = 0;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick a currency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick a second currency:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 121);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxFirstCurrency
            // 
            this.comboBoxFirstCurrency.FormattingEnabled = true;
            this.comboBoxFirstCurrency.Items.AddRange(new object[] {
            "AFN",
            "ALL",
            "AED",
            "DZD",
            "AOA",
            "ARS",
            "AMD",
            "AUD",
            "AZN",
            "BHD",
            "BDT",
            "BBD",
            "BYN",
            "BZD",
            "BOB",
            "BAM",
            "BWP",
            "BRL",
            "BND",
            "BGN",
            "CAD",
            "XAF",
            "CLP",
            "CHF",
            "CNY",
            "COP",
            "CDF",
            "CRC",
            "CZK",
            "DKK",
            "DJF",
            "DOP",
            "EUR",
            "EGP",
            "FJD",
            "GHS",
            "GBP",
            "HKD",
            "HTG",
            "HNL",
            "GYD",
            "GNF",
            "HUF",
            "ISK",
            "INR",
            "IDR",
            "IRR",
            "IQD",
            "ILS",
            "JMD",
            "JPY",
            "KZT",
            "KES",
            "JOD",
            "KID",
            "KPW",
            "KRW",
            "KWD",
            "KGS",
            "LAK",
            "LBP",
            "LRD",
            "MGA",
            "MYR",
            "MVR",
            "MRU",
            "MXN",
            "MDL",
            "MNT",
            "MAD",
            "MZN",
            "MMK",
            "NAD",
            "NPR",
            "NZD",
            "NIO",
            "NGN",
            "MKD",
            "NOK",
            "OMR",
            "PKR",
            "PGK",
            "PYG",
            "PEN",
            "PHP",
            "PLN",
            "QAR",
            "RON",
            "RUB",
            "RWF",
            "SAR",
            "RSD",
            "SSP",
            "LKR",
            "SDG",
            "SEK",
            "SYP",
            "TWD",
            "TJS",
            "THB",
            "TND",
            "TRY",
            "UAH",
            "USD",
            "UYU",
            "UZS",
            "VES",
            "YER",
            "ZWB",
            "",
            ""});
            this.comboBoxFirstCurrency.Location = new System.Drawing.Point(219, 57);
            this.comboBoxFirstCurrency.Name = "comboBoxFirstCurrency";
            this.comboBoxFirstCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirstCurrency.TabIndex = 6;
            this.comboBoxFirstCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirstCurrency_SelectedIndexChanged);
            // 
            // comboBoxSecondCurrency
            // 
            this.comboBoxSecondCurrency.FormattingEnabled = true;
            this.comboBoxSecondCurrency.Items.AddRange(new object[] {
            "AFN",
            "ALL",
            "AED",
            "DZD",
            "AOA",
            "ARS",
            "AMD",
            "AUD",
            "AZN",
            "BHD",
            "BDT",
            "BBD",
            "BYN",
            "BZD",
            "BOB",
            "BAM",
            "BWP",
            "BRL",
            "BND",
            "BGN",
            "CAD",
            "XAF",
            "CLP",
            "CHF",
            "CNY",
            "COP",
            "CDF",
            "CRC",
            "CZK",
            "DKK",
            "DJF",
            "DOP",
            "EUR",
            "EGP",
            "FJD",
            "GHS",
            "GBP",
            "HKD",
            "HTG",
            "HNL",
            "GYD",
            "GNF",
            "HUF",
            "ISK",
            "INR",
            "IDR",
            "IRR",
            "IQD",
            "ILS",
            "JMD",
            "JPY",
            "KZT",
            "KES",
            "JOD",
            "KID",
            "KPW",
            "KRW",
            "KWD",
            "KGS",
            "LAK",
            "LBP",
            "LRD",
            "MGA",
            "MYR",
            "MVR",
            "MRU",
            "MXN",
            "MDL",
            "MNT",
            "MAD",
            "MZN",
            "MMK",
            "NAD",
            "NPR",
            "NZD",
            "NIO",
            "NGN",
            "MKD",
            "NOK",
            "OMR",
            "PKR",
            "PGK",
            "PYG",
            "PEN",
            "PHP",
            "PLN",
            "QAR",
            "RON",
            "RUB",
            "RWF",
            "SAR",
            "RSD",
            "SSP",
            "LKR",
            "SDG",
            "SEK",
            "SYP",
            "TWD",
            "TJS",
            "THB",
            "TND",
            "TRY",
            "UAH",
            "USD",
            "UYU",
            "UZS",
            "VES",
            "YER",
            "ZWB",
            ""});
            this.comboBoxSecondCurrency.Location = new System.Drawing.Point(604, 57);
            this.comboBoxSecondCurrency.Name = "comboBoxSecondCurrency";
            this.comboBoxSecondCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondCurrency.TabIndex = 7;
            this.comboBoxSecondCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondCurrency_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pick the amount:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultLabel.Location = new System.Drawing.Point(49, 204);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(51, 22);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "label\r\n";
            // 
            // ExchangeCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(761, 290);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSecondCurrency);
            this.Controls.Add(this.comboBoxFirstCurrency);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExchange);
            this.Name = "ExchangeCurrency";
            this.Text = "ExchangeCurrency";
            this.Load += new System.EventHandler(this.ExchangeCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxFirstCurrency;
        private System.Windows.Forms.ComboBox comboBoxSecondCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}