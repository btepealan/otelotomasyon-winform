using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("Personnel")]

    public class Personnel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PersonName { get; set; }
        [Required]
        public string PersonSurname { get; set; }
        [Required]
        public bool Admin { get; set; }
        [StringLength(11)]
        public string IdentificationNo { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Uname { get; set; }
        [Required]
        public string Upwd { get; set; }
        [Required]
        public string JobName { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public bool Status { get; set; }

        public virtual List<Sale> Sales { get; set; }
        public virtual List<Campaign> Campaigns { get; set; }


    }
}
