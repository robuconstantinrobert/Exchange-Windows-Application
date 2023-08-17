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
    public partial class Main : Form
    {
        public Login parent;
        public Main(Login form)
        {
            parent = form;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowCurrencies_Click(object sender, EventArgs e)
        {
            ShowCurrencies form = new ShowCurrencies(this);
            form.Show();
        }

        private void btnShowExchangeRates_Click(object sender, EventArgs e)
        {
            ShowExchangeRates form = new ShowExchangeRates();
            form.Show();
        }

        private void btnExchangeCurrency_Click(object sender, EventArgs e)
        {
            ExchangeCurrency form = new ExchangeCurrency(this);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCard form = new AddCard();
            form.Show();
        }

        
    }
}
