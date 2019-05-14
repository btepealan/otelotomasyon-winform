using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;
using DAL.Hotel.Model;

namespace BLL.Hotel.Repositories
{
    public class ExtraRepository : IExtraRepository
    {
        OtelResContext ent = new OtelResContext();
        
        public bool AddExtraAndGTrans(ExtraTransactions Ex,int GId)
        {
            using(var trans = ent.Database.BeginTransaction())
            {
                bool Sonuc = false;
                try
                {
                    ent.ExtraTransactions.Add(Ex);
                    ent.SaveChanges();

                    GuestTransaction g = new GuestTransaction();
                    g.Date = Ex.TransactionDate;
                    g.TransType = "Extra Ücreti";
                    g.Debt = Ex.Sum;
                    g.Credit = 0;
                    g.GuestId = Ex.GuestId;
                    g.Status = true;
                    g.Description = "";
                    ent.GuestTransactions.Add(g);
                    ent.SaveChanges();

                    trans.Commit();
                    Sonuc = true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    string hata = ex.Message;
                }
                return Sonuc;
            }
           
        }
        public bool DeleteExtra(int ID)
        {
            bool sonuc = false;
            ExtraTransactions degisen = (from e in ent.ExtraTransactions
                                         where e.Id ==ID
                                         select e).FirstOrDefault();
            degisen.Deleted = true;
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
        public bool UpdateExtraTrans(ExtraTransactions Ex)
        {
            bool sonuc = false;
            ExtraTransactions degisen = (from e in ent.ExtraTransactions
                             where e.Id == Ex.Id
                             select e).FirstOrDefault();

            degisen.Sum = Ex.Sum;
            degisen.Unit = Ex.Unit;
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

        public ExtraTransactions GetExtraType(int ID)
        {
            ExtraTransactions sonuc = (from ex in ent.ExtraTransactions
                         where ex.RoomId == ID && ex.Deleted==false && ex.Status==true
                         select ex).FirstOrDefault();
            return sonuc;
            
        }
       public List<ExtraTransactions> GetExtraTransactions(int GId)
        {
            return ent.ExtraTransactions.Where(x => x.GuestId == GId && x.Status==true).ToList();
        }


        public List<ExtraType> GetExtraTypes()
        {
            return ent.ExtraTypes.ToList();
        }
        public string GetExtraTypeAll(int id)
        {
            string tur = (from ex in ent.ExtraTypes
                                where ex.Id == id && ex.Deleted==false
                                select ex.Type).FirstOrDefault();
            return tur;
        }

        public bool UpdateExtra()
        {
            bool Sonuc = false;
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
        public decimal GetExtraTypePrice(int RoomId)
        {
            decimal sonucPrice = (from r in ent.ExtraTransactions
                             from rt in ent.ExtraTypes 
                             where r.RoomId == RoomId && r.Deleted==false
                             where r.TypeId == rt.Id 
                             select rt.Price).FirstOrDefault();
            return sonucPrice;
        }
        public int GetRoomId(string RoomNo)
        {
            
            int sonucId = (from r in ent.Rooms
                         where r.RoomNumber == RoomNo
                         from rt in ent.ExtraTransactions
                         where rt.RoomId ==r.Id
                         select rt.RoomId ).FirstOrDefault();
            return sonucId;
        }

        public string ExtraTypeAll(int id)
        {
            throw new NotImplementedException();
        }
        public bool ExtraControl(ExtraType e)
        {
            var Extra = (from ext in ent.ExtraTypes
                            where ext.Type == e.Type
                            select ext).FirstOrDefault();
            if (Extra != null)
                return true;
            return false;
        }
        public ExtraType GetExtraById(int ID)
        {
            ExtraType degisen = (from c in ent.ExtraTypes
                                  where c.Id == ID
                                  select c).FirstOrDefault();
            return degisen;
        }
        public bool ExtraControlFromUpdate(ExtraType e)
        {
            var extra = (from ext in ent.ExtraTypes
                            where ext.Type == e.Type && ext.Id != e.Id
                            select ext).FirstOrDefault();
            if (extra != null)
                return true;
            return false;
        }
    }
}
