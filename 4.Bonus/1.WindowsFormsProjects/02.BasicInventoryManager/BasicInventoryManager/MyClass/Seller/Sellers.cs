#region

using System.Collections.Generic;

#endregion

namespace BasicInventoryManager.MyClass.Seller
{
    public class Sellers
    {
        public static List<Seller> AllSellers = new List<Seller>();
    }

    public class Seller
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Code { get; set; }
    }
}