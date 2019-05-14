using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("GuestTransactions")]

    public class GuestTransaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string TransType { get; set; }
        [Required]
        public decimal Debt { get; set; }
        [Required]
        public decimal Credit { get; set; }

        public int GuestId { get; set; }
        [Required]
        public bool Status { get; set; }
        public string Description { get; set; }



        //Relations
        [ForeignKey("GuestId")]
        public virtual Guest Guest { get; set; }
    }
}
