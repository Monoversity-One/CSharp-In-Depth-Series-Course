namespace _09.WindowsFormsDevelopment
{
    partial class EditEmployeeForm
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
            nudAge = new NumericUpDown();
            txtPosition = new TextBox();
            txtName = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // nudAge
            // 
            nudAge.Location = new Point(64, 219);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(300, 31);
            nudAge.TabIndex = 8;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(64, 157);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(300, 31);
            txtPosition.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 31);
            txtName.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 528);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 54);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 67);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 11;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 191);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 594);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(nudAge);
            Controls.Add(txtPosition);
            Controls.Add(txtName);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAge;
        private TextBox txtPosition;
        private TextBox txtName;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}