#region

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace BasicInventoryManager.MyClass.PartSell
{
    public class PartsSellDataAccess
    {
        public PartSell PartSell { get; set; }

        public bool Insert()
        {
            if (PartsSellErrorDetection.PartSellCheck(PartSell))
            {
                PartSellInsert();

                return (true);
            }
            return (false);
        }

        private void PartSellInsert()
        {
            try
            {
                if (!PartsSellErrorDetection.PartsSellFileExist())
                {
                    MessageBox.Show(@"The file for saving does not exist", @"Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    using (var partSellFile = File.AppendText(Application.StartupPath + "/PartSell.txt"))
                    {
                        partSellFile.Write(PartSell.PartSellId + ";" + PartSell.SellerCode + ";" + PartSell.PartId + "@");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred while performing the save operation", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public bool Delete()
        {
            if (!PartsSellErrorDetection.CodeCheck(PartSell.PartSellId))
            {
                MessageBox.Show(@"This sale ID does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            PartsSell.AllPartsSell.RemoveAll(d => d.PartSellId == PartSell.PartSellId);

            PartsSellErrorDetection.PartSellFileRefreshe();

            return (true);
        }

        public bool Update(string partSellId)
        {
            if (!PartsSellErrorDetection.CodeCheck(partSellId))
            {
                MessageBox.Show(@"Sale ID does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            if (PartsSellErrorDetection.CodeCheck(PartSell.PartSellId) && partSellId != PartSell.PartSellId)
            {
                MessageBox.Show(@"This sale ID already exists", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            PartsSell.AllPartsSell.Find(d => d.PartSellId == partSellId).PartId = PartSell.PartId;
            PartsSell.AllPartsSell.Find(d => d.PartSellId == partSellId).SellerCode = PartSell.SellerCode;
            PartsSell.AllPartsSell.Find(d => d.PartSellId == partSellId).PartSellId = PartSell.PartSellId;

            PartsSellErrorDetection.PartSellFileRefreshe();

            return (true);
        }
    }
}