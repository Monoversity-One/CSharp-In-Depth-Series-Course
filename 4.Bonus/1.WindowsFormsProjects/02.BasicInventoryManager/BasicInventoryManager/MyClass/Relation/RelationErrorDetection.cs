#region

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

#endregion

namespace BasicInventoryManager.MyClass.Relation
{
    public class RelationErrorDetection
    {
        public static bool RelationFileExist()
        {
            return (File.Exists(Application.StartupPath + "/Relation.txt"));
        }

        public static void NewFileForRelation()
        {
            using (var stream = new FileStream(Application.StartupPath + "/Relation.txt", FileMode.Create))
            {
                stream.Close();
            }
        }

        public static void LoadRelation()
        {
            using (var relationFile = new StreamReader(Application.StartupPath + "/Relation.txt"))
            {
                var readLine = relationFile.ReadLine();
                if (readLine == null) return;
                var lstRelations = new List<string>(readLine.Split('@'));

                var lstRelatPartToPartSell = new List<string>(lstRelations[0].Split(';'));
                Relations.RelatPartToPartSell = bool.Parse(lstRelatPartToPartSell[0]);
                Relations.RelatPartToPartSellDelete = bool.Parse(lstRelatPartToPartSell[1]);
                Relations.RelatPartToPartSellUpdate = bool.Parse(lstRelatPartToPartSell[2]);


                var lstRelatSellerToPartSell = new List<string>(lstRelations[1].Split(';'));
                Relations.RelatSellerToPartSell = bool.Parse(lstRelatSellerToPartSell[0]);
                Relations.RelatSellerToPartSellDelete = bool.Parse(lstRelatSellerToPartSell[1]);
                Relations.RelatSellerToPartSellUpdate = bool.Parse(lstRelatSellerToPartSell[2]);
            }
        }
    }
}