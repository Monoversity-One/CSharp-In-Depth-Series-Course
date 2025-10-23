#region

using System;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass;
using BasicInventoryManager.MyClass.Seller;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmSellersManage : Form
    {
        #region Variable

        private readonly SellerDataAccess _sellerDataAccess;
        private Seller _seller;
        private string _strSellerLastCode = string.Empty;

        #endregion

        public FrmSellersManage()
        {
            InitializeComponent();

            _sellerDataAccess = new SellerDataAccess();
        }

        private void FrmSellersManageLoad(object sender, EventArgs e)
        {
            dgv.DataSource = Sellers.AllSellers.ToList();
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            _seller = new Seller
                          {Name = txtName.Text.Trim(), Family = txtFamily.Text.Trim(), Code = txtCode.Text.Trim()};

            _sellerDataAccess.Seller = _seller;

            if (_sellerDataAccess.Insert())
            {
                Sellers.AllSellers.Add(_seller);
                FrmSellersManageLoad(this, e);
                MessageBox.Show(@"Save operation completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
            }
        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv != null)
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "btnDelete":
                        _seller = new Seller
                                      {
                                          Name = dgv["SellerName", e.RowIndex].Value.ToString(),
                                          Family = dgv["Family", e.RowIndex].Value.ToString(),
                                          Code = dgv["Code", e.RowIndex].Value.ToString()
                                      };
                        _sellerDataAccess.Seller = _seller;
                        if (
                            MessageBox.Show(@"Are you sure?", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes)
                        {
                            if (_sellerDataAccess.Delete())
                            {
                                FrmSellersManageLoad(this, e);
                                MessageBox.Show(@"Delete operation completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "btnUpdate":
                        _strSellerLastCode = dgv["Code", e.RowIndex].Value.ToString();
                        txtName.Text = dgv["SellerName", e.RowIndex].Value.ToString();
                        txtFamily.Text = dgv["Family", e.RowIndex].Value.ToString();
                        txtCode.Text = dgv["Code", e.RowIndex].Value.ToString();
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
            _seller = new Seller
                          {Name = txtName.Text.Trim(), Family = txtFamily.Text.Trim(), Code = txtCode.Text.Trim()};

            _sellerDataAccess.Seller = _seller;

            if (_sellerDataAccess.Update(_strSellerLastCode))
            {
                MessageBox.Show(@"Update completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
                SetControl();
                FrmSellersManageLoad(this, e);
            }
        }
    }
}