using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        OtelResContext ent = new OtelResContext();
        public int GetRoomId(string RoomNo)
        {
            int sonuc = (from r in ent.Rooms
                         where r.RoomNumber == RoomNo
                         select r.Id).FirstOrDefault();
            return sonuc;
        }
        public string GetRoomNo(int Id)
        {
            string sonuc = (from r in ent.Rooms
                         where r.Id == Id
                         select r.RoomNumber).FirstOrDefault();
            return sonuc;
        }
        public decimal GetRoomPrice(string RoomNo)
        {
            decimal sonuc = (from r in ent.Rooms
                             from rt in ent.RoomType
                             where r.RoomNumber == RoomNo
                             where r.RoomTypeId == rt.Id
                             select rt.Price).FirstOrDefault();
            return sonuc;
        }
        public List<Room> GetRooms()
        {
            return ent.Rooms.ToList();
        }
        public List<Room> GetRoomsByFloor(int FloorNo)
        {
            return ent.Rooms.Where(x=>x.FloorNumber==FloorNo).ToList();
        }
        public RoomType GetType(int TypeId)
        {
            RoomType rt = (from r in ent.RoomType
                           where r.Id == TypeId
                           select r).FirstOrDefault();
            return rt;
        }
        public List<Room> GetFullRooms(List<Sale> ss)
        {
            List<Room> liste = new List<Room>();
            foreach (Sale item in ss)
            {
                Room fullroom = (from r in ent.Rooms
                                 where r.Id == item.RoomId
                                 select r).FirstOrDefault();

                liste.Add(fullroom);
            }
            return liste;
        }
        public int FullRoomsCount(DateTime dt)
        {
            int DoluSayi=(from s in ent.Sales
                         where s.Status==true && s.CheckIn<=dt && s.CheckOut>=dt
                         select s).Count();
            return DoluSayi;
        }
        public int CheckInCount(DateTime Tarih)
        {
            int Cc = (from s in ent.Sales
                              where s.Status == false && s.CheckIn.Month == Tarih.Month && s.CheckIn.Day == Tarih.Day
                              select s).Count();
            return Cc;
        }
        public int CheckOutCount(DateTime Tarih)
        {
            int Cc = (from s in ent.Sales
                      where s.Status == false && s.CheckOut.Month == Tarih.Month && s.CheckOut.Day == Tarih.Day
                      select s).Count();
            return Cc;
        }
        //ıd ye göre oda o getiren sorgu yaz
        public Room GetRoom(int Rid)
        {
            return ent.Rooms.Where(x => x.Id == Rid).Select(x => x).FirstOrDefault();
        }
        public bool UpdateRoomByRoomNo(string RoomNum)
        {
            bool sonuc = false;
            bool sondeger = (from s in ent.Rooms
                             where s.RoomNumber == RoomNum
                             select s.State).FirstOrDefault();
            sondeger = false;
            try
            {
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return sonuc;

        }
    }
}
