using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory2
{
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm(InPart part)
        {
            InitializeComponent();

            InHouseRadio.Checked = true;
            PartIDTextBox.Text = part.PartID.ToString();
            PartNameTextBox.Text = part.PartName.ToString();
            PartInStockTextBox.Text = part.PartInStock.ToString();
            PartPriceTextBox.Text = part.PartPrice.ToString();
            PartMaxTextBox.Text = part.PartMax.ToString();
            PartMinTextBox.Text = part.PartMin.ToString();
            PartMachineIDTextBox.Text = part.MachineID.ToString();
            PartOutTextBox.Enabled = false;
        }

        public ModifyPartForm(OutPart part)
        {
            InitializeComponent();
            OutsourceRadio.Checked = true;
            PartIDTextBox.Text = part.PartID.ToString();
            PartNameTextBox.Text = part.PartName.ToString();
            PartInStockTextBox.Text = part.PartInStock.ToString();
            PartPriceTextBox.Text = part.PartPrice.ToString();
            PartMaxTextBox.Text = part.PartMax.ToString();
            PartMinTextBox.Text = part.PartMin.ToString();
            PartOutTextBox.Text = part.CompanyName.ToString();
            PartMachineIDTextBox.Enabled = false;
        }

        private void SubmitPartUpdateBtn_Click(object sender, EventArgs e)
        {
            string a = PartNameTextBox.Text;
            string b = PartPriceTextBox.Text;
            string c = PartInStockTextBox.Text;
            string d = PartMinTextBox.Text;
            string f = PartMaxTextBox.Text;
            string g = PartMachineIDTextBox.Text;
            string h = PartOutTextBox.Text;
            int i = Int32.Parse(PartIDTextBox.Text);

            if (InHouseRadio.Checked)
            {
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
                    Inventory.UpdateInHousePart(a, b, c, d, f, g, i);
                }
            }

            else
            {
                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) ||
                    string.IsNullOrEmpty(d) || string.IsNullOrEmpty(f) || string.IsNullOrEmpty(h))
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
                else if (!b.Contains('.') || b.Contains('$'))
                {
                    MessageBox.Show("Please use a decimal in the price and do not use a dollar sign.");
                }
                else
                {
                    Inventory.UpdateOutHousePart(a, b, c, d, f, h, i);
                }
            }
            Close();
        }

        //
        //RADIO BUTTONS
        //

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadio.Checked)
            {
                OutsourceRadio.Checked = false;
                PartOutTextBox.Enabled = false;
                PartMachineIDTextBox.Enabled = true;
                PartOutTextBox.Text = string.Empty;
            }
            else if (OutsourceRadio.Checked)
            {
                InHouseRadio.Checked = false;
                PartMachineIDTextBox.Enabled = false;
                PartOutTextBox.Enabled = true;
                PartMachineIDTextBox.Text = string.Empty;
            }
        }

        private void CancelPartModBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
