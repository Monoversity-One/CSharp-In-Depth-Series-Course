#region

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass;
using BasicInventoryManager.MyClass.PartSell;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmPartSellManage : Form
    {
        #region Variable

        private readonly Button _btnSelectPart = new Button();
        private readonly Button _btnSelectSeller = new Button();
        private readonly PartsSellDataAccess _partsSellDataAccess;
        private PartSell _partSell;
        private string _strPartSellid = string.Empty;

        #endregion

        public FrmPartSellManage()
        {
            InitializeComponent();
            _partsSellDataAccess = new PartsSellDataAccess();
            _btnSelectSeller.Name = "btnSelectSeller";
            _btnSelectSeller.Text = string.Empty;
            _btnSelectSeller.Height = 29;
            _btnSelectSeller.Width = 28;
            _btnSelectSeller.MouseEnter += BtnSelectSellerMouseEnter;
            _btnSelectSeller.MouseLeave += BtnSelectSellerMouseLeave;
            _btnSelectSeller.Click += BtnSelectSellerClick;
            _btnSelectSeller.Image = Image.FromFile(Application.StartupPath + "/Image/Select.png");
            txtSellerId.Controls.Add(_btnSelectSeller);

            _btnSelectPart.Name = "btnSelectPart";
            _btnSelectPart.Text = string.Empty;
            _btnSelectPart.Height = 29;
            _btnSelectPart.Width = 28;
            _btnSelectPart.MouseEnter += BtnSelectPartMouseEnter;
            _btnSelectPart.MouseLeave += BtnSelectPartMouseLeave;
            _btnSelectPart.Click += BtnSelectPartClick;
            _btnSelectPart.Image = Image.FromFile(Application.StartupPath + "/Image/Select.png");
            txtPartId.Controls.Add(_btnSelectPart);
        }

        private void FrmPartSellLoad(object sender, EventArgs e)
        {
            dgv.DataSource = PartsSell.AllPartsSell.ToList();
        }

        private void BtnSelectPartClick(object sender, EventArgs e)
        {
            var frmSelect = new FrmSelect(BasicInventoryManager.FrmSelect.SelectType.Part);
            frmSelect.ShowDialog();

            if (!string.IsNullOrEmpty(frmSelect.StrCode))
            {
                txtPartId.Text = frmSelect.StrCode;
            }
        }

        private void BtnSelectSellerClick(object sender, EventArgs e)
        {
            var frmSelect = new FrmSelect(BasicInventoryManager.FrmSelect.SelectType.Seller);
            frmSelect.ShowDialog();

            if (!string.IsNullOrEmpty(frmSelect.StrCode))
            {
                txtSellerId.Text = frmSelect.StrCode;
            }
        }

        private void BtnSelectPartMouseEnter(object sender, EventArgs e)
        {
            _btnSelectPart.Cursor = Cursors.Hand;
        }

        private void BtnSelectPartMouseLeave(object sender, EventArgs e)
        {
            _btnSelectPart.Cursor = Cursors.Default;
        }

        private void BtnSelectSellerMouseLeave(object sender, EventArgs e)
        {
            _btnSelectSeller.Cursor = Cursors.Default;
        }

        private void BtnSelectSellerMouseEnter(object sender, EventArgs e)
        {
            _btnSelectSeller.Cursor = Cursors.Hand;
        }

        private void BtnSellerUpdateClick(object sender, EventArgs e)
        {
            _partSell = new PartSell
                            {
                                PartId = txtPartId.Text.Trim(),
                                PartSellId = txtPartSellId.Text.Trim(),
                                SellerCode = txtSellerId.Text.Trim()
                            };

            _partsSellDataAccess.PartSell = _partSell;

            if (_partsSellDataAccess.Update(_strPartSellid))
            {
                MessageBox.Show("Update completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
                SetControl();
                FrmPartSellLoad(this, e);
            }
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            _partSell = new PartSell
                            {
                                PartSellId = txtPartSellId.Text.Trim(),
                                SellerCode = txtSellerId.Text.Trim(),
                                PartId = txtPartId.Text.Trim()
                            };

            _partsSellDataAccess.PartSell = _partSell;

            if (_partsSellDataAccess.Insert())
            {
                PartsSell.AllPartsSell.Add(_partSell);
                FrmPartSellLoad(this, e);
                MessageBox.Show("Save operation completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.ClearValue(groupBox);
            }
        }

        private void SetControl()
        {
            dgv.Enabled = !dgv.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
            btnSellerUpdate.Enabled = !btnSellerUpdate.Enabled;
            btnSubmit.Enabled = !btnSubmit.Enabled;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Global.ClearValue(groupBox);
            SetControl();
        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv != null)
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "btnDelete":
                        _partSell = new PartSell
                                        {
                                            PartId = dgv["PartId", e.RowIndex].Value.ToString(),
                                            PartSellId = dgv["PartSellId", e.RowIndex].Value.ToString(),
                                            SellerCode = dgv["SellerCode", e.RowIndex].Value.ToString()
                                        };
                        _partsSellDataAccess.PartSell = _partSell;
                        if (
                            MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) ==
                            DialogResult.Yes)
                        {
                            if (_partsSellDataAccess.Delete())
                            {
                                FrmPartSellLoad(this, e);
                                MessageBox.Show("Delete operation completed", "Information", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "btnUpdate":
                        _strPartSellid = dgv["PartSellId", e.RowIndex].Value.ToString();
                        txtPartId.Text = dgv["PartId", e.RowIndex].Value.ToString();
                        txtPartSellId.Text = dgv["PartSellId", e.RowIndex].Value.ToString();
                        txtSellerId.Text = dgv["SellerCode", e.RowIndex].Value.ToString();
                        SetControl();
                        break;
                    case "btnInfo":
                        {
                            var frmPartSellInfo = new FrmPartSellInfo(
                                dgv["PartSellId", e.RowIndex].Value.ToString(),
                                dgv["PartId", e.RowIndex].Value.ToString(),
                                dgv["SellerCode", e.RowIndex].Value.ToString());
                            frmPartSellInfo.ShowDialog();
                        }
                        break;
                }
        }
    }
}