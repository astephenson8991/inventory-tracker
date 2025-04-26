using System.ComponentModel;

namespace Inventory2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.PartsView = new System.Windows.Forms.DataGridView();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.PartsAddBtn = new System.Windows.Forms.Button();
            this.PartsUpdate = new System.Windows.Forms.Button();
            this.PartsDelete = new System.Windows.Forms.Button();
            this.ProductsAdd = new System.Windows.Forms.Button();
            this.ProductsUpdate = new System.Windows.Forms.Button();
            this.ProductsDelete = new System.Windows.Forms.Button();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsSearchBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchPartsLabel = new System.Windows.Forms.Label();
            this.SearchProductLabel = new System.Windows.Forms.Label();
            this.ResetPartSearch = new System.Windows.Forms.Button();
            this.ResetProductSearch = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsView
            // 
            this.PartsView.AllowUserToAddRows = false;
            this.PartsView.AllowUserToDeleteRows = false;
            this.PartsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.PartsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.PartsView.Location = new System.Drawing.Point(12, 60);
            this.PartsView.MultiSelect = false;
            this.PartsView.Name = "PartsView";
            this.PartsView.ReadOnly = true;
            this.PartsView.RowHeadersVisible = false;
            this.PartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsView.Size = new System.Drawing.Size(378, 272);
            this.PartsView.TabIndex = 0;
            // 
            // ProductView
            // 
            this.ProductView.AllowUserToAddRows = false;
            this.ProductView.AllowUserToDeleteRows = false;
            this.ProductView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.ProductView.Location = new System.Drawing.Point(410, 60);
            this.ProductView.MultiSelect = false;
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            this.ProductView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProductView.RowHeadersVisible = false;
            this.ProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductView.Size = new System.Drawing.Size(378, 272);
            this.ProductView.TabIndex = 1;
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(12, 22);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(67, 20);
            this.PartsLabel.TabIndex = 2;
            this.PartsLabel.Text = "PARTS";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(406, 22);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(106, 20);
            this.ProductsLabel.TabIndex = 3;
            this.ProductsLabel.Text = "PRODUCTS";
            // 
            // PartsAddBtn
            // 
            this.PartsAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PartsAddBtn.Location = new System.Drawing.Point(12, 338);
            this.PartsAddBtn.Name = "PartsAddBtn";
            this.PartsAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PartsAddBtn.TabIndex = 4;
            this.PartsAddBtn.Text = "ADD";
            this.PartsAddBtn.UseVisualStyleBackColor = true;
            this.PartsAddBtn.Click += new System.EventHandler(this.PartsAddBtn_Click);
            // 
            // PartsUpdate
            // 
            this.PartsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PartsUpdate.Location = new System.Drawing.Point(12, 367);
            this.PartsUpdate.Name = "PartsUpdate";
            this.PartsUpdate.Size = new System.Drawing.Size(75, 23);
            this.PartsUpdate.TabIndex = 5;
            this.PartsUpdate.Text = "MODIFY";
            this.PartsUpdate.UseVisualStyleBackColor = true;
            this.PartsUpdate.Click += new System.EventHandler(this.PartsUpdate_Click);
            // 
            // PartsDelete
            // 
            this.PartsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PartsDelete.Location = new System.Drawing.Point(12, 396);
            this.PartsDelete.Name = "PartsDelete";
            this.PartsDelete.Size = new System.Drawing.Size(75, 23);
            this.PartsDelete.TabIndex = 6;
            this.PartsDelete.Text = "DELETE";
            this.PartsDelete.UseVisualStyleBackColor = true;
            this.PartsDelete.Click += new System.EventHandler(this.PartsDelete_Click);
            // 
            // ProductsAdd
            // 
            this.ProductsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsAdd.Location = new System.Drawing.Point(410, 338);
            this.ProductsAdd.Name = "ProductsAdd";
            this.ProductsAdd.Size = new System.Drawing.Size(75, 23);
            this.ProductsAdd.TabIndex = 7;
            this.ProductsAdd.Text = "ADD";
            this.ProductsAdd.UseVisualStyleBackColor = true;
            this.ProductsAdd.Click += new System.EventHandler(this.ProductsAdd_Click);
            // 
            // ProductsUpdate
            // 
            this.ProductsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsUpdate.Location = new System.Drawing.Point(410, 367);
            this.ProductsUpdate.Name = "ProductsUpdate";
            this.ProductsUpdate.Size = new System.Drawing.Size(75, 23);
            this.ProductsUpdate.TabIndex = 8;
            this.ProductsUpdate.Text = "MODIFY";
            this.ProductsUpdate.UseVisualStyleBackColor = true;
            this.ProductsUpdate.Click += new System.EventHandler(this.ProductsUpdate_Click);
            // 
            // ProductsDelete
            // 
            this.ProductsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsDelete.Location = new System.Drawing.Point(410, 396);
            this.ProductsDelete.Name = "ProductsDelete";
            this.ProductsDelete.Size = new System.Drawing.Size(75, 23);
            this.ProductsDelete.TabIndex = 9;
            this.ProductsDelete.Text = "DELETE";
            this.ProductsDelete.UseVisualStyleBackColor = true;
            this.ProductsDelete.Click += new System.EventHandler(this.ProductsDelete_Click);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(290, 34);
            this.PartsSearchBox.MaxLength = 40;
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PartsSearchBox.Size = new System.Drawing.Size(100, 20);
            this.PartsSearchBox.TabIndex = 12;
            this.PartsSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartsSearchBox.TextChanged += new System.EventHandler(this.PartsSearchBox_TextChanged);
            // 
            // ProductsSearchBox
            // 
            this.ProductsSearchBox.Location = new System.Drawing.Point(688, 35);
            this.ProductsSearchBox.MaxLength = 40;
            this.ProductsSearchBox.Name = "ProductsSearchBox";
            this.ProductsSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductsSearchBox.Size = new System.Drawing.Size(100, 20);
            this.ProductsSearchBox.TabIndex = 13;
            this.ProductsSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductsSearchBox.TextChanged += new System.EventHandler(this.ProductsSearchBox_TextChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.Location = new System.Drawing.Point(743, 415);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(45, 23);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchPartsLabel
            // 
            this.SearchPartsLabel.AutoSize = true;
            this.SearchPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPartsLabel.Location = new System.Drawing.Point(231, 35);
            this.SearchPartsLabel.Name = "SearchPartsLabel";
            this.SearchPartsLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchPartsLabel.TabIndex = 15;
            this.SearchPartsLabel.Text = "Search";
            // 
            // SearchProductLabel
            // 
            this.SearchProductLabel.AutoSize = true;
            this.SearchProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductLabel.Location = new System.Drawing.Point(629, 38);
            this.SearchProductLabel.Name = "SearchProductLabel";
            this.SearchProductLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchProductLabel.TabIndex = 16;
            this.SearchProductLabel.Text = "Search";
            // 
            // ResetPartSearch
            // 
            this.ResetPartSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetPartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPartSearch.Location = new System.Drawing.Point(315, 6);
            this.ResetPartSearch.Name = "ResetPartSearch";
            this.ResetPartSearch.Size = new System.Drawing.Size(75, 23);
            this.ResetPartSearch.TabIndex = 17;
            this.ResetPartSearch.Text = "Reset";
            this.ResetPartSearch.UseVisualStyleBackColor = true;
            this.ResetPartSearch.Visible = false;
            this.ResetPartSearch.Click += new System.EventHandler(this.ResetPartSearch_Click);
            // 
            // ResetProductSearch
            // 
            this.ResetProductSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetProductSearch.Location = new System.Drawing.Point(713, 6);
            this.ResetProductSearch.Name = "ResetProductSearch";
            this.ResetProductSearch.Size = new System.Drawing.Size(75, 23);
            this.ResetProductSearch.TabIndex = 18;
            this.ResetProductSearch.Text = "Reset";
            this.ResetProductSearch.UseVisualStyleBackColor = true;
            this.ResetProductSearch.Visible = false;
            this.ResetProductSearch.Click += new System.EventHandler(this.ResetProductSearch_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PartName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PartPrice";
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PartInStock";
            this.Column4.HeaderText = "Inventory";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PartMin";
            this.Column5.HeaderText = "Min";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 49;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PartMax";
            this.Column6.HeaderText = "Max";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 52;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProductID";
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 43;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProductName";
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 95;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ProductPrice";
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 56;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ProductInStock";
            this.Column10.HeaderText = "Inventory";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ProductMin";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 49;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ProductMax";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 52;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ResetProductSearch);
            this.Controls.Add(this.ResetPartSearch);
            this.Controls.Add(this.SearchProductLabel);
            this.Controls.Add(this.SearchPartsLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ProductsSearchBox);
            this.Controls.Add(this.PartsSearchBox);
            this.Controls.Add(this.ProductsDelete);
            this.Controls.Add(this.ProductsUpdate);
            this.Controls.Add(this.ProductsAdd);
            this.Controls.Add(this.PartsDelete);
            this.Controls.Add(this.PartsUpdate);
            this.Controls.Add(this.PartsAddBtn);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.PartsView);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsView;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button PartsAddBtn;
        private System.Windows.Forms.Button PartsUpdate;
        private System.Windows.Forms.Button PartsDelete;
        private System.Windows.Forms.Button ProductsAdd;
        private System.Windows.Forms.Button ProductsUpdate;
        private System.Windows.Forms.Button ProductsDelete;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.TextBox ProductsSearchBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label SearchPartsLabel;
        private System.Windows.Forms.Label SearchProductLabel;
        private System.Windows.Forms.Button ResetPartSearch;
        private System.Windows.Forms.Button ResetProductSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

