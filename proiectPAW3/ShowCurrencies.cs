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
    public partial class ShowCurrencies : Form
    {
        

        public ExchangeRate exchangeRate = new ExchangeRate();
        public Main parent;
        public ShowCurrencies(Main form)
        {
            parent = form;
            InitializeComponent();
        }

        private void ShowCurrencies_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            if (ValidateChildren())
            {

                string Name = textBoxName.Text;
                string TypeOfCurrency = textBoxType.Text;
                double ValueOfBanknote = double.Parse(textBoxAmount.Text);
                float Change = float.Parse(textBoxChange.Text);
                string Date = textBoxDate.Text;

                Currency currency = new Currency(Name, TypeOfCurrency, ValueOfBanknote, Change, Date);
                addCurrency(currency);

                //Close();
            }
        }

        private void DisplayCurrency() 
        {
            listView1.Items.Clear();

            foreach (Currency currency in exchangeRate.currencies) 
            {
                ListViewItem item = new ListViewItem(currency.Name);
                item.SubItems.Add(currency.TypeOfCurrency);
                item.SubItems.Add(currency.ValueOfBanknote.ToString());
                item.SubItems.Add(currency.Change.ToString());
                item.SubItems.Add(currency.Date);

                listView1.Items.Add(item);

                //listView1.Tag = currency;
            }
        
        }


        public void addCurrency(Currency currency)
        {
            exchangeRate.currencies.Add(currency);
            DisplayCurrency();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text.Length < 3) 
            {
                errorProviderShowCurrency.SetError((Control)sender, "The name should have more than 3 characters");
                e.Cancel = true;
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrency.SetError((Control)sender, string.Empty);
        }

        private void textBoxType_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxType.Text.Length < 2)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The type should have more than 1 character");
                e.Cancel = true;
            }
        }

        private void textBoxType_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrency.SetError((Control)sender, string.Empty);
        }

        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxAmount.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The amount should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The amount should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void textBoxAmount_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrency.SetError((Control)sender, string.Empty);
        }

        private void textBoxChange_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxChange.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The change should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The change should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void textBoxChange_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrency.SetError((Control)sender, string.Empty);
        }

        private void textBoxDate_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDate.Text.Length < 10)
            {
                errorProviderShowCurrency.SetError((Control)sender, "The date should have more than 9 characters");
                e.Cancel = true;
            }
        }

        private void textBoxDate_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrency.SetError((Control)sender, string.Empty);
        }


        public void editCurrencies(Currency currency, int index)
        {
            exchangeRate.currencies[index] = currency;
            listView1.Items[index].SubItems[0].Text = currency.Name;
            listView1.Items[index].SubItems[1].Text = currency.TypeOfCurrency;
            listView1.Items[index].SubItems[2].Text = currency.ValueOfBanknote.ToString();
            listView1.Items[index].SubItems[3].Text = currency.Change.ToString();
            listView1.Items[index].SubItems[4].Text = currency.Date;

            DisplayCurrency();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = listView1.SelectedIndices[0];
            //ShowCurrenciesEdit form = new ShowCurrenciesEdit(this, index, exchangeRate.currencies.ElementAt(index));
            //form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Do you want to delete the selected items?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem item = listView1.SelectedItems[i];
                        listView1.Items[item.Index].Remove();
                    }
                }
            }
            else
                MessageBox.Show("Nothing selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Do you want to modify the selected items?", "Modifying", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    int index = listView1.SelectedIndices[0];
                    ShowCurrenciesEdit form = new ShowCurrenciesEdit(this, index, exchangeRate.currencies.ElementAt(index));
                    form.Show();
                }
            }
            else
                MessageBox.Show("Nothing selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs n)
        {

        }



        
        private void ShowCurrencies_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxName.Focus();
        }

        private void typeOfCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxType.Focus();
        }

        private void amountOfOneBanknoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxAmount.Focus();
        }

        private void changeInTheValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxChange.Focus();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxDate.Focus();
        }

        private void serializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create("SerializedV2.bin"))
            {
                formatter.Serialize(fs, exchangeRate);
            }
        }

        private void deserializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("SerializedV2.bin"))
            {
                exchangeRate = (ExchangeRate)formatter.Deserialize(fs);
                DisplayCurrency();
            }
        }

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input atleast 3 characters";
        }

        private void textBoxName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxType_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input atleast 3 characters";
        }

        private void textBoxType_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxAmount_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input atleast 2 numbers";
        }

        private void textBoxAmount_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxChange_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input atleast 2 numbers";
        }

        private void textBoxChange_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxDate_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input atleast 10 numbers for the date";
        }

        private void textBoxDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Export";
            dialog.Filter = "Text File|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("SEP=,");
                    writer.WriteLine("Name,TypeOfCurrency,ValueOfBanknote,Change,Date");

                    foreach (Currency currency in exchangeRate.currencies)
                    {
                        writer.WriteLine(currency.Name + "," + currency.TypeOfCurrency + "," + currency.ValueOfBanknote + "," + currency.Change + ","+ currency.Date);
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        Bitmap bmp;
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }





        //private void addCurrency(Currency currency)
        //{
        //    string query = " INSERT INTO Currency(Name, Type, Amount, Change, Data) VALUES (@Name, @TypeOfCurrency, @ValueOfBanknote, @Change, @Data); SELECT last_insert_rowid();";


        //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        //    {
        //        SQLiteCommand command = new SQLiteCommand(query, connection);
        //        command.Parameters.AddWithValue("@Name", currency.Name);
        //        command.Parameters.AddWithValue("@TypeOfCurrency", currency.TypeOfCurrency);
        //        command.Parameters.AddWithValue("@ValueOfBanknote", currency.ValueOfBanknote);
        //        command.Parameters.AddWithValue("@Change", currency.Change);
        //        command.Parameters.AddWithValue("@Date", currency.Date);

        //        connection.Open();

        //        long id = (long)command.ExecuteScalar();
        //        currency.ID = id;



        //    }


        //    exchangeRate.currencies.Add(currency);



        //}

        //private void LoadCurrency()
        //{
        //    string query = "SELECT * FROM Currency ";
        //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        //    {
        //        SQLiteCommand command = new SQLiteCommand(query, connection);

        //        connection.Open();
        //        using (SQLiteDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                long id = (long)reader["ID"];
        //                string Name = (string)reader["Name"];
        //                string Type = (string)reader["Type"];
        //                double Amount = (double)reader["Amount"];
        //                float Change = (float)reader["Change"];
        //                string Date = (string)reader["Date"];

        //                Currency currency = new Currency(id, Name, Type, Amount, Change, Date);
        //                exchangeRate.currencies.Add(currency);



        //            }
        //        }
        //    }
        //}

        //private void DeleteCurrency(Currency currency)
        //{
        //    string query = "DELETE FROM Currency  WHERE ID = @id";

        //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        //    {
        //        SQLiteCommand command = new SQLiteCommand(query, connection);
        //        command.Parameters.AddWithValue("@id", currency.ID);
        //        connection.Open();
        //        command.ExecuteNonQuery();

        //        exchangeRate.currencies.Remove(currency);
        //    }
        //}



    }
}
