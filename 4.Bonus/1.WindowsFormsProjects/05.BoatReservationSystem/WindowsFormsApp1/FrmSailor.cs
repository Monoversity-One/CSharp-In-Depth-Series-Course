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
    public partial class FrmSailor : Form
    {
        public FrmSailor()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            grdSailors.Rows.Clear();

            SailorTable table = new SailorTable();
            List<Sailor> sailors = table.ReadAll();


            foreach (var item in sailors)
            {
                int rowId = grdSailors.Rows.Add();


                DataGridViewRow row = grdSailors.Rows[rowId];

                row.Cells["sid"].Value = item.Id;
                row.Cells["sname"].Value = item.SailorName;
                row.Cells["srate"].Value = item.SailorRate;
                row.Cells["sage"].Value = DateTime.Today.Year - item.SailorBirthDate.Year;
                row.Cells["sdate"].Value = item.SailorBirthDate;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Please enter a name");
            }
            else
            {
                SailorTable table = new SailorTable();
                table.Create(txtName.Text, (int)numRate.Value, dateBirthDate.Value);
                UpdateTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                errorProvider1.SetError(txtSearchName, "Please enter a name");
                UpdateTable();
            }
            else
            {
                grdSailors.Rows.Clear();

                SailorTable table = new SailorTable();
                List<Sailor> sailors = table.ReadLike(txtSearchName.Text, (int)numSearchRate.Value,
                    dateSearchBirthDate.Value);


                foreach (var item in sailors)
                {
                    int rowId = grdSailors.Rows.Add();


                    DataGridViewRow row = grdSailors.Rows[rowId];

                    row.Cells["sid"].Value = item.Id;
                    row.Cells["sname"].Value = item.SailorName;
                    row.Cells["srate"].Value = item.SailorRate;
                    row.Cells["sage"].Value = DateTime.Today.Year - item.SailorBirthDate.Year;
                    row.Cells["sdate"].Value = item.SailorBirthDate;
                }
            }
        }

        private void FrmSailor_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHiddenId.Text))
            {
                MessageBox.Show("Please select a row from the table to edit.");
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Please enter a name");
            }
            else
            {
                SailorTable table = new SailorTable();
                table.Update(int.Parse(txtHiddenId.Text), txtName.Text, (int)numRate.Value, dateBirthDate.Value);

                UpdateTable();


                txtHiddenId.Clear();
                txtName.Clear();
                numRate.Value = 0;
                dateBirthDate.Value = DateTime.Now;

                grdSailors.ClearSelection();

                btnEdit.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdSailors.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row from the table to delete.");
            }
            else
            {

                int id = int.Parse(txtHiddenId.Text);

                SailorTable table = new SailorTable();
                table.Delete(id);

                UpdateTable();
            }
        }

        private void grdSailors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHiddenId.Text = grdSailors[0, grdSailors.CurrentRow.Index].Value.ToString();
            txtName.Text = grdSailors[1, grdSailors.CurrentRow.Index].Value.ToString();
            numRate.Value =decimal.Parse(grdSailors[2, grdSailors.CurrentRow.Index].Value.ToString());
            dateBirthDate.Value = DateTime.Parse(grdSailors[4, grdSailors.CurrentRow.Index].Value.ToString());

            btnEdit.Enabled = true;
        }

      
    }
}
