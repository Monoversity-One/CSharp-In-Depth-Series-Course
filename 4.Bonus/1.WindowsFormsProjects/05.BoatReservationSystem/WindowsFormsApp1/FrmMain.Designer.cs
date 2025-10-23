namespace BoatReservationSystem
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
            this.btnBoats = new System.Windows.Forms.Button();
            this.btnReserves = new System.Windows.Forms.Button();
            this.btnSailors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoats
            // 
            this.btnBoats.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBoats.ForeColor = System.Drawing.Color.White;
            this.btnBoats.Location = new System.Drawing.Point(454, 345);
            this.btnBoats.Name = "btnBoats";
            this.btnBoats.Size = new System.Drawing.Size(122, 56);
            this.btnBoats.TabIndex = 0;
            this.btnBoats.Text = "Boats";
            this.btnBoats.UseVisualStyleBackColor = false;
            this.btnBoats.Click += new System.EventHandler(this.btnBoats_Click);
            // 
            // btnReserves
            // 
            this.btnReserves.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReserves.ForeColor = System.Drawing.Color.White;
            this.btnReserves.Location = new System.Drawing.Point(198, 345);
            this.btnReserves.Name = "btnReserves";
            this.btnReserves.Size = new System.Drawing.Size(122, 56);
            this.btnReserves.TabIndex = 0;
            this.btnReserves.Text = "Reservations";
            this.btnReserves.UseVisualStyleBackColor = false;
            this.btnReserves.Click += new System.EventHandler(this.btnReserves_Click);
            // 
            // btnSailors
            // 
            this.btnSailors.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSailors.ForeColor = System.Drawing.Color.White;
            this.btnSailors.Location = new System.Drawing.Point(326, 345);
            this.btnSailors.Name = "btnSailors";
            this.btnSailors.Size = new System.Drawing.Size(122, 56);
            this.btnSailors.TabIndex = 0;
            this.btnSailors.Text = "Sailors";
            this.btnSailors.UseVisualStyleBackColor = false;
            this.btnSailors.Click += new System.EventHandler(this.btnSailors_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(782, 413);
            this.Controls.Add(this.btnSailors);
            this.Controls.Add(this.btnReserves);
            this.Controls.Add(this.btnBoats);
            this.Name = "FrmMain";
            this.Text = "Boat and Sailor Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoats;
        private System.Windows.Forms.Button btnReserves;
        private System.Windows.Forms.Button btnSailors;
    }
}

