using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddGuest(Guest g)
        {
            bool Sonuc = false;
            ent.Guests.Add(g);
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public List<Guest> GetAllGuest()
        {
            return ent.Guests.OrderByDescending(x=>x.Id).ToList();
        }
        public Guest GetGuest()
        {
            return ent.Guests.OrderByDescending(x => x.Id).FirstOrDefault();
        }
        public List<Guest> GetGuest(int roomId, bool stat)
        {
            throw new NotImplementedException();
        }

        public List<Guest> GetGuestsInRoom(int RoomId)
        {
            return ent.Guests.Where(x => x.Status == true && x.RoomId == RoomId).ToList();
        }


        public Guest GetGuestByTC(string TC)
        {
            Guest gst = (from g in ent.Guests
                         where g.IdentificationNo == TC
                         select g).FirstOrDefault();
            return gst;
        }
        public Guest GetGuestById(int Id)
        {
            Guest gst = (from g in ent.Guests
                         where g.Id == Id 
                         select g).FirstOrDefault();
            return gst;
        }

        public int GetGuestIdByTC(string IdentificationNo)
        {
            int GuestId = Convert.ToInt32((from g in ent.Guests
                                          where g.IdentificationNo == IdentificationNo
                                          select g.Id).FirstOrDefault());
            return GuestId;
        }

        public bool UpdateGuest(Guest sondeger)
        {
            bool sonuc = false;
            Guest degisen = (from s in ent.Guests
                              where s.Id == sondeger.Id
                              select s).FirstOrDefault();
            degisen = sondeger;
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
        //public bool UpdateGuestByTC(string TC)
        //{
        //    bool sonuc = false;
        //    Guest sondeger = (from s in ent.Guests
        //                    where s.IdentificationNo == TC
        //                    select s).FirstOrDefault();
        //    sondeger.Status = false;
        //    try
        //    {
        //        ent.SaveChanges();
        //        sonuc = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string hata = ex.Message;
        //    }
        //    return sonuc;

        //}
        public bool UpdateControl(Guest gs)
        {
            bool Sonuc = false;
            int Ctrl = (from g in ent.Guests
                        where g.Status == true && g.IdentificationNo == gs.IdentificationNo && g.Id != gs.Id
                        select g).Count();
            if (Ctrl > 0) Sonuc = true;
            return Sonuc;
        }
        public bool Delete(int Id)
        {
            bool Sonuc = false;
            try
            {
                Guest guest = ent.Guests.Where(x => x.Id == Id).FirstOrDefault();
                guest.Deleted = true;
                guest.Status = false;
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        public bool UpdateGuestStatusForCheckin(int Id)
        {
            bool sonuc = false;
            try
            {
                var sonuc1 = (from g in ent.Guests
                              where g.Id == Id
                              select g).FirstOrDefault();
                sonuc1.Status = true;
                sonuc = true;
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;

            }
            return sonuc;
        }
        public List<Guest> GetGuestBySearch(string Ad,string Soyad,string Tc)
        {
            return ent.Guests.Where(x => x.FirstName.StartsWith(Ad) && x.LastName.StartsWith(Soyad) && x.IdentificationNo.StartsWith(Tc)).ToList();
        }
    }
}
