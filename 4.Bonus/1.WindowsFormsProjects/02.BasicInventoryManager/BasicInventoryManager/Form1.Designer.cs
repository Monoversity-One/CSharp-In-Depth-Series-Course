namespace BasicInventoryManager
{
    partial class Form1
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
            this.btnPartsManage = new System.Windows.Forms.Button();
            this.btnSellerManage = new System.Windows.Forms.Button();
            this.btnSaleManage = new System.Windows.Forms.Button();
            this.btnRelat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPartsManage
            // 
            this.btnPartsManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPartsManage.Location = new System.Drawing.Point(344, 40);
            this.btnPartsManage.Name = "btnPartsManage";
            this.btnPartsManage.Size = new System.Drawing.Size(130, 38);
            this.btnPartsManage.TabIndex = 0;
            this.btnPartsManage.Text = "Manage Parts";
            this.btnPartsManage.UseVisualStyleBackColor = true;
            this.btnPartsManage.Click += new System.EventHandler(this.BtnPartsManageClick);
            // 
            // btnSellerManage
            // 
            this.btnSellerManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSellerManage.Location = new System.Drawing.Point(197, 40);
            this.btnSellerManage.Name = "btnSellerManage";
            this.btnSellerManage.Size = new System.Drawing.Size(141, 38);
            this.btnSellerManage.TabIndex = 1;
            this.btnSellerManage.Text = "Manage Sellers";
            this.btnSellerManage.UseVisualStyleBackColor = true;
            this.btnSellerManage.Click += new System.EventHandler(this.BtnSellerManageClick);
            // 
            // btnSaleManage
            // 
            this.btnSaleManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaleManage.Location = new System.Drawing.Point(50, 40);
            this.btnSaleManage.Name = "btnSaleManage";
            this.btnSaleManage.Size = new System.Drawing.Size(141, 38);
            this.btnSaleManage.TabIndex = 2;
            this.btnSaleManage.Text = "Manage Sales";
            this.btnSaleManage.UseVisualStyleBackColor = true;
            this.btnSaleManage.Click += new System.EventHandler(this.BtnSaleManageClick);
            // 
            // btnRelat
            // 
            this.btnRelat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRelat.Location = new System.Drawing.Point(187, 98);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(162, 38);
            this.btnRelat.TabIndex = 3;
            this.btnRelat.Text = "Relations Settings";
            this.btnRelat.UseVisualStyleBackColor = true;
            this.btnRelat.Click += new System.EventHandler(this.BtnRelatClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(531, 163);
            this.Controls.Add(this.btnRelat);
            this.Controls.Add(this.btnSaleManage);
            this.Controls.Add(this.btnSellerManage);
            this.Controls.Add(this.btnPartsManage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPartsManage;
        private System.Windows.Forms.Button btnSellerManage;
        private System.Windows.Forms.Button btnSaleManage;
        private System.Windows.Forms.Button btnRelat;
    }
}

