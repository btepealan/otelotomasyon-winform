using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IEktraRepository
    {
        List<ExtraType> GetExtraTypes();
        bool AddExtra(ExtraType Ex);
        bool UpdateExtra();
        bool DeleteExtra(int ID);
        bool ExtraControl(ExtraType ex);
        
        int GetRoomId(string RoomNo);
        decimal GetExtraTypePrice(int RoomId);
        string ExtraTypeAll(int id);
        ExtraType GetExtraById(int ID);
        bool ExtraControlFromUpdate(ExtraType e);
    }
}
