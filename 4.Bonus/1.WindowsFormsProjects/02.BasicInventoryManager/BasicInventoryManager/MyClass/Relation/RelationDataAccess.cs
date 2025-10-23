#region

using System.IO;
using System.Windows.Forms;

#endregion

namespace BasicInventoryManager.MyClass.Relation
{
    public class RelationDataAccess
    {
        public void RefresheRelations()
        {
            if (!RelationErrorDetection.RelationFileExist())
            {
                MessageBox.Show(@"The file required for reorganization does not exist", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                RelationErrorDetection.NewFileForRelation();

                SaveFile();
            }
        }

        private void SaveFile()
        {
            using (StreamWriter relationFile = File.AppendText(Application.StartupPath + "/Relation.txt"))
            {
                relationFile.Write(Relations.RelatPartToPartSell
                                   + ";" + Relations.RelatPartToPartSellDelete
                                   + ";" + Relations.RelatPartToPartSellUpdate + "@" +
                                   Relations.RelatSellerToPartSell
                                   + ";" + Relations.RelatSellerToPartSellDelete
                                   + ";" + Relations.RelatSellerToPartSellUpdate);
            }
        }
    }
}