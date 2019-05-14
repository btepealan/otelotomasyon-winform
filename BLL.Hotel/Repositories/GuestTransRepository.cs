using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;
using DAL.Hotel.Model;

namespace BLL.Hotel.Repositories
{
    public class GuestTransRepository : IGuestTransRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddGTrans(GuestTransaction gt)
        {
            bool Sonuc = false;
            ent.GuestTransactions.Add(gt);
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

        public List<GuestTransaction> GetGTransByGuestId(int GId)
        {
            return ent.GuestTransactions.Where(x => x.GuestId == GId && x.Status==true).ToList();
        }
        
        public bool DeleteGTrans(GuestTransaction gt)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGTrans(int ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGTrans()
        {
            throw new NotImplementedException();
        }
        public List<decimal> PaymentsByGuest(int GuestId)
        {
            List<Decimal> payments = new List<decimal>();
            decimal borc = (from g in ent.GuestTransactions
                            where g.Status == true && g.GuestId==GuestId
                            select g.Debt).DefaultIfEmpty(0).Sum();
            payments.Add(borc);
            decimal odenen = (from g in ent.GuestTransactions
                              where g.Status == true && g.GuestId == GuestId
                              select g.Credit).DefaultIfEmpty(0).Sum();
            payments.Add(odenen);
            payments.Add(borc - odenen);//kalan borç
            return payments;
        }
        public List<GuestTransaction> GetGTransById(int gID)
        {
            List<GuestTransaction> liste = (from gt in ent.GuestTransactions
                                            where gt.GuestId == gID && gt.Status==true
                                            select gt).ToList();

            return liste;
        }
        public List<GuestTransModel> GetExtrasByGuestId(Guest g)
        {
            RoomRepository Rr = new RoomRepository();
            string Rno = Rr.GetRoomNo(g.RoomId);
            List<GuestTransModel> sonuc = (from gt in ent.GuestTransactions
                                           where gt.GuestId == g.Id && gt.Status == true
                                           select new GuestTransModel { Id = gt.Id, GuestName = g.FirstName, GuestSurname = g.LastName, RoomNo = Rno, TransType = gt.TransType, Debt = gt.Debt, Credit = gt.Credit, Date = gt.Date }).ToList();
            return sonuc;

        }
    }
}
