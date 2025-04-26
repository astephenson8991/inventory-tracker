namespace Inventory2
{
    partial class ModifyPartForm
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
            this.PartIDTextBox = new System.Windows.Forms.TextBox();
            this.PartIDLabel = new System.Windows.Forms.Label();
            this.OutsourceRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.PartNameTextBox = new System.Windows.Forms.TextBox();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartInStockTextBox = new System.Windows.Forms.TextBox();
            this.PartInStockLabel = new System.Windows.Forms.Label();
            this.PartPriceTextBox = new System.Windows.Forms.TextBox();
            this.PartPriceLabel = new System.Windows.Forms.Label();
            this.PartMaxTextBox = new System.Windows.Forms.TextBox();
            this.PartMaxLabel = new System.Windows.Forms.Label();
            this.PartMinTextBox = new System.Windows.Forms.TextBox();
            this.PartMinLabel = new System.Windows.Forms.Label();
            this.PartMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.PartMachineIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PartOutTextBox = new System.Windows.Forms.TextBox();
            this.PartOutLabel = new System.Windows.Forms.Label();
            this.SubmitPartUpdateBtn = new System.Windows.Forms.Button();
            this.CancelPartModBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartIDTextBox
            // 
            this.PartIDTextBox.Enabled = false;
            this.PartIDTextBox.Location = new System.Drawing.Point(173, 117);
            this.PartIDTextBox.Name = "PartIDTextBox";
            this.PartIDTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartIDTextBox.TabIndex = 7;
            // 
            // PartIDLabel
            // 
            this.PartIDLabel.AutoSize = true;
            this.PartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDLabel.Location = new System.Drawing.Point(138, 117);
            this.PartIDLabel.Name = "PartIDLabel";
            this.PartIDLabel.Size = new System.Drawing.Size(28, 20);
            this.PartIDLabel.TabIndex = 6;
            this.PartIDLabel.Text = "ID";
            // 
            // OutsourceRadio
            // 
            this.OutsourceRadio.AutoSize = true;
            this.OutsourceRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourceRadio.Location = new System.Drawing.Point(219, 62);
            this.OutsourceRadio.Name = "OutsourceRadio";
            this.OutsourceRadio.Size = new System.Drawing.Size(117, 17);
            this.OutsourceRadio.TabIndex = 5;
            this.OutsourceRadio.TabStop = true;
            this.OutsourceRadio.Text = "Outsourced Part";
            this.OutsourceRadio.UseVisualStyleBackColor = true;
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadio.Location = new System.Drawing.Point(90, 62);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(103, 17);
            this.InHouseRadio.TabIndex = 4;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House Part";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // PartNameTextBox
            // 
            this.PartNameTextBox.Location = new System.Drawing.Point(173, 143);
            this.PartNameTextBox.Name = "PartNameTextBox";
            this.PartNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartNameTextBox.TabIndex = 9;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.Location = new System.Drawing.Point(111, 143);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(55, 20);
            this.PartNameLabel.TabIndex = 8;
            this.PartNameLabel.Text = "Name";
            // 
            // PartInStockTextBox
            // 
            this.PartInStockTextBox.Location = new System.Drawing.Point(173, 169);
            this.PartInStockTextBox.Name = "PartInStockTextBox";
            this.PartInStockTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartInStockTextBox.TabIndex = 11;
            // 
            // PartInStockLabel
            // 
            this.PartInStockLabel.AutoSize = true;
            this.PartInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartInStockLabel.Location = new System.Drawing.Point(83, 169);
            this.PartInStockLabel.Name = "PartInStockLabel";
            this.PartInStockLabel.Size = new System.Drawing.Size(83, 20);
            this.PartInStockLabel.TabIndex = 10;
            this.PartInStockLabel.Text = "Inventory";
            // 
            // PartPriceTextBox
            // 
            this.PartPriceTextBox.Location = new System.Drawing.Point(173, 195);
            this.PartPriceTextBox.Name = "PartPriceTextBox";
            this.PartPriceTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartPriceTextBox.TabIndex = 13;
            // 
            // PartPriceLabel
            // 
            this.PartPriceLabel.AutoSize = true;
            this.PartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartPriceLabel.Location = new System.Drawing.Point(117, 195);
            this.PartPriceLabel.Name = "PartPriceLabel";
            this.PartPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PartPriceLabel.TabIndex = 12;
            this.PartPriceLabel.Text = "Price";
            // 
            // PartMaxTextBox
            // 
            this.PartMaxTextBox.Location = new System.Drawing.Point(173, 221);
            this.PartMaxTextBox.Name = "PartMaxTextBox";
            this.PartMaxTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartMaxTextBox.TabIndex = 15;
            // 
            // PartMaxLabel
            // 
            this.PartMaxLabel.AutoSize = true;
            this.PartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMaxLabel.Location = new System.Drawing.Point(125, 221);
            this.PartMaxLabel.Name = "PartMaxLabel";
            this.PartMaxLabel.Size = new System.Drawing.Size(41, 20);
            this.PartMaxLabel.TabIndex = 14;
            this.PartMaxLabel.Text = "Max";
            // 
            // PartMinTextBox
            // 
            this.PartMinTextBox.Location = new System.Drawing.Point(173, 247);
            this.PartMinTextBox.Name = "PartMinTextBox";
            this.PartMinTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartMinTextBox.TabIndex = 17;
            // 
            // PartMinLabel
            // 
            this.PartMinLabel.AutoSize = true;
            this.PartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMinLabel.Location = new System.Drawing.Point(129, 247);
            this.PartMinLabel.Name = "PartMinLabel";
            this.PartMinLabel.Size = new System.Drawing.Size(37, 20);
            this.PartMinLabel.TabIndex = 16;
            this.PartMinLabel.Text = "Min";
            // 
            // PartMachineIDTextBox
            // 
            this.PartMachineIDTextBox.Location = new System.Drawing.Point(173, 273);
            this.PartMachineIDTextBox.Name = "PartMachineIDTextBox";
            this.PartMachineIDTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartMachineIDTextBox.TabIndex = 19;
            // 
            // PartMachineIDLabel
            // 
            this.PartMachineIDLabel.AutoSize = true;
            this.PartMachineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMachineIDLabel.Location = new System.Drawing.Point(66, 273);
            this.PartMachineIDLabel.Name = "PartMachineIDLabel";
            this.PartMachineIDLabel.Size = new System.Drawing.Size(100, 20);
            this.PartMachineIDLabel.TabIndex = 18;
            this.PartMachineIDLabel.Text = "Machine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "PART MODIFICATION";
            // 
            // PartOutTextBox
            // 
            this.PartOutTextBox.Location = new System.Drawing.Point(173, 299);
            this.PartOutTextBox.Name = "PartOutTextBox";
            this.PartOutTextBox.Size = new System.Drawing.Size(136, 20);
            this.PartOutTextBox.TabIndex = 22;
            // 
            // PartOutLabel
            // 
            this.PartOutLabel.AutoSize = true;
            this.PartOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartOutLabel.Location = new System.Drawing.Point(32, 299);
            this.PartOutLabel.Name = "PartOutLabel";
            this.PartOutLabel.Size = new System.Drawing.Size(134, 20);
            this.PartOutLabel.TabIndex = 21;
            this.PartOutLabel.Text = "Company Name";
            // 
            // SubmitPartUpdateBtn
            // 
            this.SubmitPartUpdateBtn.Location = new System.Drawing.Point(173, 341);
            this.SubmitPartUpdateBtn.Name = "SubmitPartUpdateBtn";
            this.SubmitPartUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitPartUpdateBtn.TabIndex = 23;
            this.SubmitPartUpdateBtn.Text = "Submit";
            this.SubmitPartUpdateBtn.UseVisualStyleBackColor = true;
            this.SubmitPartUpdateBtn.Click += new System.EventHandler(this.SubmitPartUpdateBtn_Click);
            // 
            // CancelPartModBtn
            // 
            this.CancelPartModBtn.Location = new System.Drawing.Point(173, 370);
            this.CancelPartModBtn.Name = "CancelPartModBtn";
            this.CancelPartModBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelPartModBtn.TabIndex = 24;
            this.CancelPartModBtn.Text = "Cancel";
            this.CancelPartModBtn.UseVisualStyleBackColor = true;
            this.CancelPartModBtn.Click += new System.EventHandler(this.CancelPartModBtn_Click);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.ControlBox = false;
            this.Controls.Add(this.CancelPartModBtn);
            this.Controls.Add(this.SubmitPartUpdateBtn);
            this.Controls.Add(this.PartOutTextBox);
            this.Controls.Add(this.PartOutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartMachineIDTextBox);
            this.Controls.Add(this.PartMachineIDLabel);
            this.Controls.Add(this.PartMinTextBox);
            this.Controls.Add(this.PartMinLabel);
            this.Controls.Add(this.PartMaxTextBox);
            this.Controls.Add(this.PartMaxLabel);
            this.Controls.Add(this.PartPriceTextBox);
            this.Controls.Add(this.PartPriceLabel);
            this.Controls.Add(this.PartInStockTextBox);
            this.Controls.Add(this.PartInStockLabel);
            this.Controls.Add(this.PartNameTextBox);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.PartIDTextBox);
            this.Controls.Add(this.PartIDLabel);
            this.Controls.Add(this.OutsourceRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartIDTextBox;
        private System.Windows.Forms.Label PartIDLabel;
        private System.Windows.Forms.RadioButton OutsourceRadio;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.TextBox PartNameTextBox;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.TextBox PartInStockTextBox;
        private System.Windows.Forms.Label PartInStockLabel;
        private System.Windows.Forms.TextBox PartPriceTextBox;
        private System.Windows.Forms.Label PartPriceLabel;
        private System.Windows.Forms.TextBox PartMaxTextBox;
        private System.Windows.Forms.Label PartMaxLabel;
        private System.Windows.Forms.TextBox PartMinTextBox;
        private System.Windows.Forms.Label PartMinLabel;
        private System.Windows.Forms.TextBox PartMachineIDTextBox;
        private System.Windows.Forms.Label PartMachineIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PartOutTextBox;
        private System.Windows.Forms.Label PartOutLabel;
        private System.Windows.Forms.Button SubmitPartUpdateBtn;
        private System.Windows.Forms.Button CancelPartModBtn;
    }
}