using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW3
{
    public partial class AddCard : Form
    {
        public List<Transaction> _transaction = new List<Transaction>();
        public Transaction transaction = new Transaction();
        //public Transaction transaction = new Transaction();
        private const string ConnectionString = "Data source = C:/Users/rrcb2/source/repos/proiectPAWcatdecat/proiectPAW3/seconddatabase.db";//
        public Main parent;
        public AddCard()
        {

            InitializeComponent();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTransaction();
                DisplayTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Name = textBox1.Text;
            var CardNumber = textBox2.Text;
            var Digit = textBox4.Text;
            var Wallet = textBox3.Text;
            var transaction = new Transaction(Name, CardNumber, Digit, Wallet);

            try
            {
                addTransaction(transaction);
                DisplayTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayTransaction()
        {
            listView1.Items.Clear();

            foreach (Transaction transactions in _transaction)
            {
                var listViewItem = new ListViewItem(transactions.CardHolder);
                listViewItem.SubItems.Add(transactions.CardNumber);
                listViewItem.SubItems.Add(transactions.Card3Digit);
                listViewItem.SubItems.Add(transactions.Wallet);

                listView1.Items.Add(listViewItem);

                listViewItem.Tag = _transaction;



            }

        }

        private void addTransaction(Transaction transaction)
        {

           const string query = " INSERT INTO Transaction(CardHolder, CardNumber, Card3Digit, Wallet) VALUES (@cardHolder, @cardNumber, @card3Digit, @wallet); SELECT last_insert_rowid();";


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@cardHolder", transaction.CardHolder);
                command.Parameters.AddWithValue("@cardNumber", transaction.CardNumber);
                command.Parameters.AddWithValue("@card3Digit", transaction.Card3Digit);
                command.Parameters.AddWithValue("@wallet", transaction.Wallet);

                connection.Open();

                long id = (long)command.ExecuteScalar();
                transaction.id = id;



            }


            _transaction.Add(transaction);
        }

        private void LoadTransaction()
        {
            string query = "SELECT * FROM Transaction ";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        string CardHolder = (string)reader["CardHolder"];
                        string CardNumber = (string)reader["CardNumber"];
                        string Card3Digit = (string)reader["Card3Digit"];
                        string Wallet = (string)reader["Wallet"];

                        Transaction transaction = new Transaction(id, CardHolder,CardNumber, Card3Digit, Wallet);
                        _transaction.Add(transaction);



                    }
                }
            }
        }

       
       

        private void DeleteTransaction(Transaction transaction)
        {
            string query = "DELETE FROM Transaction WHERE id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", transaction.id);
                connection.Open();
                command.ExecuteNonQuery();
               
                _transaction.Remove(transaction);
            }
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an entry!");
                return;

            }

            ListViewItem item = listView1.SelectedItems[0];
            Transaction transaction = (Transaction)item.Tag;
            DeleteTransaction(transaction);
            DisplayTransaction();
        }
    }
}




