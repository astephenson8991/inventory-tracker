namespace Inventory2.Forms
{
    partial class ModifyProductForm
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
        private void InitializeComponent()
        {
            this.ProdAssocPartsView = new System.Windows.Forms.DataGridView();
            this.ProdResetPartSearch = new System.Windows.Forms.Button();
            this.SearchPartsLabel = new System.Windows.Forms.Label();
            this.ProdPartsSearchBox = new System.Windows.Forms.TextBox();
            this.RemoveProdPartBtn = new System.Windows.Forms.Button();
            this.AddProdPartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdPartsView = new System.Windows.Forms.DataGridView();
            this.CancelModProdBtn = new System.Windows.Forms.Button();
            this.SubmitModProdBtn = new System.Windows.Forms.Button();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.ModProdMinTextBox = new System.Windows.Forms.TextBox();
            this.AddPartMinLabel = new System.Windows.Forms.Label();
            this.ModProdMaxTextBox = new System.Windows.Forms.TextBox();
            this.AddPartMaxLabel = new System.Windows.Forms.Label();
            this.ModProdPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddPartPriceLabel = new System.Windows.Forms.Label();
            this.ModProdInStockTextBox = new System.Windows.Forms.TextBox();
            this.AddPartInStockLabel = new System.Windows.Forms.Label();
            this.ModProdNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPartNameLabel = new System.Windows.Forms.Label();
            this.ModProdIDTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProdIDLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.ProdAssocPartsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPartsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdAssocPartsView
            // 
            this.ProdAssocPartsView.AllowUserToAddRows = false;
            this.ProdAssocPartsView.AllowUserToDeleteRows = false;
            this.ProdAssocPartsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdAssocPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdAssocPartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.ProdAssocPartsView.Location = new System.Drawing.Point(320, 234);
            this.ProdAssocPartsView.MultiSelect = false;
            this.ProdAssocPartsView.Name = "ProdAssocPartsView";
            this.ProdAssocPartsView.ReadOnly = true;
            this.ProdAssocPartsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProdAssocPartsView.RowHeadersVisible = false;
            this.ProdAssocPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdAssocPartsView.Size = new System.Drawing.Size(469, 128);
            this.ProdAssocPartsView.TabIndex = 85;
            // 
            // ProdResetPartSearch
            // 
            this.ProdResetPartSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProdResetPartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdResetPartSearch.Location = new System.Drawing.Point(714, 20);
            this.ProdResetPartSearch.Name = "ProdResetPartSearch";
            this.ProdResetPartSearch.Size = new System.Drawing.Size(75, 23);
            this.ProdResetPartSearch.TabIndex = 84;
            this.ProdResetPartSearch.Text = "Reset";
            this.ProdResetPartSearch.UseVisualStyleBackColor = true;
            this.ProdResetPartSearch.Visible = false;
            this.ProdResetPartSearch.Click += new System.EventHandler(this.ProdResetPartSearch_Click);
            // 
            // SearchPartsLabel
            // 
            this.SearchPartsLabel.AutoSize = true;
            this.SearchPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPartsLabel.Location = new System.Drawing.Point(630, 49);
            this.SearchPartsLabel.Name = "SearchPartsLabel";
            this.SearchPartsLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchPartsLabel.TabIndex = 83;
            this.SearchPartsLabel.Text = "Search";
            // 
            // ProdPartsSearchBox
            // 
            this.ProdPartsSearchBox.Location = new System.Drawing.Point(689, 48);
            this.ProdPartsSearchBox.MaxLength = 40;
            this.ProdPartsSearchBox.Name = "ProdPartsSearchBox";
            this.ProdPartsSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProdPartsSearchBox.Size = new System.Drawing.Size(100, 20);
            this.ProdPartsSearchBox.TabIndex = 82;
            this.ProdPartsSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProdPartsSearchBox.TextChanged += new System.EventHandler(this.ProdPartsSearchBox_TextChanged);
            // 
            // RemoveProdPartBtn
            // 
            this.RemoveProdPartBtn.Location = new System.Drawing.Point(714, 368);
            this.RemoveProdPartBtn.Name = "RemoveProdPartBtn";
            this.RemoveProdPartBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveProdPartBtn.TabIndex = 87;
            this.RemoveProdPartBtn.Text = "Remove";
            this.RemoveProdPartBtn.UseVisualStyleBackColor = true;
            this.RemoveProdPartBtn.Click += new System.EventHandler(this.RemoveProdPartBtn_Click);
            // 
            // AddProdPartBtn
            // 
            this.AddProdPartBtn.Location = new System.Drawing.Point(714, 205);
            this.AddProdPartBtn.Name = "AddProdPartBtn";
            this.AddProdPartBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProdPartBtn.TabIndex = 86;
            this.AddProdPartBtn.Text = "Add";
            this.AddProdPartBtn.UseVisualStyleBackColor = true;
            this.AddProdPartBtn.Click += new System.EventHandler(this.AddProdPartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Associated Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "All Available Parts";
            // 
            // ProdPartsView
            // 
            this.ProdPartsView.AllowUserToAddRows = false;
            this.ProdPartsView.AllowUserToDeleteRows = false;
            this.ProdPartsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdPartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ProdPartsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProdPartsView.Location = new System.Drawing.Point(320, 74);
            this.ProdPartsView.MultiSelect = false;
            this.ProdPartsView.Name = "ProdPartsView";
            this.ProdPartsView.ReadOnly = true;
            this.ProdPartsView.RowHeadersVisible = false;
            this.ProdPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdPartsView.Size = new System.Drawing.Size(469, 128);
            this.ProdPartsView.TabIndex = 81;
            // 
            // CancelModProdBtn
            // 
            this.CancelModProdBtn.Location = new System.Drawing.Point(619, 415);
            this.CancelModProdBtn.Name = "CancelModProdBtn";
            this.CancelModProdBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelModProdBtn.TabIndex = 80;
            this.CancelModProdBtn.Text = "Cancel";
            this.CancelModProdBtn.UseVisualStyleBackColor = true;
            this.CancelModProdBtn.Click += new System.EventHandler(this.CancelModProdBtn_Click);
            // 
            // SubmitModProdBtn
            // 
            this.SubmitModProdBtn.Location = new System.Drawing.Point(523, 415);
            this.SubmitModProdBtn.Name = "SubmitModProdBtn";
            this.SubmitModProdBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitModProdBtn.TabIndex = 79;
            this.SubmitModProdBtn.Text = "Submit";
            this.SubmitModProdBtn.UseVisualStyleBackColor = true;
            this.SubmitModProdBtn.Click += new System.EventHandler(this.SubmitModProdBtn_Click);
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(11, 13);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(143, 22);
            this.ModifyProductLabel.TabIndex = 78;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // ModProdMinTextBox
            // 
            this.ModProdMinTextBox.Location = new System.Drawing.Point(106, 286);
            this.ModProdMinTextBox.Name = "ModProdMinTextBox";
            this.ModProdMinTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdMinTextBox.TabIndex = 77;
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLabel.Location = new System.Drawing.Point(62, 286);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(37, 20);
            this.AddPartMinLabel.TabIndex = 76;
            this.AddPartMinLabel.Text = "Min";
            // 
            // ModProdMaxTextBox
            // 
            this.ModProdMaxTextBox.Location = new System.Drawing.Point(106, 260);
            this.ModProdMaxTextBox.Name = "ModProdMaxTextBox";
            this.ModProdMaxTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdMaxTextBox.TabIndex = 75;
            // 
            // AddPartMaxLabel
            // 
            this.AddPartMaxLabel.AutoSize = true;
            this.AddPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMaxLabel.Location = new System.Drawing.Point(58, 260);
            this.AddPartMaxLabel.Name = "AddPartMaxLabel";
            this.AddPartMaxLabel.Size = new System.Drawing.Size(41, 20);
            this.AddPartMaxLabel.TabIndex = 74;
            this.AddPartMaxLabel.Text = "Max";
            // 
            // ModProdPriceTextBox
            // 
            this.ModProdPriceTextBox.Location = new System.Drawing.Point(106, 234);
            this.ModProdPriceTextBox.Name = "ModProdPriceTextBox";
            this.ModProdPriceTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdPriceTextBox.TabIndex = 73;
            // 
            // AddPartPriceLabel
            // 
            this.AddPartPriceLabel.AutoSize = true;
            this.AddPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartPriceLabel.Location = new System.Drawing.Point(50, 234);
            this.AddPartPriceLabel.Name = "AddPartPriceLabel";
            this.AddPartPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.AddPartPriceLabel.TabIndex = 72;
            this.AddPartPriceLabel.Text = "Price";
            // 
            // ModProdInStockTextBox
            // 
            this.ModProdInStockTextBox.Location = new System.Drawing.Point(106, 208);
            this.ModProdInStockTextBox.Name = "ModProdInStockTextBox";
            this.ModProdInStockTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdInStockTextBox.TabIndex = 71;
            // 
            // AddPartInStockLabel
            // 
            this.AddPartInStockLabel.AutoSize = true;
            this.AddPartInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartInStockLabel.Location = new System.Drawing.Point(16, 208);
            this.AddPartInStockLabel.Name = "AddPartInStockLabel";
            this.AddPartInStockLabel.Size = new System.Drawing.Size(83, 20);
            this.AddPartInStockLabel.TabIndex = 70;
            this.AddPartInStockLabel.Text = "Inventory";
            // 
            // ModProdNameTextBox
            // 
            this.ModProdNameTextBox.Location = new System.Drawing.Point(106, 182);
            this.ModProdNameTextBox.Name = "ModProdNameTextBox";
            this.ModProdNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdNameTextBox.TabIndex = 69;
            // 
            // AddPartNameLabel
            // 
            this.AddPartNameLabel.AutoSize = true;
            this.AddPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLabel.Location = new System.Drawing.Point(44, 182);
            this.AddPartNameLabel.Name = "AddPartNameLabel";
            this.AddPartNameLabel.Size = new System.Drawing.Size(55, 20);
            this.AddPartNameLabel.TabIndex = 68;
            this.AddPartNameLabel.Text = "Name";
            // 
            // ModProdIDTextBox
            // 
            this.ModProdIDTextBox.Enabled = false;
            this.ModProdIDTextBox.Location = new System.Drawing.Point(106, 156);
            this.ModProdIDTextBox.Name = "ModProdIDTextBox";
            this.ModProdIDTextBox.Size = new System.Drawing.Size(136, 20);
            this.ModProdIDTextBox.TabIndex = 67;
            // 
            // ModifyProdIDLabel
            // 
            this.ModifyProdIDLabel.AutoSize = true;
            this.ModifyProdIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProdIDLabel.Location = new System.Drawing.Point(71, 156);
            this.ModifyProdIDLabel.Name = "ModifyProdIDLabel";
            this.ModifyProdIDLabel.Size = new System.Drawing.Size(28, 20);
            this.ModifyProdIDLabel.TabIndex = 66;
            this.ModifyProdIDLabel.Text = "ID";
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
            this.Column7.DataPropertyName = "PartID";
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 43;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PartName";
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 95;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PartPrice";
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 56;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "PartInStock";
            this.Column10.HeaderText = "Inventory";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PartMin";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 49;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "PartMax";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 52;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ProdAssocPartsView);
            this.Controls.Add(this.ProdResetPartSearch);
            this.Controls.Add(this.SearchPartsLabel);
            this.Controls.Add(this.ProdPartsSearchBox);
            this.Controls.Add(this.RemoveProdPartBtn);
            this.Controls.Add(this.AddProdPartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdPartsView);
            this.Controls.Add(this.CancelModProdBtn);
            this.Controls.Add(this.SubmitModProdBtn);
            this.Controls.Add(this.ModifyProductLabel);
            this.Controls.Add(this.ModProdMinTextBox);
            this.Controls.Add(this.AddPartMinLabel);
            this.Controls.Add(this.ModProdMaxTextBox);
            this.Controls.Add(this.AddPartMaxLabel);
            this.Controls.Add(this.ModProdPriceTextBox);
            this.Controls.Add(this.AddPartPriceLabel);
            this.Controls.Add(this.ModProdInStockTextBox);
            this.Controls.Add(this.AddPartInStockLabel);
            this.Controls.Add(this.ModProdNameTextBox);
            this.Controls.Add(this.AddPartNameLabel);
            this.Controls.Add(this.ModProdIDTextBox);
            this.Controls.Add(this.ModifyProdIDLabel);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProdAssocPartsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdPartsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProdAssocPartsView;
        private System.Windows.Forms.Button ProdResetPartSearch;
        private System.Windows.Forms.Label SearchPartsLabel;
        private System.Windows.Forms.TextBox ProdPartsSearchBox;
        private System.Windows.Forms.Button RemoveProdPartBtn;
        private System.Windows.Forms.Button AddProdPartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProdPartsView;
        private System.Windows.Forms.Button CancelModProdBtn;
        private System.Windows.Forms.Button SubmitModProdBtn;
        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.TextBox ModProdMinTextBox;
        private System.Windows.Forms.Label AddPartMinLabel;
        private System.Windows.Forms.TextBox ModProdMaxTextBox;
        private System.Windows.Forms.Label AddPartMaxLabel;
        private System.Windows.Forms.TextBox ModProdPriceTextBox;
        private System.Windows.Forms.Label AddPartPriceLabel;
        private System.Windows.Forms.TextBox ModProdInStockTextBox;
        private System.Windows.Forms.Label AddPartInStockLabel;
        private System.Windows.Forms.TextBox ModProdNameTextBox;
        private System.Windows.Forms.Label AddPartNameLabel;
        private System.Windows.Forms.TextBox ModProdIDTextBox;
        private System.Windows.Forms.Label ModifyProdIDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}