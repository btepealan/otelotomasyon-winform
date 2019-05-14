using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("Sales")]

    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public int NoOfGuests { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public bool Status { get; set; }

        public int PersonnelId { get; set; }
        public int GuestId { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        //Relations
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }
        [ForeignKey("GuestId")]
        public virtual Guest Guest { get; set; }
        [ForeignKey("PersonnelId")]
        public virtual Personnel Personnel { get; set; }


    }
}
