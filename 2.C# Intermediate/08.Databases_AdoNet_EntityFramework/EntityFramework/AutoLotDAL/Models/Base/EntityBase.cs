using System.ComponentModel.DataAnnotations;

namespace _08_3.EFExample.AutoLotDAL.Models.Base
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
