namespace EmployeePayrollDemo
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSales = new System.Windows.Forms.TextBox();
            this.LblDarsadForosh = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdoDarsadi = new System.Windows.Forms.RadioButton();
            this.RdoRasmi = new System.Windows.Forms.RadioButton();
            this.RdoGarardadi = new System.Windows.Forms.RadioButton();
            this.TxtHireDate = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtSales);
            this.groupBox1.Controls.Add(this.LblDarsadForosh);
            this.groupBox1.Controls.Add(this.TxtSalary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TxtHireDate);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSales
            // 
            this.TxtSales.Location = new System.Drawing.Point(100, 198);
            this.TxtSales.Name = "TxtSales";
            this.TxtSales.Size = new System.Drawing.Size(100, 27);
            this.TxtSales.TabIndex = 8;
            this.TxtSales.Visible = false;
            // 
            // LblDarsadForosh
            // 
            this.LblDarsadForosh.AutoSize = true;
            this.LblDarsadForosh.Location = new System.Drawing.Point(38, 204);
            this.LblDarsadForosh.Name = "LblDarsadForosh";
            this.LblDarsadForosh.Size = new System.Drawing.Size(55, 21);
            this.LblDarsadForosh.TabIndex = 7;
            this.LblDarsadForosh.Text = "Sales:";
            this.LblDarsadForosh.Visible = false;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(439, 198);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 27);
            this.TxtSalary.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdoDarsadi);
            this.groupBox3.Controls.Add(this.RdoRasmi);
            this.groupBox3.Controls.Add(this.RdoGarardadi);
            this.groupBox3.Location = new System.Drawing.Point(80, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Type";
            // 
            // RdoDarsadi
            // 
            this.RdoDarsadi.AutoSize = true;
            this.RdoDarsadi.Location = new System.Drawing.Point(20, 30);
            this.RdoDarsadi.Name = "RdoDarsadi";
            this.RdoDarsadi.Size = new System.Drawing.Size(124, 25);
            this.RdoDarsadi.TabIndex = 2;
            this.RdoDarsadi.Text = "Commission";
            this.RdoDarsadi.UseVisualStyleBackColor = true;
            this.RdoDarsadi.CheckedChanged += new System.EventHandler(this.RdoDarsadi_CheckedChanged);
            // 
            // RdoRasmi
            // 
            this.RdoRasmi.AutoSize = true;
            this.RdoRasmi.Location = new System.Drawing.Point(187, 30);
            this.RdoRasmi.Name = "RdoRasmi";
            this.RdoRasmi.Size = new System.Drawing.Size(94, 25);
            this.RdoRasmi.TabIndex = 1;
            this.RdoRasmi.Text = "Salaried";
            this.RdoRasmi.UseVisualStyleBackColor = true;
            this.RdoRasmi.CheckedChanged += new System.EventHandler(this.RdoRasmi_CheckedChanged);
            // 
            // RdoGarardadi
            // 
            this.RdoGarardadi.AutoSize = true;
            this.RdoGarardadi.Checked = true;
            this.RdoGarardadi.Location = new System.Drawing.Point(339, 30);
            this.RdoGarardadi.Name = "RdoGarardadi";
            this.RdoGarardadi.Size = new System.Drawing.Size(98, 25);
            this.RdoGarardadi.TabIndex = 0;
            this.RdoGarardadi.TabStop = true;
            this.RdoGarardadi.Text = "Contract";
            this.RdoGarardadi.UseVisualStyleBackColor = true;
            this.RdoGarardadi.CheckedChanged += new System.EventHandler(this.RdoGarardadi_CheckedChanged);
            // 
            // TxtHireDate
            // 
            this.TxtHireDate.Location = new System.Drawing.Point(99, 57);
            this.TxtHireDate.Name = "TxtHireDate";
            this.TxtHireDate.Size = new System.Drawing.Size(100, 27);
            this.TxtHireDate.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(396, 54);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(143, 27);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hire Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 172);
            this.listBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Employee Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHireDate;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdoDarsadi;
        private System.Windows.Forms.RadioButton RdoRasmi;
        private System.Windows.Forms.RadioButton RdoGarardadi;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSales;
        private System.Windows.Forms.Label LblDarsadForosh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

