using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IGuestTransRepository
    {
        bool AddGTrans(GuestTransaction gt);
        bool UpdateGTrans();
        bool DeleteGTrans(GuestTransaction gt);
        bool DeleteGTrans(int ID);
        List<GuestTransaction> GetGTransByGuestId(int GId);
    }
}
