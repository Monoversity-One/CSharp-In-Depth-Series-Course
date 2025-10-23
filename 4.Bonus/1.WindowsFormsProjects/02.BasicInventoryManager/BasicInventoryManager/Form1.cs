#region

using System;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Part;
using BasicInventoryManager.MyClass.PartSell;
using BasicInventoryManager.MyClass.Relation;
using BasicInventoryManager.MyClass.Seller;

#endregion

namespace BasicInventoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPartsManageClick(object sender, EventArgs e)
        {
            var frmPartsManage = new FrmPartsManage();
            frmPartsManage.ShowDialog();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            PartErrorDetection.GetParts();
            SellerErrorDetection.GetSellers();
            PartsSellErrorDetection.GetParts();
            RelationErrorDetection.LoadRelation();
        }

        private void BtnSellerManageClick(object sender, EventArgs e)
        {
            var frmSellersManage = new FrmSellersManage();
            frmSellersManage.ShowDialog();
        }

        private void BtnSaleManageClick(object sender, EventArgs e)
        {
            var frmPartSellManage = new FrmPartSellManage();
            frmPartSellManage.ShowDialog();
        }

        private void BtnRelatClick(object sender, EventArgs e)
        {
            var frmRelations = new FrmRelations();
            frmRelations.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://WWw.SourceCodes.ir");
        }
    }
}