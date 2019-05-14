using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Defin { get; set; }
        public string TtName { get; set; }
        public decimal Incoming { get; set; }
        public decimal Outgoing { get; set; }
        public string Description { get; set; }
    }
}
