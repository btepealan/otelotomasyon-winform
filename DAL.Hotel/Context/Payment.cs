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
    [Table("Payments")]

    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TransType { get; set; }
        [Required]
        public decimal Incoming { get; set; }
        [Required]
        public decimal Outgoing { get; set; }
        [Required]
        public int GuestId { get; set; }
        [Required]
        public int PersonnelId { get; set; }
        [Required]
        public bool Status { get; set; }
        public string Description { get; set; }



        //Relations
        [ForeignKey("TransType")]
        public virtual TransactionType TransactionType { get; set; }

    }
}
