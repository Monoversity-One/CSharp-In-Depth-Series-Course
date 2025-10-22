using System.ComponentModel.DataAnnotations.Schema;
using _08_3.EFExample.AutoLotDAL.Models.Base;

namespace _08_3.EFExample.AutoLotDAL.Models
{
    public partial class Inventory : EntityBase
    {
        public override string ToString()
        {
            return $"{PetName ?? "***No Name***"} is a {Color} {Make} with ID {Id}.";
        }
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";
    }
}
