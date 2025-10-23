#region

using System;
using System.IO;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Relation;

#endregion

namespace BasicInventoryManager.MyClass.Part
{
    public class PartDataAccess
    {
        public Part Part { get; set; }

        public bool Insert()
        {
            if (PartErrorDetection.PartCheck(Part))
            {
                PartInsert();

                return (true);
            }
            return (false);
        }

        public bool Update(string partId)
        {
            if (!PartErrorDetection.IdCheck(partId))
            {
                MessageBox.Show(@"This part ID does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            if (PartErrorDetection.IdCheck(Part.Id) && partId != Part.Id)
            {
                MessageBox.Show(@"This part ID already exists", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            if (Relations.RelatPartToPartSell)
            {
                if (PartErrorDetection.CheckInPartSell(partId) && Relations.RelatPartToPartSellUpdate)
                {
                    PartErrorDetection.UpdatePartInPartSell(partId, Part.Id);
                }
                else if (PartErrorDetection.CheckInPartSell(partId) && !Relations.RelatPartToPartSellUpdate)
                {
                    MessageBox.Show(@"This part cannot be edited because it is related to the sales table", @"Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }

            Parts.AllParts.Find(d => d.Id == partId).Name = Part.Name;
            Parts.AllParts.Find(d => d.Id == partId).Price = Part.Price;
            Parts.AllParts.Find(d => d.Id == partId).Id = Part.Id;

            PartErrorDetection.PartFileRefreshe();

            return (true);
        }

        public bool Delete()
        {
            if (!PartErrorDetection.IdCheck(Part.Id))
            {
                MessageBox.Show(@"This part ID does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (Relations.RelatPartToPartSell)
            {
                if (PartErrorDetection.CheckInPartSell(Part.Id) && Relations.RelatPartToPartSellDelete)
                {
                    PartErrorDetection.DeletePartInPartSell(Part.Id);
                }
                else if (PartErrorDetection.CheckInPartSell(Part.Id) && !Relations.RelatPartToPartSellDelete)
                {
                    MessageBox.Show(@"This part cannot be deleted because it is related to the sales table", @"Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }

            Parts.AllParts.RemoveAll(d => d.Id == Part.Id);

            PartErrorDetection.PartFileRefreshe();

            return (true);
        }

        private void PartInsert()
        {
            try
            {
                if (!PartErrorDetection.PartFileExist())
                {
                    MessageBox.Show(@"The file for saving does not exist", @"Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    using (var partFile = File.AppendText(Application.StartupPath + "/Part.txt"))
                    {
                        partFile.Write(Part.Name + ";" + Part.Id + ";" + Part.Price + "@");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred while performing the save operation", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}