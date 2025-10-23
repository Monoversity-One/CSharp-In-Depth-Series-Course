namespace BasicInventoryManager
{
    partial class FrmSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelect));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPartSelecting = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSellerSelecting = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPart
            // 
            this.dgvPart.AllowUserToAddRows = false;
            this.dgvPart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.PartId,
            this.PartPrice,
            this.btnPartSelecting});
            this.dgvPart.EnableHeadersVisualStyles = false;
            this.dgvPart.Location = new System.Drawing.Point(16, 16);
            this.dgvPart.Margin = new System.Windows.Forms.Padding(7);
            this.dgvPart.MultiSelect = false;
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.RowHeadersWidth = 62;
            this.dgvPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPart.Size = new System.Drawing.Size(770, 539);
            this.dgvPart.TabIndex = 1;
            this.dgvPart.TabStop = false;
            this.dgvPart.Visible = false;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPartCellClick);
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
            // btnPartSelecting
            // 
            this.btnPartSelecting.FillWeight = 76.14214F;
            this.btnPartSelecting.HeaderText = "";
            this.btnPartSelecting.Image = ((System.Drawing.Image)(resources.GetObject("btnPartSelecting.Image")));
            this.btnPartSelecting.MinimumWidth = 8;
            this.btnPartSelecting.Name = "btnPartSelecting";
            this.btnPartSelecting.ReadOnly = true;
            this.btnPartSelecting.ToolTipText = "Select";
            // 
            // dgvSeller
            // 
            this.dgvSeller.AllowUserToAddRows = false;
            this.dgvSeller.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSeller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerName,
            this.Family,
            this.SellerCode,
            this.btnSellerSelecting});
            this.dgvSeller.EnableHeadersVisualStyles = false;
            this.dgvSeller.Location = new System.Drawing.Point(16, 16);
            this.dgvSeller.Margin = new System.Windows.Forms.Padding(7);
            this.dgvSeller.MultiSelect = false;
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.RowHeadersWidth = 62;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(770, 539);
            this.dgvSeller.TabIndex = 4;
            this.dgvSeller.TabStop = false;
            this.dgvSeller.Visible = false;
            this.dgvSeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSellerCellClick);
            // 
            // SellerName
            // 
            this.SellerName.DataPropertyName = "Name";
            this.SellerName.FillWeight = 113.9843F;
            this.SellerName.HeaderText = "Name";
            this.SellerName.MinimumWidth = 8;
            this.SellerName.Name = "SellerName";
            this.SellerName.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.FillWeight = 113.9843F;
            this.Family.HeaderText = "Family Name";
            this.Family.MinimumWidth = 8;
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // SellerCode
            // 
            this.SellerCode.DataPropertyName = "Code";
            this.SellerCode.FillWeight = 113.9843F;
            this.SellerCode.HeaderText = "Seller Code";
            this.SellerCode.MinimumWidth = 8;
            this.SellerCode.Name = "SellerCode";
            this.SellerCode.ReadOnly = true;
            // 
            // btnSellerSelecting
            // 
            this.btnSellerSelecting.FillWeight = 76.14214F;
            this.btnSellerSelecting.HeaderText = "";
            this.btnSellerSelecting.Image = ((System.Drawing.Image)(resources.GetObject("btnSellerSelecting.Image")));
            this.btnSellerSelecting.MinimumWidth = 8;
            this.btnSellerSelecting.Name = "btnSellerSelecting";
            this.btnSellerSelecting.ReadOnly = true;
            this.btnSellerSelecting.ToolTipText = "Select";
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(802, 571);
            this.Controls.Add(this.dgvSeller);
            this.Controls.Add(this.dgvPart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPart;
        private System.Windows.Forms.DataGridView dgvSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewImageColumn btnPartSelecting;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerCode;
        private System.Windows.Forms.DataGridViewImageColumn btnSellerSelecting;

    }
}