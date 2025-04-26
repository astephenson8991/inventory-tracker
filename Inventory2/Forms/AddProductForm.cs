using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    public partial class AddProductForm : Form
    {
        public static BindingList<Part> AddedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();

            ProdPartsView.DataSource = Inventory.Parts;

            ProdAssocPartsView.DataSource = AddedParts;

            AddProdIDTextBox.Text = (Inventory.Products.Count + 1).ToString();

        }

        //
        //ADD ASSOCIATED PRODUCT PARTS
        //

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

        //
        //REMOVE ASSOCIATED PRODUCT PARTS
        //

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
                Part SelectedPart = ProdAssocPartsView.CurrentRow.DataBoundItem as Part;
                AddedParts.Remove(SelectedPart);
            }
        }

        //
        //CANCEL PRODUCT ADD
        //

        private void CancelProdAddBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        //ADD PRODUCT
        //
        private void SubmitProdAddBtn_Click(object sender, EventArgs e)
        {
            string a = AddProdNameTextBox.Text;
            string b = AddProdPriceTextBox.Text;
            string c = AddProdInStockTextBox.Text;
            string d = AddProdMinTextBox.Text;
            string f = AddProdMaxTextBox.Text;

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
                Inventory.CreateNewProduct(a, b, c, d, f);
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
