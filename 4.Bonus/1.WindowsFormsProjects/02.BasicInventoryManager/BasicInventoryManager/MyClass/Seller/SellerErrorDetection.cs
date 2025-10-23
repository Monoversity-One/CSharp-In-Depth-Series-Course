#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.PartSell;

#endregion

namespace BasicInventoryManager.MyClass.Seller
{
    public class SellerErrorDetection
    {
        public static bool SellerFileExist()
        {
            return (File.Exists(Application.StartupPath + "/Seller.txt"));
        }

        public static bool CodeCheck(string code)
        {
            return (Sellers.AllSellers.Exists(d => d.Code == code));
        }

        public static bool SellerCheck(Seller seller)
        {
            if (string.IsNullOrEmpty(seller.Name))
            {
                MessageBox.Show(@"Seller name is required", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (string.IsNullOrEmpty(seller.Code))
            {
                MessageBox.Show(@"Seller code is required",@"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (CodeCheck(seller.Code))
            {
                MessageBox.Show(@"This code has already been defined", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            return (true);
        }

        public static void GetSellers()
        {
            try
            {
                if (Sellers.AllSellers.Count > 0)
                {
                    Sellers.AllSellers.Clear();
                }
                using (var sellerFile = new StreamReader(Application.StartupPath + "/Seller.txt"))
                {
                    var readLine = sellerFile.ReadLine();
                    if (readLine != null)
                    {
                        var lstSellers = new List<string>(readLine.Split('@'));

                        foreach (var s in lstSellers.Where(p => p != string.Empty).Select(seller => new List<string>(seller.Split(';'))))
                        {
                            Sellers.AllSellers.Add
                                (
                                    new Seller
                                        {
                                            Name = s[0],
                                            Family = s[1],
                                            Code = s[2]
                                        }
                                )
                                ;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred while performing the save operation", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void SellerFileRefreshe()
        {
            using (var stream = new FileStream(Application.StartupPath + "/Seller.txt", FileMode.Create))
            {
                stream.Close();
            }

            if (!SellerFileExist())
            {
                MessageBox.Show(@"The file required for reorganization does not exist", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                using (var sellerFile = File.AppendText(Application.StartupPath + "/Seller.txt"))
                {
                    foreach (var seller in Sellers.AllSellers)
                    {
                        sellerFile.Write(seller.Name + ";" + seller.Family + ";" + seller.Code + "@");
                    }
                    sellerFile.Close();
                }
            }
        }

        public static bool CheckInPartSell(string sellerCode)
        {
            return (PartsSell.AllPartsSell.Exists(d => d.SellerCode == sellerCode));
        }

        public static void DeleteSellerInPartSell(string sellerCode)
        {
            PartsSell.AllPartsSell.RemoveAll(d => d.SellerCode == sellerCode);
            PartsSellErrorDetection.PartSellFileRefreshe();
        }

        public static void UpdateSellerInPartSell(string lastSellerCode, string newSellerCode)
        {
            foreach (PartSell.PartSell item in PartsSell.AllPartsSell.Where(d => d.SellerCode == lastSellerCode))
            {
                item.SellerCode = newSellerCode;
            }
            PartsSellErrorDetection.PartSellFileRefreshe();
        }
    }
}