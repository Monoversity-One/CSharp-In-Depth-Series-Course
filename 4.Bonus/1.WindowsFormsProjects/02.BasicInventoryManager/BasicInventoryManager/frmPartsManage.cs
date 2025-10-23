#region

using System;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass;
using BasicInventoryManager.MyClass.Part;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmPartsManage : Form
    {
        #region Variable

        private readonly PartDataAccess _partDataAccess;
        private Part _part;
        private string _strLastPartId = string.Empty;

        #endregion

        public FrmPartsManage()
        {
            InitializeComponent();
            _partDataAccess = new PartDataAccess();
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            _part = new Part { Name = txtName.Text.Trim(), Price = txtPrice.Text.Trim(), Id = txtId.Text.Trim() };

            _partDataAccess.Part = _part;

            if (_partDataAccess.Insert())
            {
                Parts.AllParts.Add(_part);
                FrmPartsManageLoad(this, e);
                MessageBox.Show(@"Save operation completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
            }
        }
      
        private void FrmPartsManageLoad(object sender, EventArgs e)
        {
            dgv.DataSource = Parts.AllParts.ToList();
        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv != null)
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "btnDelete":
                        _part = new Part
                                    {
                                        Name = dgv["PartName", e.RowIndex].Value.ToString(),
                                        Id = dgv["PartId", e.RowIndex].Value.ToString(),
                                        Price = dgv["PartPrice", e.RowIndex].Value.ToString()
                                    };
                        _partDataAccess.Part = _part;
                        if (
                            MessageBox.Show(@"Are you sure?", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes)
                        {
                            if (_partDataAccess.Delete())
                            {
                                FrmPartsManageLoad(this, e);
                                MessageBox.Show(@"Delete operation completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "btnUpdate":
                        _strLastPartId = dgv["PartId", e.RowIndex].Value.ToString();
                        txtName.Text = dgv["PartName", e.RowIndex].Value.ToString();
                        txtId.Text = dgv["PartId", e.RowIndex].Value.ToString();
                        txtPrice.Text = dgv["PartPrice", e.RowIndex].Value.ToString();
                        SetControl();
                        break;
                }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Global.ClearValue(groupBox);
            SetControl();
        }

        private void SetControl()
        {
            dgv.Enabled = !dgv.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
            btnSellerUpdate.Enabled = !btnSellerUpdate.Enabled;
            btnSubmit.Enabled = !btnSubmit.Enabled;
        }

        private void BtnSellerUpdateClick(object sender, EventArgs e)
        {
            _part = new Part { Name = txtName.Text.Trim(), Id = txtId.Text.Trim(), Price = txtPrice.Text.Trim() };

            _partDataAccess.Part = _part;

            if (_partDataAccess.Update(_strLastPartId))
            {
                MessageBox.Show(@"Update completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
                SetControl();
                FrmPartsManageLoad(this, e);
            }
        }
    }
}