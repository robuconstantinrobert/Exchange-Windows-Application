
namespace proiectPAW3
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnShowCurrencies = new System.Windows.Forms.Button();
            this.btnShowExchangeRates = new System.Windows.Forms.Button();
            this.btnExchangeCurrency = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowCurrencies
            // 
            this.btnShowCurrencies.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowCurrencies.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCurrencies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowCurrencies.Location = new System.Drawing.Point(12, 127);
            this.btnShowCurrencies.Name = "btnShowCurrencies";
            this.btnShowCurrencies.Size = new System.Drawing.Size(144, 76);
            this.btnShowCurrencies.TabIndex = 0;
            this.btnShowCurrencies.Text = "Show available currencies";
            this.btnShowCurrencies.UseVisualStyleBackColor = false;
            this.btnShowCurrencies.Click += new System.EventHandler(this.btnShowCurrencies_Click);
            // 
            // btnShowExchangeRates
            // 
            this.btnShowExchangeRates.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowExchangeRates.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowExchangeRates.Location = new System.Drawing.Point(12, 209);
            this.btnShowExchangeRates.Name = "btnShowExchangeRates";
            this.btnShowExchangeRates.Size = new System.Drawing.Size(144, 69);
            this.btnShowExchangeRates.TabIndex = 1;
            this.btnShowExchangeRates.Text = "Show the exchange rates";
            this.btnShowExchangeRates.UseVisualStyleBackColor = false;
            this.btnShowExchangeRates.Click += new System.EventHandler(this.btnShowExchangeRates_Click);
            // 
            // btnExchangeCurrency
            // 
            this.btnExchangeCurrency.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExchangeCurrency.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchangeCurrency.Location = new System.Drawing.Point(12, 284);
            this.btnExchangeCurrency.Name = "btnExchangeCurrency";
            this.btnExchangeCurrency.Size = new System.Drawing.Size(144, 68);
            this.btnExchangeCurrency.TabIndex = 2;
            this.btnExchangeCurrency.Text = "Exchange currency";
            this.btnExchangeCurrency.UseVisualStyleBackColor = false;
            this.btnExchangeCurrency.Click += new System.EventHandler(this.btnExchangeCurrency_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddCard.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCard.Location = new System.Drawing.Point(12, 358);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(144, 69);
            this.btnAddCard.TabIndex = 3;
            this.btnAddCard.Text = "Add card credentials";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DodgerBlue;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(182, 89);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "EUR";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "USD";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "GBP";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "YEN";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(511, 338);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title3.Name = "Value of currencies";
            this.chart1.Titles.Add(title3);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(709, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnExchangeCurrency);
            this.Controls.Add(this.btnShowExchangeRates);
            this.Controls.Add(this.btnShowCurrencies);
            this.Name = "Main";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCurrencies;
        private System.Windows.Forms.Button btnShowExchangeRates;
        private System.Windows.Forms.Button btnExchangeCurrency;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}