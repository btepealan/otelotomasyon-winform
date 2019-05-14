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
    [Table("TransTypes")]
    public class TransactionType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Defin { get; set; }
        [Required]
        public string Transtype { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public virtual List<Payment> Payments { get; set; }


        public override string ToString()
        {
            return Transtype;
        }
    }
}
