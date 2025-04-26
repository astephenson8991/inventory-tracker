using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();

            AddPartIDTextBox.Text = (Inventory.Parts.Count + 1).ToString();
        }
        //
        //ADD PART
        //
        private void SubmitPartAddBtn_Click(object sender, EventArgs e)
        {
            if (AddPartInRadioBtn.Checked == true)
            {
                string a = AddPartNameTextBox.Text;
                string b = AddPartPriceTextBox.Text;
                string c = AddPartInStockTextBox.Text;
                string d = AddPartMinTextBox.Text;
                string f = AddPartMaxTextBox.Text;
                string g = AddPartMachineIDTextBox.Text;

                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) ||
                    string.IsNullOrEmpty(d) || string.IsNullOrEmpty(f) || string.IsNullOrEmpty(g))
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
                else if (!b.Contains('.') || b.Contains('$'))
                {
                    MessageBox.Show("Please use a decimal in the price and do not use a dollar sign.");
                }
                else
                {
                    Inventory.AddInHousePart(a, b, c, d, f, g);
                }
                Close();
            }

            else
            {
                string a = AddPartNameTextBox.Text;
                string b = AddPartPriceTextBox.Text;
                string c = AddPartInStockTextBox.Text;
                string d = AddPartMinTextBox.Text;
                string f = AddPartMaxTextBox.Text;
                string g = AddPartOutTextBox.Text;

                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) ||
                    string.IsNullOrEmpty(d) || string.IsNullOrEmpty(f) || string.IsNullOrEmpty(g))
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
                else if (!b.Contains('.') || b.Contains('$'))
                {
                    MessageBox.Show("Please use a decimal in the price and do not use a dollar sign.");
                }
                else
                {
                    Inventory.AddOutHousePart(a, b, c, d, f, g);
                }
            }
        }
        //
        //CLOSE WINDOW
        //
        private void CancelPartAddBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
        //IN OR OUT OF HOUSE PART?
        //
        private void AddPartInRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPartInRadioBtn.Checked)
            {
                AddPartOutRadioBtn.Checked = false;
                AddPartOutTextBox.Enabled = false;
                AddPartMachineIDTextBox.Enabled = true;
                AddPartOutTextBox.Text = string.Empty;
            }
            else if (AddPartOutRadioBtn.Checked)
            {
                AddPartInRadioBtn.Checked = false;
                AddPartMachineIDTextBox.Enabled = false;
                AddPartOutTextBox.Enabled = true;
                AddPartMachineIDTextBox.Text = string.Empty;
            }
        }
        //
        //CLEAR FORM CONTENTS
        //
        private void ClearPartAddBtn_Click(object sender, EventArgs e)
        {
            AddPartNameTextBox.Text = string.Empty;
            AddPartPriceTextBox.Text = string.Empty;
            AddPartInStockTextBox.Text = string.Empty;
            AddPartMinTextBox.Text = string.Empty;
            AddPartMaxTextBox.Text = string.Empty;
            AddPartMachineIDTextBox.Text = string.Empty;
            AddPartOutTextBox.Text= string.Empty;
        }
    }
}