#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Part;
using BasicInventoryManager.MyClass.Seller;

#endregion

namespace BasicInventoryManager.MyClass.PartSell
{
    public class PartsSellErrorDetection
    {
        public static bool PartsSellFileExist()
        {
            return (File.Exists(Application.StartupPath + "/PartSell.txt"));
        }

        public static bool CodeCheck(string partSellId)
        {
            return (PartsSell.AllPartsSell.Exists(d => d.PartSellId == partSellId));
        }

        public static bool PartSellCheck(PartSell partSell)
        {
            if (string.IsNullOrEmpty(partSell.PartSellId))
            {
                MessageBox.Show(@"Sale ID is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            if (string.IsNullOrEmpty(partSell.PartId))
            {
                MessageBox.Show(@"Part number is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            if (string.IsNullOrEmpty(partSell.SellerCode))
            {
                MessageBox.Show(@"Seller code is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            if (!Parts.AllParts.Exists(d => d.Id == partSell.PartId))
            {
                MessageBox.Show(@"Part number not found", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            if (!Sellers.AllSellers.Exists(d => d.Code == partSell.SellerCode))
            {
                MessageBox.Show(@"Seller code not found", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            if (PartsSell.AllPartsSell.Exists(d => d.PartSellId == partSell.PartSellId))
            {
                MessageBox.Show(@"Sale ID already exists", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return (false);
            }

            return (true);
        }

        public static void GetParts()
        {
            try
            {
                if (PartsSell.AllPartsSell.Count > 0)
                {
                    PartsSell.AllPartsSell.Clear();
                }
                using (var partFile = new StreamReader(Application.StartupPath + "/PartSell.txt"))
                {
                    var readLine = partFile.ReadLine();
                    if (readLine != null)
                    {
                        var lstPartsSell = new List<string>(readLine.Split('@'));

                        foreach (var p in lstPartsSell.Where(d => d != string.Empty).Select(partSell => new List<string>(partSell.Split(';'))))
                        {
                            PartsSell.AllPartsSell.Add
                                (
                                    new PartSell
                                        {
                                            PartSellId = p[0],
                                            SellerCode = p[1],
                                            PartId = p[2]
                                        }
                                )
                                ;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred while saving", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
        }

        public static void PartSellFileRefreshe()
        {
            using (var stream = new FileStream(Application.StartupPath + "/PartSell.txt", FileMode.Create))
            {
                stream.Close();
            }

            if (!PartErrorDetection.PartFileExist())
            {
                MessageBox.Show(@"The file required for reorganization does not exist", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            else
            {
                using (StreamWriter partSellFile = File.AppendText(Application.StartupPath + "/PartSell.txt"))
                {
                    foreach (var partSell in PartsSell.AllPartsSell)
                    {
                        partSellFile.Write(partSell.PartSellId + ";" + partSell.SellerCode + ";" + partSell.PartId + "@");
                    }
                    partSellFile.Close();
                }
            }
        }
    }
}