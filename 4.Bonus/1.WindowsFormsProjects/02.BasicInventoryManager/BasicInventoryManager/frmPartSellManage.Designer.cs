namespace BasicInventoryManager
{
    partial class FrmPartSellManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartSellManage));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.PartSellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSellerUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtPartSellId = new System.Windows.Forms.TextBox();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartSellId,
            this.SellerCode,
            this.PartId,
            this.btnDelete,
            this.btnUpdate,
            this.btnInfo});
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(13, 13);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(892, 371);
            this.dgv.TabIndex = 1;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClick);
            // 
            // PartSellId
            // 
            this.PartSellId.DataPropertyName = "PartSellId";
            this.PartSellId.HeaderText = "Sale ID";
            this.PartSellId.MinimumWidth = 8;
            this.PartSellId.Name = "PartSellId";
            this.PartSellId.ReadOnly = true;
            // 
            // SellerCode
            // 
            this.SellerCode.DataPropertyName = "SellerCode";
            this.SellerCode.HeaderText = "Seller Code";
            this.SellerCode.MinimumWidth = 8;
            this.SellerCode.Name = "SellerCode";
            this.SellerCode.ReadOnly = true;
            // 
            // PartId
            // 
            this.PartId.DataPropertyName = "PartId";
            this.PartId.HeaderText = "Part Number";
            this.PartId.MinimumWidth = 8;
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 76.14214F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.ToolTipText = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FillWeight = 81.90491F;
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.MinimumWidth = 8;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnUpdate.ToolTipText = "Edit";
            // 
            // btnInfo
            // 
            this.btnInfo.HeaderText = "";
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.MinimumWidth = 8;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ReadOnly = true;
            this.btnInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnInfo.ToolTipText = "Sale Info";
            // 
            // btnSellerUpdate
            // 
            this.btnSellerUpdate.Enabled = false;
            this.btnSellerUpdate.Location = new System.Drawing.Point(543, 513);
            this.btnSellerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellerUpdate.Name = "btnSellerUpdate";
            this.btnSellerUpdate.Size = new System.Drawing.Size(123, 37);
            this.btnSellerUpdate.TabIndex = 13;
            this.btnSellerUpdate.Text = "Edit Sale";
            this.btnSellerUpdate.UseVisualStyleBackColor = true;
            this.btnSellerUpdate.Click += new System.EventHandler(this.BtnSellerUpdateClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(253, 513);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtPartSellId);
            this.groupBox.Controls.Add(this.txtSellerId);
            this.groupBox.Controls.Add(this.txtPartId);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(13, 392);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(892, 105);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sale Information:";
            // 
            // txtPartSellId
            // 
            this.txtPartSellId.Location = new System.Drawing.Point(743, 43);
            this.txtPartSellId.Name = "txtPartSellId";
            this.txtPartSellId.Size = new System.Drawing.Size(134, 35);
            this.txtPartSellId.TabIndex = 0;
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(486, 46);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(150, 35);
            this.txtSellerId.TabIndex = 1;
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(138, 46);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(165, 35);
            this.txtPartId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seller Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(380, 513);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 37);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Save New Sale";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // FrmPartSellManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(915, 563);
            this.Controls.Add(this.btnSellerUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmPartSellManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Parts Sales by Sellers";
            this.Load += new System.EventHandler(this.FrmPartSellLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSellerUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtPartSellId;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartSellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn btnInfo;
    }
}