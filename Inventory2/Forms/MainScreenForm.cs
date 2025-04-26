using Inventory2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            PartsView.DataSource = Inventory.Parts;

            ProductView.DataSource = Inventory.Products;

        }

        //
        //EXIT BUTTON
        //

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        //PART ADD BUTTON
        //

        private void PartsAddBtn_Click(object sender, EventArgs e)
        {
            var AddPartForm = new AddPartForm();
            AddPartForm.Show();
        }

        //
        //PART UPDATE BUTTON
        //

        private void PartsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inventory.Parts.Count <= 0)
                {
                    MessageBox.Show("There are no parts to update!");
                }

                else if (PartsView.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("You must select a part to modify.");
                }

                else if (PartsView.CurrentRow.DataBoundItem.GetType() == typeof(Inventory2.InPart))
                {
                    InPart SelectedPart = PartsView.CurrentRow.DataBoundItem as InPart;
                    var ModifyPartForm = new ModifyPartForm(SelectedPart);
                    ModifyPartForm.Show();
                }
                else if (PartsView.CurrentRow.DataBoundItem.GetType() == typeof(Inventory2.OutPart))
                {
                    OutPart selectedPart = PartsView.CurrentRow.DataBoundItem as OutPart;
                    var ModifyPartForm = new ModifyPartForm(selectedPart);
                    ModifyPartForm.Show();
                }
            }
            catch { MessageBox.Show("Please ensure you have a part selected and try again."); return; }
        }

        //
        //PART DELETE BUTTON
        //

        private void PartsDelete_Click(object sender, EventArgs e)
        {
            if (PartsView.CurrentRow == null || !PartsView.CurrentRow.Selected)
            {
                MessageBox.Show("There is no part selected.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Part p = PartsView.CurrentRow.DataBoundItem as Part;

                Inventory.Parts.Remove(p);
            }
            else
            {
                MessageBox.Show("Item was not deleted!");
            }
        }

        //
        //PART SEARCH
        //

        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {
            string Text = PartsSearchBox.Text;
            ResetPartSearch.Visible = true;
            CurrencyManager cMan = (CurrencyManager)BindingContext[PartsView.DataSource];
            cMan.SuspendBinding();
            int VisibleCount = 0;

            try
            {

                foreach (DataGridViewRow row in PartsView.Rows)
                {

                    if (row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        PartsView.Rows[row.Index].Selected = true;
                        VisibleCount++;
                    }
                    else if (!row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        PartsView.Rows[row.Index].Selected = false;
                        PartsView.Rows[row.Index].Visible = false;
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
                ResetPartSearch_Click(sender, e);
            }
        }

        private void ResetPartSearch_Click(object sender, EventArgs e)
        {
            PartsSearchBox.Text = string.Empty;

            foreach (DataGridViewRow row in PartsView.Rows)
            {
                if (PartsView.Rows[row.Index].Visible == false)
                {
                    PartsView.Rows[row.Index].Visible = true;
                }
            }
            ResetPartSearch.Visible = false;

            CurrencyManager cMan = (CurrencyManager)BindingContext[PartsView.DataSource];
            cMan.ResumeBinding();
        }

        //
        //ADD PRODUCT BUTTON
        //

        private void ProductsAdd_Click(object sender, EventArgs e)
        {
            var AddProductForm = new AddProductForm();
            AddProductForm.Show();
        }

        //
        //PRODUCT UPDATE BUTTON
        //

        private void ProductsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inventory.Products.Count <= 0)
                {
                    MessageBox.Show("There are no products to update!");
                }

                else if (PartsView.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("You must select a product to modify.");
                }

                else
                {
                    Product SelectedProduct = ProductView.CurrentRow.DataBoundItem as Product;
                    var ModProdForm = new ModifyProductForm(SelectedProduct);
                    ModProdForm.Show();
                }
            }
            catch { MessageBox.Show("Please ensure you have a product selected and try again."); return; }
        }

        //
        //PRODUCT DELETE BUTTON
        //

        private void ProductsDelete_Click(object sender, EventArgs e)
        {
            if (ProductView.CurrentRow == null || !PartsView.CurrentRow.Selected)
            {
                MessageBox.Show("There is no product selected.");
                return;
            }

            Product CheckP = ProductView.CurrentRow.DataBoundItem as Product;

            if (CheckP.AssociatedParts.Count == 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Product p = ProductView.CurrentRow.DataBoundItem as Product;

                    Inventory.Products.Remove(p);
                }
                else
                {
                    MessageBox.Show("Item was not deleted!");
                }
            }
            else
            {
                MessageBox.Show("There are parts associated with this product. Please remove associations before deleting.");
            }
        }

        private void ProductsSearchBox_TextChanged(object sender, EventArgs e)
        {
            string Text = ProductsSearchBox.Text;
            ResetProductSearch.Visible = true;
            CurrencyManager cMan = (CurrencyManager)BindingContext[ProductView.DataSource];
            cMan.SuspendBinding();
            int VisibleCount = 0;

            try
            {
                foreach (DataGridViewRow row in ProductView.Rows)
                {
                    if (row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ProductView.Rows[row.Index].Selected = true;
                        VisibleCount++;
                    }
                    else if (!row.Cells[1].Value.ToString().StartsWith(Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        ProductView.Rows[row.Index].Selected = false;
                        ProductView.Rows[row.Index].Visible = false;
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
                ResetProductSearch_Click(sender, e);
            }
        }

        private void ResetProductSearch_Click(object sender, EventArgs e)
        {
            ProductsSearchBox.Text = string.Empty;

            foreach (DataGridViewRow row in ProductView.Rows)
            {
                if (ProductView.Rows[row.Index].Visible == false)
                {
                    ProductView.Rows[row.Index].Visible = true;
                }
            }
            ResetProductSearch.Visible = false;

            CurrencyManager cMan = (CurrencyManager)BindingContext[ProductView.DataSource];
            cMan.ResumeBinding();
        }
    }
}
