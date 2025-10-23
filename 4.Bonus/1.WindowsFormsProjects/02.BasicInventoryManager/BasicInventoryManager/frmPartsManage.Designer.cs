namespace BasicInventoryManager
{
    partial class FrmPartsManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartsManage));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSellerUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(354, 572);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 37);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Save New Part";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.PartId,
            this.PartPrice,
            this.btnDelete,
            this.btnUpdate});
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(33, 16);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(789, 425);
            this.dgv.TabIndex = 0;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClick);
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "Name";
            this.PartName.FillWeight = 113.9843F;
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 8;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // PartId
            // 
            this.PartId.DataPropertyName = "Id";
            this.PartId.FillWeight = 113.9843F;
            this.PartId.HeaderText = "Part Number";
            this.PartId.MinimumWidth = 8;
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            // 
            // PartPrice
            // 
            this.PartPrice.DataPropertyName = "Price";
            this.PartPrice.FillWeight = 113.9843F;
            this.PartPrice.HeaderText = "Part Price";
            this.PartPrice.MinimumWidth = 8;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 76.14214F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
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
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.txtId);
            this.groupBox.Controls.Add(this.txtPrice);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(41, 449);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(781, 105);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Part Information:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(621, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 35);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(382, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 35);
            this.txtId.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 40);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 35);
            this.txtPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnSellerUpdate
            // 
            this.btnSellerUpdate.Enabled = false;
            this.btnSellerUpdate.Location = new System.Drawing.Point(517, 572);
            this.btnSellerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellerUpdate.Name = "btnSellerUpdate";
            this.btnSellerUpdate.Size = new System.Drawing.Size(123, 37);
            this.btnSellerUpdate.TabIndex = 9;
            this.btnSellerUpdate.Text = "Edit Part";
            this.btnSellerUpdate.UseVisualStyleBackColor = true;
            this.btnSellerUpdate.Click += new System.EventHandler(this.BtnSellerUpdateClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(239, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // FrmPartsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(858, 622);
            this.Controls.Add(this.btnSellerUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPartsManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmPartsManageLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.Button btnSellerUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}