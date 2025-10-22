using _08_3.EFExample.AutoLotDAL.Models;

namespace _08_3.EFExample.AutoLotDAL.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>
    {
        //public override List<Inventory> GetAll()
        //{
        //    return Context.Inventories.OrderBy(x => x.PetName).ToList();
        //}
    }
}
