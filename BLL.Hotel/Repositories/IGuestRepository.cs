using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IGuestRepository
    {
        List<Guest> GetAllGuest();
        List<Guest> GetGuest(int roomId, bool stat);
        List<Guest> GetGuestsInRoom(int RoomId);
        Guest GetGuestByTC(string TC);
        bool AddGuest(Guest g);
        bool UpdateGuest(Guest g);
        int GetGuestIdByTC(string IdentificationNo);
    }
}
