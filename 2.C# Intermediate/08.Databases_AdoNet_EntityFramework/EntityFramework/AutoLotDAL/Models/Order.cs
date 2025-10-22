using System.ComponentModel.DataAnnotations.Schema;
using _08_3.EFExample.AutoLotDAL.Models.Base;

namespace _08_3.EFExample.AutoLotDAL.Models
{
    public partial class Order :EntityBase
    {
        public int CustId { get; set; }

        public int CarId { get; set; }
        [ForeignKey(nameof(CustId))]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(CarId))]
        public virtual Inventory Car { get; set; }
    }
}
