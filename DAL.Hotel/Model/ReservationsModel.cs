using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Model
{
  public  class ReservationsModel
    {
        public int SalesId { get; set; }

        public int GuestId { get; set; }
       public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
        public string GuestIdtf { get; set; }
        public string GuestContactNo { get; set; }
        public string GuestMail { get; set; }
        public DateTime CheckIn { get; set; }
      
        public DateTime CheckOut { get; set; }
  
       
    }
}
