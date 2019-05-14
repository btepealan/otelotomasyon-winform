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
    [Table("Guests")]

    public class Guest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [StringLength(11)]
        public string IdentificationNo { get; set; }
        public string Gender { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int RoomId { get; set; }
        public string Adress { get; set; }
        public DateTime Birthday { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        //Relations

        public virtual List<Sale> Sales { get; set; }
        public virtual List<GuestTransaction> GuestTransactions { get; set; }

    }
}
