using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW3
{
    public partial class ShowExchangeRates : Form
    {
        public List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
        public Currency currency = new Currency();
        private const string ConnectionString = "Data source = C:/Users/rrcb2/source/repos/proiectPAWcatdecat/proiectPAW3/seconddatabase.db";//
        public Main parent;
        public ShowExchangeRates()
        {
            InitializeComponent();
        }

        private void ShowExchangeRates_Load(object sender, EventArgs e)
        {
            try
            {
                LoadExchangeRate();
                DisplayExchangeRate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var CurrencyCode = txtBoxCurrencyCode.Text;
            var ApplicableTax =txtBoxApplicable.Text;
            var Change24 = txtBoxChange24.Text;

            var exchangeRate = new ExchangeRate(CurrencyCode, ApplicableTax, Change24);

            try
            {
                addExchangeRate(exchangeRate);
                DisplayExchangeRate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void DisplayCurrency()
        //{
        //    listView1.Items.Clear();

        //    foreach (Currency currency in exchangeRate.currencies)
        //    {
        //        ListViewItem item = new ListViewItem(currency.Name);
        //        item.SubItems.Add(currency.TypeOfCurrency);
        //        item.SubItems.Add(currency.ValueOfBanknote.ToString());
        //        item.SubItems.Add(currency.Change.ToString());
        //        item.SubItems.Add(currency.Date);

        //        listView1.Items.Add(item);
        //    }

        //}

        private void DisplayExchangeRate()
        {
            listView1.Items.Clear();

            foreach (ExchangeRate exchangeRate in _exchangeRate)
            {
                var listViewItem = new ListViewItem(exchangeRate.CurrencyCode);
               listViewItem.SubItems.Add(exchangeRate.ApplicableTax);
               listViewItem.SubItems.Add(exchangeRate.Change24);
               
                listView1.Items.Add(listViewItem);

                listViewItem.Tag = exchangeRate;

              
            }

        }

        private void addExchangeRate(ExchangeRate exchangeRate)
        {
          const  string query = " INSERT INTO ExchangeRate(CurrencyCode, ApplicableTax, Change24) VALUES (@CurrencyCode, @ApplicableTax, @Change24); SELECT last_insert_rowid();";


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@CurrencyCode", exchangeRate.CurrencyCode);
                command.Parameters.AddWithValue("@ApplicableTax", exchangeRate.ApplicableTax);
                command.Parameters.AddWithValue("@Change24", exchangeRate.Change24);
             

                connection.Open();

                long id = (long)command.ExecuteScalar();
                exchangeRate.id = id;



            }


            _exchangeRate.Add(exchangeRate);



        }

        private void LoadExchangeRate()
        {
            string query = "SELECT * FROM ExchangeRate"; 
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        string CurrencyCode = (string)reader["CurrencyCode"];
                        string ApplicableTax = (string)reader["ApplicableTax"];
                        string Change24 = (string)reader["Change24"];
                        

                        ExchangeRate exchangeRate = new ExchangeRate(id, CurrencyCode, ApplicableTax, Change24);
                        _exchangeRate.Add(exchangeRate);



                    }
                }
            }
        }


        private void DeleteExchangeRate(ExchangeRate exchangeRate)
        {
            string query = "DELETE FROM ExchangeRate  WHERE id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", exchangeRate.id);
                connection.Open();
                command.ExecuteNonQuery();

                _exchangeRate.Remove(exchangeRate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an entry!");
                return;

            }

            ListViewItem item = listView1.SelectedItems[0];
            ExchangeRate exchangeRate = (ExchangeRate)item.Tag;
            DeleteExchangeRate(exchangeRate);
            DisplayExchangeRate();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create("Serialized.bin")) 
            {
                formatter.Serialize(fs, _exchangeRate);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("Serialized.bin")) 
            {
                _exchangeRate = (List<ExchangeRate>)formatter.Deserialize(fs);
                DisplayExchangeRate();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
