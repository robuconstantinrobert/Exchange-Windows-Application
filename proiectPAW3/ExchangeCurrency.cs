using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW3
{
    public partial class ExchangeCurrency : Form
    {
        public Main parent;
       
        public ExchangeCurrency(Main form)
        {
            parent = form;
            InitializeComponent();
        }

        private void ExchangeCurrency_Load(object sender, EventArgs e)
        {
            this.comboBoxFirstCurrency.SelectedItem = "EUR";
            this.comboBoxFirstCurrency.SelectedItem = "USD";



            this.comboBoxFirstCurrency.SelectedItem = "EUR";
            this.comboBoxSecondCurrency.SelectedItem = "USD";
        
        }

      


        public void ConvertCurrency()
        {
            
            decimal number = this.numericUpDown1.Value;
            string currencyFirst = this.comboBoxFirstCurrency.SelectedItem.ToString();
            string currencySecond = this.comboBoxSecondCurrency.SelectedItem.ToString();

            decimal convertedAmount = number;
            if (currencyFirst == "EUR" && currencySecond == "USD") 
            {
                convertedAmount = number / 0.950100m;
            }


            this.resultLabel.Text = number + " " + currencyFirst + "\n" + convertedAmount + " " + currencySecond;

        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBoxFirstCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ConvertCurrency();
        }

        private void comboBoxSecondCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //ConvertCurrency();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
