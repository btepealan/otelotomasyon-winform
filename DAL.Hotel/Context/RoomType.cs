using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("RoomTypes")]

    public class RoomType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoomName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Relations

        public virtual List<Room> Rooms { get; set; }

    }
}
