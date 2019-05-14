using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Model
{
    public class GuestTransModel
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string RoomNo { get; set; }
        public string TransType { get; set; }
        public decimal Debt { get; set; }
        public decimal Credit { get; set; }
        public DateTime Date { get; set; }

    }
}
