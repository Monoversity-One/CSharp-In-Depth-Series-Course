using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoatReservationSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSailors_Click(object sender, EventArgs e)
        {
            FrmSailor frmSailor = new FrmSailor();
            frmSailor.ShowDialog();
        }

        private void btnReserves_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
        }

        private void btnBoats_Click(object sender, EventArgs e)
        {
            FrmBoat frmBoat = new FrmBoat();
            frmBoat.ShowDialog();
        }
    }
}
