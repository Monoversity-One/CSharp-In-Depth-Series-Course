using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoatReservationSystem.DAL;
using BoatReservationSystem.Model;

namespace BoatReservationSystem
{
    public partial class FrmBoat : Form
    {



        public FrmBoat()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Enter name");
            }

            else if (string.IsNullOrEmpty(txtColor.Text))
            {
                errorProvider1.SetError(txtColor, "Enter color");
            }

            else
            {
                BoatTable table = new BoatTable();
                table.Create(txtName.Text, txtColor.Text);
                UpdateTable();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text) && string.IsNullOrWhiteSpace(txtSearchColor.Text))
            {
                UpdateTable();
                MessageBox.Show("Enter at least one of Name or Color");
            }

            else
            {
                grdBoats.Rows.Clear();

                BoatTable table = new BoatTable();
                List<Boat> boats = table.ReadLike(txtSearchName.Text, txtSearchColor.Text);


                foreach (var item in boats)
                {
                    int rowId = grdBoats.Rows.Add();


                    DataGridViewRow row = grdBoats.Rows[rowId];

                    row.Cells["bid"].Value = item.Id;
                    row.Cells["bname"].Value = item.BoatName;
                    row.Cells["color"].Value = item.BoatColor;
                }
            }
        }

        public void UpdateTable()
        {
            grdBoats.Rows.Clear();

            BoatTable table = new BoatTable();
            List<Boat> boats = table.ReadAll();


            foreach (var item in boats)
            {
                int rowId = grdBoats.Rows.Add();


                DataGridViewRow row = grdBoats.Rows[rowId];

                row.Cells["bid"].Value = item.Id;
                row.Cells["bname"].Value = item.BoatName;
                row.Cells["color"].Value = item.BoatColor;
            }
        }
        private void FrmBoat_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (grdBoats.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one row to delete.");
            }
            else
            {
                int id = int.Parse(txtHiddenId.Text);

                BoatTable table = new BoatTable();
                table.Delete(id);

                UpdateTable();
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHiddenId.Text))
            {
                MessageBox.Show("Select one row to edit.");
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Enter name");
            }
            else if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                errorProvider1.SetError(txtColor, "Enter color");
            }
            else
            {
                BoatTable table = new BoatTable();
                table.Update(int.Parse(txtHiddenId.Text), txtName.Text, txtColor.Text);

                UpdateTable();


                txtHiddenId.Clear();
                txtName.Clear();
                txtColor.Clear();
                grdBoats.ClearSelection();

                btnEdit.Enabled = false;
            }
        }

        private void grdBoats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHiddenId.Text = grdBoats[0, grdBoats.CurrentRow.Index].Value.ToString();
            txtName.Text = grdBoats[1, grdBoats.CurrentRow.Index].Value.ToString();
            txtColor.Text = grdBoats[2, grdBoats.CurrentRow.Index].Value.ToString();

            btnEdit.Enabled = true;
        }
    }
}
