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
    [Table("ExtraType")]

    public class ExtraType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        //Relations

        public virtual List<ExtraTransactions> ExtraTransactions { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
