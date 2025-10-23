using System.Collections.Generic;

namespace BasicInventoryManager.MyClass.PartSell
{
    public class PartsSell
    {
        public static List<PartSell> AllPartsSell = new List<PartSell>();
    }

    public class PartSell
    {
        public string PartSellId { get; set; }
        public string SellerCode { get; set; }
        public string PartId { get; set; }
    }
}
