#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.PartSell;

#endregion

namespace BasicInventoryManager.MyClass.Part
{
    public class PartErrorDetection
    {
        public static bool PartFileExist()
        {
            return (File.Exists(Application.StartupPath + "/Part.txt"));
        }

        public static bool PriceCheck(string price)
        {
            foreach (var item in price)
            {
                if (!char.IsNumber(item))
                {
                    return (false);
                }
            }
            return (true);
        }

        public static bool IdCheck(string partId)
        {
            return (Parts.AllParts.Exists(d => d.Id == partId));
        }

        public static bool PartCheck(Part part)
        {
            if (string.IsNullOrEmpty(part.Name))
            {
                MessageBox.Show(@"Part name is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (string.IsNullOrEmpty(part.Id))
            {
                MessageBox.Show(@"Part ID is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (!PriceCheck(part.Price))
            {
                MessageBox.Show(@"Part price is not valid", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (IdCheck(part.Id))
            {
                MessageBox.Show(@"This part ID has already been defined", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            return (true);
        }

        public static void GetParts()
        {
            try
            {
                if (Parts.AllParts.Count > 0)
                {
                    Parts.AllParts.Clear();
                }
                using (var partFile = new StreamReader(Application.StartupPath + "/Part.txt"))
                {
                    var readLine = partFile.ReadLine();
                    if (readLine == null) return;
                    var lstParts = new List<string>(readLine.Split('@'));

                    foreach (var p in lstParts.Where(p => p != string.Empty).Select(part => new List<string>(part.Split(';'))))
                    {
                        Parts.AllParts.Add
                            (
                                new Part
                                {
                                    Name = p[0],
                                    Id = p[1],
                                    Price = p[2]
                                }
                            )
                            ;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred while performing the save operation", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void PartFileRefreshe()
        {
            using (var stream = new FileStream(Application.StartupPath + "/Part.txt", FileMode.Create))
            {
                stream.Close();
            }

            if (!PartFileExist())
            {
                MessageBox.Show(@"The file for reorganization does not exist", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                using (var partFile = File.AppendText(Application.StartupPath + "/Part.txt"))
                {
                    foreach (var part in Parts.AllParts)
                    {
                        partFile.Write(part.Name + ";" + part.Id + ";" + part.Price + "@");
                    }
                    partFile.Close();
                }
            }
        }

        public static bool CheckInPartSell(string partId)
        {
            return (PartsSell.AllPartsSell.Exists(d => d.PartId == partId));
        }

        public static void DeletePartInPartSell(string partId)
        {
            PartsSell.AllPartsSell.RemoveAll(d => d.PartId == partId);
            PartsSellErrorDetection.PartSellFileRefreshe();
        }

        public static void UpdatePartInPartSell(string lastPartId, string newPartId)
        {
            foreach (var item in PartsSell.AllPartsSell.Where(d => d.PartId == lastPartId))
            {
                item.PartId = newPartId;
            }
            PartsSellErrorDetection.PartSellFileRefreshe();
        }
    }
}