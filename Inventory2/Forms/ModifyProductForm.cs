using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory2.Forms
{
    public partial class ModifyProductForm : Form
    {
        public static BindingList<Part> AddedParts = new BindingList<Part>();
        public ModifyProductForm(Product prod)
        {
            InitializeComponent();

            foreach (Part p in prod.AssociatedParts)
            {
                AddedParts.Add(p);
            }
            ProdPartsView.DataSource = Inventory.Parts;
            ProdAssocPartsView.DataSource = AddedParts;

            ModProdIDTextBox.Text = prod.ProductID.ToString();
            ModProdNameTextBox.Text = prod.ProductName.ToString();
            ModProdInStockTextBox.Text = prod.ProductInStock.ToString();
            ModProdPriceTextBox.Text = prod.ProductPrice.ToString();
            ModProdMinTextBox.Text = prod.ProductMin.ToString();
            ModProdMaxTextBox.Text = prod.ProductMax.ToString();
            
        }

        private void AddProdPartBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.Parts.Count <= 0)
            {
                MessageBox.Show("There are no parts to add!");
            }
            else if (ProdPartsView.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("You must select a part to modify.");
            }
            else
            {
                Part SelectedPart = ProdPartsView.CurrentRow.DataBoundItem as Part;
                AddedParts.Add(SelectedPart);
            }
        }

        private void RemoveProdPartBtn_Click(object sender, EventArgs e)
        {
            if (AddedParts.Count <= 0)
            {
                MessageBox.Show("There are no parts to remove!");
            }

            else if (ProdAssocPartsView.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("You must select a part to modify.");
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Part SelectedPart = ProdAssocPartsView.CurrentRow.DataBoundItem as Part;
                    AddedParts.Remove(SelectedPart);
                }
                else
                {
                    MessageBox.Show("Item was not deleted!");
                }

            }
        }

        private void CancelModProdBtn_Click(object sender, EventArgs e)
        {
            AddedParts.Clear();
            Close();
        }

        private void SubmitModProdBtn_Click(object sender, EventArgs e)
        {
            string a = ModProdNameTextBox.Text;
            string b = ModProdPriceTextBox.Text;
            string c = ModProdInStockTextBox.Text;
            string d = ModProdMinTextBox.Text;
            string f = ModProdMaxTextBox.Text;
            int g = Int32.Parse(ModProdIDTextBox.Text);

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) ||
                string.IsNullOrEmpty(d) || string.IsNullOrEmpty(f))
            {
                MessageBox.Show("Please fill out all required fields.");
            }
            else if (!b.Contains('.') || b.Contains('$'))
            {
                MessageBox.Show("Please use a decimal in the price and do not use a dollar sign.");
            }
            else
            {

                Inventory.UpdateProduct(a, b, c, d, f, g);
            }
            AddedParts.Clear();
            Close();
        }

        private void ProdPartsSearchBox_TextChanged(object sender, EventArgs e)
        {
            string Text = ProdPartsSearchBox.Text;
            ProdResetPartSearch.Visible = true;
            CurrencyManager cMan = (CurrencyManager)BindingContext[ProdPartsView.DataSource];
            cMan.SuspendBinding();
            int VisibleCount = 0;

            try
            {
                foreach (DataGridViewRow row in ProdPartsView.Rows)
                {
                    if (row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ProdPartsView.Rows[row.Index].Selected = true;
                        VisibleCount++;
                    }
                    else if (!row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ProdPartsView.Rows[row.Index].Visible = false;
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (VisibleCount == 0)
            {
                MessageBox.Show("No results found.");
                ProdResetPartSearch_Click(sender, e);
            }
        }

        private void ProdResetPartSearch_Click(object sender, EventArgs e)
        {
            ProdPartsSearchBox.Text = string.Empty;

            foreach (DataGridViewRow row in ProdPartsView.Rows)
            {
                if (ProdPartsView.Rows[row.Index].Visible == false)
                {
                    ProdPartsView.Rows[row.Index].Visible = true;
                }
            }
            ProdResetPartSearch.Visible = false;

            CurrencyManager cMan = (CurrencyManager)BindingContext[ProdPartsView.DataSource];
            cMan.ResumeBinding();
        }
    }
}
