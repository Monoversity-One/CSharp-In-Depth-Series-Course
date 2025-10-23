namespace BoatReservationSystem
{
    partial class FrmReserve
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
            this.components = new System.ComponentModel.Container();
            this.grdReserves = new System.Windows.Forms.DataGridView();
            this.rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateReserveDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbBoatName = new System.Windows.Forms.ComboBox();
            this.cmbSailorName = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHiddenId = new System.Windows.Forms.TextBox();
            this.txtHiddenSId = new System.Windows.Forms.TextBox();
            this.txtHiddenBId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateSearchReserveDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.cmbSearchSailorName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdReserves)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReserves
            // 
            this.grdReserves.AllowUserToAddRows = false;
            this.grdReserves.AllowUserToDeleteRows = false;
            this.grdReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReserves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rid,
            this.sid,
            this.bid,
            this.sname,
            this.bname,
            this.date});
            this.grdReserves.Location = new System.Drawing.Point(24, 383);
            this.grdReserves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdReserves.Name = "grdReserves";
            this.grdReserves.ReadOnly = true;
            this.grdReserves.RowHeadersWidth = 62;
            this.grdReserves.Size = new System.Drawing.Size(1154, 226);
            this.grdReserves.TabIndex = 3;
            this.grdReserves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReserves_CellClick);
            // 
            // rid
            // 
            this.rid.HeaderText = "Id";
            this.rid.MinimumWidth = 8;
            this.rid.Name = "rid";
            this.rid.ReadOnly = true;
            this.rid.Visible = false;
            this.rid.Width = 150;
            // 
            // sid
            // 
            this.sid.HeaderText = "sid";
            this.sid.MinimumWidth = 8;
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            this.sid.Width = 150;
            // 
            // bid
            // 
            this.bid.HeaderText = "bid";
            this.bid.MinimumWidth = 8;
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            this.bid.Visible = false;
            this.bid.Width = 150;
            // 
            // sname
            // 
            this.sname.HeaderText = "Sailor Name";
            this.sname.MinimumWidth = 8;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 150;
            // 
            // bname
            // 
            this.bname.HeaderText = "Boat Name";
            this.bname.MinimumWidth = 8;
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            this.bname.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Reserve Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateReserveDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.cmbBoatName);
            this.groupBox1.Controls.Add(this.cmbSailorName);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1154, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register New Reservation";
            // 
            // dateReserveDate
            // 
            this.dateReserveDate.Location = new System.Drawing.Point(149, 124);
            this.dateReserveDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateReserveDate.Name = "dateReserveDate";
            this.dateReserveDate.Size = new System.Drawing.Size(454, 26);
            this.dateReserveDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.Enabled = false;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1000, 113);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 55);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbBoatName
            // 
            this.cmbBoatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoatName.FormattingEnabled = true;
            this.cmbBoatName.Location = new System.Drawing.Point(149, 86);
            this.cmbBoatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoatName.Name = "cmbBoatName";
            this.cmbBoatName.Size = new System.Drawing.Size(454, 28);
            this.cmbBoatName.TabIndex = 3;
            // 
            // cmbSailorName
            // 
            this.cmbSailorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSailorName.FormattingEnabled = true;
            this.cmbSailorName.Location = new System.Drawing.Point(149, 43);
            this.cmbSailorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSailorName.Name = "cmbSailorName";
            this.cmbSailorName.Size = new System.Drawing.Size(454, 28);
            this.cmbSailorName.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1000, 29);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 55);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boat Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sailor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "From Date";
            // 
            // txtHiddenId
            // 
            this.txtHiddenId.Location = new System.Drawing.Point(672, 182);
            this.txtHiddenId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHiddenId.Name = "txtHiddenId";
            this.txtHiddenId.Size = new System.Drawing.Size(82, 26);
            this.txtHiddenId.TabIndex = 5;
            this.txtHiddenId.Visible = false;
            // 
            // txtHiddenSId
            // 
            this.txtHiddenSId.Location = new System.Drawing.Point(579, 182);
            this.txtHiddenSId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHiddenSId.Name = "txtHiddenSId";
            this.txtHiddenSId.Size = new System.Drawing.Size(82, 26);
            this.txtHiddenSId.TabIndex = 5;
            this.txtHiddenSId.Visible = false;
            // 
            // txtHiddenBId
            // 
            this.txtHiddenBId.Location = new System.Drawing.Point(460, 182);
            this.txtHiddenBId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHiddenBId.Name = "txtHiddenBId";
            this.txtHiddenBId.Size = new System.Drawing.Size(108, 26);
            this.txtHiddenBId.TabIndex = 5;
            this.txtHiddenBId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateSearchReserveDate);
            this.groupBox2.Controls.Add(this.btnSearchByDate);
            this.groupBox2.Controls.Add(this.cmbSearchSailorName);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1154, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Reservation";
            // 
            // dateSearchReserveDate
            // 
            this.dateSearchReserveDate.Location = new System.Drawing.Point(145, 112);
            this.dateSearchReserveDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateSearchReserveDate.Name = "dateSearchReserveDate";
            this.dateSearchReserveDate.Size = new System.Drawing.Size(454, 26);
            this.dateSearchReserveDate.TabIndex = 7;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearchByDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.Location = new System.Drawing.Point(996, 87);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(112, 55);
            this.btnSearchByDate.TabIndex = 2;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // cmbSearchSailorName
            // 
            this.cmbSearchSailorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSailorName.FormattingEnabled = true;
            this.cmbSearchSailorName.Location = new System.Drawing.Point(145, 40);
            this.cmbSearchSailorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchSailorName.Name = "cmbSearchSailorName";
            this.cmbSearchSailorName.Size = new System.Drawing.Size(454, 28);
            this.cmbSearchSailorName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(996, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 55);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sailor Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1024, 623);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdReserves);
            this.Controls.Add(this.txtHiddenBId);
            this.Controls.Add(this.txtHiddenSId);
            this.Controls.Add(this.txtHiddenId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReserve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.FrmReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReserves)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReserves;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoatName;
        private System.Windows.Forms.ComboBox cmbSailorName;
        private System.Windows.Forms.ComboBox cmbSearchSailorName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtHiddenBId;
        private System.Windows.Forms.TextBox txtHiddenSId;
        private System.Windows.Forms.TextBox txtHiddenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DateTimePicker dateReserveDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateSearchReserveDate;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Label label5;
    }
}