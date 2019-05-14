using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class Reservations : IReservations
    {
        OtelResContext ent = new OtelResContext();
        public bool CancelReservations(int ID)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool sonuc = false;

                try
                {
                    Sale sa = (from s in ent.Sales
                               where s.GuestId == ID && s.Deleted == false
                               orderby s.Id descending
                               select s).FirstOrDefault();
                    sa.Deleted = true;
                    sa.TotalPrice = 0;
                    ent.SaveChanges();
                    GuestTransaction gt = (from g in ent.GuestTransactions
                                where g.Id == ID && g.TransType == "Konaklama Ücreti"
                                orderby g.Id descending
                                select g).FirstOrDefault();
                    gt.Status = false;
                    gt.Debt = 0;
                    ent.SaveChanges();
                    trans.Commit();
                    sonuc = true;
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    trans.Rollback();
                }
                return sonuc;
            }
        }

        public List<Guest> GetReservations(DateTime dt)
        {
            dt = Convert.ToDateTime(dt.ToShortDateString());
            List<Guest> RG = (from s in ent.Sales
                              where dt <= s.CheckIn
                              from g in ent.Guests
                              where s.GuestId == g.Id && g.Status == false
                              select g).ToList();
            return RG;
        }
        public bool UpdateResarvation(int ID)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool sonuc = false;

                try
                {
                    Sale sa = (from s in ent.Sales
                               where s.GuestId == ID && s.Deleted == false
                               orderby s.Id descending
                               select s).FirstOrDefault();
                    sa.Status = true;
                    ent.SaveChanges();
                    Guest gu = (from g in ent.Guests
                                where g.Id == ID && g.Deleted == false
                                orderby g.Id descending
                                select g).FirstOrDefault();
                    gu.Status = true;
                    ent.SaveChanges();
                    trans.Commit();
                    sonuc = true;
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    trans.Rollback();
                }
                return sonuc;
            }
        }
        public bool UpdateReServations(Reservations rzrv)
        {
            throw new NotImplementedException();
        }
    }
}
