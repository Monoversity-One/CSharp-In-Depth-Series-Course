#region

using System;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Relation;

#endregion

namespace BasicInventoryManager
{
    public partial class FrmRelations : Form
    {
        public FrmRelations()
        {
            InitializeComponent();

            chkRelatPartAndPartSellNoYes.Checked = Relations.RelatPartToPartSell;
            chkSettingPPSDelete.Checked = Relations.RelatPartToPartSellDelete;
            chkSettingPPSEdit.Checked = Relations.RelatPartToPartSellUpdate;


            chkRelatSellerAndPartSellYesNo.Checked = Relations.RelatSellerToPartSell;
            chkSettingSPSDelete.Checked = Relations.RelatSellerToPartSellDelete;
            chkSettingSPSEdit.Checked = Relations.RelatSellerToPartSellUpdate;


            ChkRelatPartAndPartSellNoYesCheckedChanged(null, null);
            ChkRelatSellerAndPartSellYesNoCheckedChanged(null, null);
        }

        private void ChkRelatPartAndPartSellNoYesCheckedChanged(object sender, EventArgs e)
        {
            if (chkRelatPartAndPartSellNoYes.Checked)
            {
                grpPPSSetting.Enabled = true;
            }
            else
            {
                grpPPSSetting.Enabled = false;
                chkSettingPPSDelete.Checked = false;
                chkSettingPPSEdit.Checked = false;
            }
        }

        private void ChkRelatSellerAndPartSellYesNoCheckedChanged(object sender, EventArgs e)
        {
            if (chkRelatSellerAndPartSellYesNo.Checked)
            {
                grpSPSSetting.Enabled = true;
            }
            else
            {
                grpSPSSetting.Enabled = false;
                chkSettingSPSDelete.Checked = false;
                chkSettingSPSEdit.Checked = false;
            }
        }
        private void SetPart()
        {
            cmbFieldsName.Items.Clear();
            cmbFieldsName.Items.Add("PartId");
            cmbFieldsName.Items.Add("PartName");
            cmbFieldsName.Items.Add("Price");
        }

        private void SetSeller()
        {
            cmbFieldsName.Items.Clear();
            cmbFieldsName.Items.Add("Name");
            cmbFieldsName.Items.Add("Family");
            cmbFieldsName.Items.Add("SellerCode");
        }

        private void SetPartSell()
        {
            cmbFieldsName.Items.Clear();
            cmbFieldsName.Items.Add("PartId");
            cmbFieldsName.Items.Add("SellerCode");
            cmbFieldsName.Items.Add("PartSellId");
        }

        private void CmbTablesNameSelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbTablesName.SelectedIndex)
            {
                case 0:
                    SetPart();
                    break;
                case 1:
                    SetSeller();
                    break;
                case 2:
                    SetPartSell();
                    break;
            }
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            Relations.RelatPartToPartSell = chkRelatPartAndPartSellNoYes.Checked;
            Relations.RelatPartToPartSellDelete = chkSettingPPSDelete.Checked;
            Relations.RelatPartToPartSellUpdate = chkSettingPPSEdit.Checked;


            Relations.RelatSellerToPartSell = chkRelatSellerAndPartSellYesNo.Checked;
            Relations.RelatSellerToPartSellDelete = chkSettingSPSDelete.Checked;
            Relations.RelatSellerToPartSellUpdate = chkSettingSPSEdit.Checked;

            var relationDataAccess = new RelationDataAccess();
            relationDataAccess.RefresheRelations();

            MessageBox.Show(@"Relationship refresh completed", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}