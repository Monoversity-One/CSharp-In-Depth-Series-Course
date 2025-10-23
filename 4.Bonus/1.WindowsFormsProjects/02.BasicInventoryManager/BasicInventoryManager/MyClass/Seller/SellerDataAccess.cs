#region

using System;
using System.IO;
using System.Windows.Forms;
using BasicInventoryManager.MyClass.Relation;

#endregion

namespace BasicInventoryManager.MyClass.Seller
{
    public class SellerDataAccess
    {
        public Seller Seller { get; set; }

        public bool Insert()
        {
            if (SellerErrorDetection.SellerCheck(Seller))
            {
                SellerInsert();
                return (true);
            }
            return (false);
        }


        public bool Delete()
        {
            if (!SellerErrorDetection.CodeCheck(Seller.Code))
            {
                MessageBox.Show(@"This seller code does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (Relations.RelatSellerToPartSell)
            {
                if (SellerErrorDetection.CheckInPartSell(Seller.Code) && Relations.RelatSellerToPartSellDelete)
                {
                    SellerErrorDetection.DeleteSellerInPartSell(Seller.Code);
                }
                else if (SellerErrorDetection.CheckInPartSell(Seller.Code) && !Relations.RelatSellerToPartSellDelete)
                {
                    MessageBox.Show(@"This seller cannot be deleted because it is related to the sales table", @"Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }

            Sellers.AllSellers.RemoveAll(d => d.Code == Seller.Code);

            SellerErrorDetection.SellerFileRefreshe();

            return (true);
        }

        public bool Update(string sellerLastCode)
        {
            if (!SellerErrorDetection.CodeCheck(sellerLastCode))
            {
                MessageBox.Show(@"This seller code does not exist", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            if (SellerErrorDetection.CodeCheck(Seller.Code) && sellerLastCode != Seller.Code)
            {
                MessageBox.Show(@"This seller code already exists", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            if (Relations.RelatSellerToPartSell)
            {
                if (SellerErrorDetection.CheckInPartSell(sellerLastCode) && Relations.RelatSellerToPartSellUpdate)
                {
                    SellerErrorDetection.UpdateSellerInPartSell(sellerLastCode, Seller.Code);
                }
                else if (SellerErrorDetection.CheckInPartSell(sellerLastCode) &&
                         !Relations.RelatSellerToPartSellUpdate)
                {
                    MessageBox.Show(@"This seller cannot be edited because it is related to the sales table", @"Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }

            Sellers.AllSellers.Find(d => d.Code == sellerLastCode).Name = Seller.Name;
            Sellers.AllSellers.Find(d => d.Code == sellerLastCode).Family = Seller.Family;
            Sellers.AllSellers.Find(d => d.Code == sellerLastCode).Code = Seller.Code;

            SellerErrorDetection.SellerFileRefreshe();

            return (true);
        }


        private void SellerInsert()
        {
            try
            {
                if (!SellerErrorDetection.SellerFileExist())
                {
                    MessageBox.Show(@"The file for saving does not exist", @"Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    using (var sellerFile = File.AppendText(Application.StartupPath + "/Seller.txt"))
                    {
                        sellerFile.Write(Seller.Name + ";" + Seller.Family + ";" + Seller.Code + "@");
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