using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Design;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using BoatReservationSystem.DAL;
using BoatReservationSystem.Model;
using EnvDTE;

namespace BoatReservationSystem
{
    public partial class FrmReserve : Form
    {
        public FrmReserve()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbBoatName.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbBoatName, "Please select a boat");
            }
            else if (cmbSailorName.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbSailorName, "Please select a sailor");
            }
            else
            {
                ReserveTable table = new ReserveTable();


                dynamic bid = cmbBoatName.Items[cmbBoatName.SelectedIndex];
                dynamic sid = cmbSailorName.Items[cmbSailorName.SelectedIndex];

                table.Create(sid.Value, bid.Value,dateReserveDate.Value);

                UpdateTable();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHiddenId.Text))
            {
                MessageBox.Show("Please select a row from the table to edit.");
            }
            else
            {
                ReserveTable table = new ReserveTable();

                dynamic bid = cmbBoatName.Items[cmbBoatName.SelectedIndex];
                dynamic sid = cmbSailorName.Items[cmbSailorName.SelectedIndex];

                table.Update(int.Parse(txtHiddenId.Text),sid.Value,bid.Value, dateReserveDate.Value);

                UpdateTable();


                txtHiddenId.Clear();
                txtHiddenBId.Clear();
                txtHiddenSId.Clear();

                cmbSailorName.SelectedIndex = 0;
                cmbBoatName.SelectedIndex = 0;

                grdReserves.ClearSelection();

                btnEdit.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdReserves.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row from the table to delete.");
            }
            else
            {
                int id = int.Parse(txtHiddenId.Text);

                ReserveTable table = new ReserveTable();
                table.Delete(id);

                UpdateTable();
            }
        }

        private void grdReserves_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtHiddenId.Text = grdReserves[0, grdReserves.CurrentRow.Index].Value.ToString();

            txtHiddenSId.Text = grdReserves[1, grdReserves.CurrentRow.Index].Value.ToString();
            txtHiddenBId.Text = grdReserves[2, grdReserves.CurrentRow.Index].Value.ToString();

            dateReserveDate.Value = DateTime.Parse(grdReserves[5, grdReserves.CurrentRow.Index].Value.ToString());


            int selectedBoatIndex = 0;
            int countBoat = cmbBoatName.Items.Count;

            for (int i = 0; i <= (countBoat - 1); i++)
            {
                cmbBoatName.SelectedIndex = i;
                dynamic id = cmbBoatName.Items[cmbBoatName.SelectedIndex];
                if (id.Value == int.Parse(txtHiddenBId.Text))
                {
                    selectedBoatIndex = i;
                    break;
                }



            }
            cmbBoatName.SelectedIndex = selectedBoatIndex;




            int selectedSailorIndex = 0;
            int countSailor = cmbSailorName.Items.Count;

            for (int i = 0; i <= (countSailor - 1); i++)
            {
                cmbSailorName.SelectedIndex = i;
                dynamic id = cmbSailorName.Items[cmbSailorName.SelectedIndex];
                if (id.Value == int.Parse(txtHiddenSId.Text))
                {
                    selectedSailorIndex = i;
                    break;
                }



            }
            cmbSailorName.SelectedIndex = selectedSailorIndex;


            btnEdit.Enabled = true;
        }




        public void UpdateTable()
        {
            grdReserves.Rows.Clear();

            ReserveTable table = new ReserveTable();
            List<Reserve> reserves = table.ReadAll();


            foreach (var item in reserves)
            {
                int rowId = grdReserves.Rows.Add();


                DataGridViewRow row = grdReserves.Rows[rowId];

                row.Cells["rid"].Value = item.Id;
                row.Cells["sname"].Value = item.SailorName;
                row.Cells["bname"].Value = item.BoatName;
                row.Cells["sid"].Value = item.Sid;
                row.Cells["bid"].Value = item.Bid;
                row.Cells["date"].Value = item.ReserveDate;
            }
        }

        private void FrmReserve_Load(object sender, EventArgs e)
        {

            //Get All Sailors
            SailorTable sailorTable = new SailorTable();
            List<Sailor> sailors = sailorTable.ReadAll();
            cmbSailorName.DisplayMember = "Text";
            cmbSailorName.ValueMember = "Value";

            cmbSearchSailorName.DisplayMember = "Text";
            cmbSearchSailorName.ValueMember = "Value";

            foreach (var item in sailors)
            {
                cmbSailorName.Items.Add(new { Text = item.SailorName, Value = item.Id });

                cmbSearchSailorName.Items.Add(new { Text = item.SailorName, Value = item.Id });
            }


            //Get All Boats
            BoatTable boatTable = new BoatTable();
            List<Boat> boats = boatTable.ReadAll();
            cmbBoatName.DisplayMember = "Text";
            cmbBoatName.ValueMember = "Value";

            foreach (var item in boats)
            {
                cmbBoatName.Items.Add(new { Text = item.BoatName, Value = item.Id });
            }


            UpdateTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchSailorName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a sailor to search.");
            }
            else
            {
                grdReserves.Rows.Clear();

                dynamic sid;


                sid = cmbSearchSailorName.Items[cmbSearchSailorName.SelectedIndex];




                ReserveTable table = new ReserveTable();
                List<Reserve> reserves;

                reserves = table.ReadLike(sid.Text);

                foreach (var item in reserves)
                {
                    int rowId = grdReserves.Rows.Add();
                    DataGridViewRow row = grdReserves.Rows[rowId];

                    row.Cells["rid"].Value = item.Id;
                    row.Cells["bid"].Value = item.Bid;
                    row.Cells["sid"].Value = item.Sid;
                    row.Cells["bname"].Value = item.BoatName;
                    row.Cells["sname"].Value = item.SailorName;
                    row.Cells["date"].Value = item.ReserveDate;
                }
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            grdReserves.Rows.Clear();
            

            ReserveTable table = new ReserveTable();
            List<Reserve> reserves;

            reserves = table.ReadLike(dateSearchReserveDate.Value);

            foreach (var item in reserves)
            {
                int rowId = grdReserves.Rows.Add();
                DataGridViewRow row = grdReserves.Rows[rowId];

                row.Cells["rid"].Value = item.Id;
                row.Cells["bid"].Value = item.Bid;
                row.Cells["sid"].Value = item.Sid;
                row.Cells["bname"].Value = item.BoatName;
                row.Cells["sname"].Value = item.SailorName;
                row.Cells["date"].Value = item.ReserveDate;
            }
        }
    }
}
