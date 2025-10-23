#region

using System.Collections.Generic;

#endregion

namespace BasicInventoryManager.MyClass.Part
{
    public class Parts
    {
        public static List<Part> AllParts = new List<Part>();
    }

    public class Part
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Price { get; set; }
    }
}