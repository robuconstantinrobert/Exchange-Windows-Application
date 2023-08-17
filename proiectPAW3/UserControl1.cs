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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public PhoneNumbers SelectedPhonenumber
        {
            get
            {
                return (PhoneNumbers)comboBox1.SelectedItem;

            }
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<PhoneNumbers> list = new List<PhoneNumbers>();
            list.Add(new PhoneNumbers() { ID = 1, number = "0773221453" });
            list.Add(new PhoneNumbers() { ID = 2, number = "0773235453" });
            list.Add(new PhoneNumbers() { ID = 3, number = "0773421853" });
            list.Add(new PhoneNumbers() { ID = 4, number = "0773221453" });
            list.Add(new PhoneNumbers() { ID = 5, number = "0773221273" });
            list.Add(new PhoneNumbers() { ID = 6, number = "0743221408" });
            list.Add(new PhoneNumbers() { ID = 7, number = "0273221459" });
            list.Add(new PhoneNumbers() { ID = 8, number = "0373521400" });
            list.Add(new PhoneNumbers() { ID = 9, number = "0723221453" });
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
