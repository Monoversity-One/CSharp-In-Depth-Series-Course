#region

using System;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Part;
using BasicInventoryManager.MyClass.Seller;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmSelect : Form
    {
        #region SelectType enum

        public enum SelectType
        {
            Part,
            Seller
        }

        #endregion

        /// <summary>
        ///   To specify the type of selection
        /// </summary>
        /// <param name = "selectType">Used to select the desired record from the target file</param>
        public FrmSelect(SelectType selectType)
        {
            InitializeComponent();

            if (selectType == SelectType.Part)
            {
                dgvPart.Visible = true;
                dgvPart.DataSource = Parts.AllParts.ToList();
            }
            else
            {
                dgvSeller.Visible = true;
                dgvSeller.DataSource = Sellers.AllSellers.ToList();
            }
        }

        public string StrCode { get; set; }

        private void DgvPartCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPart == null || dgvPart.Columns[e.ColumnIndex].Name != "btnPartSelecting") return;
            StrCode = dgvPart["PartId", e.RowIndex].Value.ToString();
            Close();
        }

        private void DgvSellerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeller.Columns[e.ColumnIndex].Name == "btnSellerSelecting")
            {
                StrCode = dgvSeller["SellerCode", e.RowIndex].Value.ToString();
                Close();
            }
        }
    }
}