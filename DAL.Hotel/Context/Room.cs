using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("Rooms")]

    public class Room
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public int RoomTypeId { get; set; }
        public int FloorNumber { get; set; }
        public bool State { get; set; }

        //Relations
        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }
        public virtual List<Sale> Sales { get; set; }
        public virtual List<ExtraTransactions> ExtraTransactions { get; set; }
    }
}
