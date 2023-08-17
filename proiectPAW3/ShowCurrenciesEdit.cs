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
    public partial class ShowCurrenciesEdit : Form
    {
        ShowCurrencies parent;
        int elementIndex;
        public ShowCurrenciesEdit(ShowCurrencies form, int index, Currency currency)
        {

            parent = form;
            elementIndex = index;
            InitializeComponent();

            textBoxEditName.Text = currency.Name;
            textBoxEditType.Text = currency.TypeOfCurrency;
            textBoxEditAmount.Text = currency.ValueOfBanknote.ToString();
            textBoxEditChange.Text = currency.Change.ToString();
            textBoxEditDate.Text = currency.Date;

        }



        private void ShowCurrenciesEdit_Load(object sender, EventArgs e)
        {

        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                string Name = textBoxEditName.Text;
                string Type = textBoxEditType.Text;
                double Amount = double.Parse(textBoxEditAmount.Text);
                float Change = float.Parse(textBoxEditChange.Text);
                string Date = textBoxEditDate.Text;

                Currency currency = new Currency(Name, Type, Amount, Change, Date);

                parent.editCurrencies(currency, elementIndex);
                Close();
            }
        }

        private void textBoxEditName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEditName.Text.Length < 3)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The name should have more than 3 characters");
                e.Cancel = true;
            }
        }

        private void textBoxEditName_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrenciesEdit.SetError((Control)sender, string.Empty);
        }

        private void textBoxEditType_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEditType.Text.Length < 2)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The type should have more than 1 character");
                e.Cancel = true;
            }
        }

        private void textBoxEditType_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrenciesEdit.SetError((Control)sender, string.Empty);
        }

        private void textBoxEditAmount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxEditAmount.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The amount should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The amount should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void textBoxEditAmount_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrenciesEdit.SetError((Control)sender, string.Empty);
        }

        private void textBoxEditChange_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxEditChange.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The change should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The change should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void textBoxEditChange_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrenciesEdit.SetError((Control)sender, string.Empty);
        }

        private void textBoxEditDate_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEditDate.Text.Length < 10)
            {
                errorProviderShowCurrenciesEdit.SetError((Control)sender, "The date should have more than 9 characters");
                e.Cancel = true;
            }
        }

        private void textBoxEditDate_Validated(object sender, EventArgs e)
        {
            errorProviderShowCurrenciesEdit.SetError((Control)sender, string.Empty);
        }
    }
}
