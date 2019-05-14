using DAL.Hotel.Context;
using DAL.Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
   public interface IReservations
    {
        List<Guest> GetReservations(DateTime dt);
        bool UpdateReServations(Reservations rzrv);
        bool CancelReservations(int ID);
    }
}
