namespace BasicInventoryManager
{
    partial class FrmRelations
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTablesName = new System.Windows.Forms.ComboBox();
            this.chkRelatPartAndPartSellNoYes = new System.Windows.Forms.CheckBox();
            this.cmbFieldsName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRelatSellerAndPartSellYesNo = new System.Windows.Forms.CheckBox();
            this.grpPPSSetting = new System.Windows.Forms.GroupBox();
            this.chkSettingPPSEdit = new System.Windows.Forms.CheckBox();
            this.chkSettingPPSDelete = new System.Windows.Forms.CheckBox();
            this.grpSPSSetting = new System.Windows.Forms.GroupBox();
            this.chkSettingSPSEdit = new System.Windows.Forms.CheckBox();
            this.chkSettingSPSDelete = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpPPSSetting.SuspendLayout();
            this.grpSPSSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Names:";
            // 
            // cmbTablesName
            // 
            this.cmbTablesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablesName.FormattingEnabled = true;
            this.cmbTablesName.Items.AddRange(new object[] {
            "Parts Table (Part)",
            "Sellers Table (Seller)",
            "Sales Table (PartSell)"});
            this.cmbTablesName.Location = new System.Drawing.Point(341, 24);
            this.cmbTablesName.Name = "cmbTablesName";
            this.cmbTablesName.Size = new System.Drawing.Size(229, 37);
            this.cmbTablesName.TabIndex = 1;
            this.cmbTablesName.SelectionChangeCommitted += new System.EventHandler(this.CmbTablesNameSelectionChangeCommitted);
            // 
            // chkRelatPartAndPartSellNoYes
            // 
            this.chkRelatPartAndPartSellNoYes.AutoSize = true;
            this.chkRelatPartAndPartSellNoYes.Checked = true;
            this.chkRelatPartAndPartSellNoYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRelatPartAndPartSellNoYes.Location = new System.Drawing.Point(96, 114);
            this.chkRelatPartAndPartSellNoYes.Name = "chkRelatPartAndPartSellNoYes";
            this.chkRelatPartAndPartSellNoYes.Size = new System.Drawing.Size(729, 33);
            this.chkRelatPartAndPartSellNoYes.TabIndex = 3;
            this.chkRelatPartAndPartSellNoYes.Text = "Should PartId in table Part relate to PartId in table PartSell?";
            this.chkRelatPartAndPartSellNoYes.UseVisualStyleBackColor = true;
            this.chkRelatPartAndPartSellNoYes.CheckedChanged += new System.EventHandler(this.ChkRelatPartAndPartSellNoYesCheckedChanged);
            // 
            // cmbFieldsName
            // 
            this.cmbFieldsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldsName.FormattingEnabled = true;
            this.cmbFieldsName.Location = new System.Drawing.Point(341, 71);
            this.cmbFieldsName.Name = "cmbFieldsName";
            this.cmbFieldsName.Size = new System.Drawing.Size(229, 37);
            this.cmbFieldsName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Field Names:";
            // 
            // chkRelatSellerAndPartSellYesNo
            // 
            this.chkRelatSellerAndPartSellYesNo.AutoSize = true;
            this.chkRelatSellerAndPartSellYesNo.Checked = true;
            this.chkRelatSellerAndPartSellYesNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRelatSellerAndPartSellYesNo.Location = new System.Drawing.Point(26, 275);
            this.chkRelatSellerAndPartSellYesNo.Name = "chkRelatSellerAndPartSellYesNo";
            this.chkRelatSellerAndPartSellYesNo.Size = new System.Drawing.Size(880, 33);
            this.chkRelatSellerAndPartSellYesNo.TabIndex = 6;
            this.chkRelatSellerAndPartSellYesNo.Text = "Should SellerCode in table Seller relate to SellerCode in table PartSell?";
            this.chkRelatSellerAndPartSellYesNo.UseVisualStyleBackColor = true;
            this.chkRelatSellerAndPartSellYesNo.CheckedChanged += new System.EventHandler(this.ChkRelatSellerAndPartSellYesNoCheckedChanged);
            // 
            // grpPPSSetting
            // 
            this.grpPPSSetting.Controls.Add(this.chkSettingPPSEdit);
            this.grpPPSSetting.Controls.Add(this.chkSettingPPSDelete);
            this.grpPPSSetting.Location = new System.Drawing.Point(151, 168);
            this.grpPPSSetting.Name = "grpPPSSetting";
            this.grpPPSSetting.Size = new System.Drawing.Size(591, 73);
            this.grpPPSSetting.TabIndex = 9;
            this.grpPPSSetting.TabStop = false;
            this.grpPPSSetting.Text = "Relation Settings:";
            // 
            // chkSettingPPSEdit
            // 
            this.chkSettingPPSEdit.AutoSize = true;
            this.chkSettingPPSEdit.Checked = true;
            this.chkSettingPPSEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettingPPSEdit.Location = new System.Drawing.Point(63, 31);
            this.chkSettingPPSEdit.Name = "chkSettingPPSEdit";
            this.chkSettingPPSEdit.Size = new System.Drawing.Size(156, 33);
            this.chkSettingPPSEdit.TabIndex = 4;
            this.chkSettingPPSEdit.Text = "Allow Edit";
            this.chkSettingPPSEdit.UseVisualStyleBackColor = true;
            // 
            // chkSettingPPSDelete
            // 
            this.chkSettingPPSDelete.AutoSize = true;
            this.chkSettingPPSDelete.Checked = true;
            this.chkSettingPPSDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettingPPSDelete.Location = new System.Drawing.Point(337, 31);
            this.chkSettingPPSDelete.Name = "chkSettingPPSDelete";
            this.chkSettingPPSDelete.Size = new System.Drawing.Size(187, 33);
            this.chkSettingPPSDelete.TabIndex = 3;
            this.chkSettingPPSDelete.Text = "Allow Delete";
            this.chkSettingPPSDelete.UseVisualStyleBackColor = true;
            // 
            // grpSPSSetting
            // 
            this.grpSPSSetting.Controls.Add(this.chkSettingSPSEdit);
            this.grpSPSSetting.Controls.Add(this.chkSettingSPSDelete);
            this.grpSPSSetting.Location = new System.Drawing.Point(151, 339);
            this.grpSPSSetting.Name = "grpSPSSetting";
            this.grpSPSSetting.Size = new System.Drawing.Size(591, 73);
            this.grpSPSSetting.TabIndex = 10;
            this.grpSPSSetting.TabStop = false;
            this.grpSPSSetting.Text = "Relation Settings:";
            // 
            // chkSettingSPSEdit
            // 
            this.chkSettingSPSEdit.AutoSize = true;
            this.chkSettingSPSEdit.Checked = true;
            this.chkSettingSPSEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettingSPSEdit.Location = new System.Drawing.Point(63, 31);
            this.chkSettingSPSEdit.Name = "chkSettingSPSEdit";
            this.chkSettingSPSEdit.Size = new System.Drawing.Size(156, 33);
            this.chkSettingSPSEdit.TabIndex = 4;
            this.chkSettingSPSEdit.Text = "Allow Edit";
            this.chkSettingSPSEdit.UseVisualStyleBackColor = true;
            // 
            // chkSettingSPSDelete
            // 
            this.chkSettingSPSDelete.AutoSize = true;
            this.chkSettingSPSDelete.Checked = true;
            this.chkSettingSPSDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettingSPSDelete.Location = new System.Drawing.Point(337, 31);
            this.chkSettingSPSDelete.Name = "chkSettingSPSDelete";
            this.chkSettingSPSDelete.Size = new System.Drawing.Size(187, 33);
            this.chkSettingSPSDelete.TabIndex = 3;
            this.chkSettingSPSDelete.Text = "Allow Delete";
            this.chkSettingSPSDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(398, 430);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 37);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Save Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // FrmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(942, 480);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpSPSSetting);
            this.Controls.Add(this.grpPPSSetting);
            this.Controls.Add(this.chkRelatSellerAndPartSellYesNo);
            this.Controls.Add(this.cmbFieldsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkRelatPartAndPartSellNoYes);
            this.Controls.Add(this.cmbTablesName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmRelations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relations Settings";
            this.grpPPSSetting.ResumeLayout(false);
            this.grpPPSSetting.PerformLayout();
            this.grpSPSSetting.ResumeLayout(false);
            this.grpSPSSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTablesName;
        private System.Windows.Forms.CheckBox chkRelatPartAndPartSellNoYes;
        private System.Windows.Forms.ComboBox cmbFieldsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRelatSellerAndPartSellYesNo;
        private System.Windows.Forms.GroupBox grpPPSSetting;
        private System.Windows.Forms.CheckBox chkSettingPPSEdit;
        private System.Windows.Forms.CheckBox chkSettingPPSDelete;
        private System.Windows.Forms.GroupBox grpSPSSetting;
        private System.Windows.Forms.CheckBox chkSettingSPSEdit;
        private System.Windows.Forms.CheckBox chkSettingSPSDelete;
        private System.Windows.Forms.Button btnSubmit;
    }
}