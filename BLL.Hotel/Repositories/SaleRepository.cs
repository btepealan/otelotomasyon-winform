using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;
using DAL.Hotel.Model;

namespace BLL.Hotel.Repositories
{
    public class SaleRepository : ISalesRepository
    {
        OtelResContext ent = new OtelResContext();

        public bool AddSales(Sale s)
        {
            bool Sonuc = false;
            ent.Sales.Add(s);
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

        public bool DeleteSales(int GId)
        {
            bool Sonuc = false;
            Sale sa = ent.Sales.Where(x => x.GuestId == GId && x.Deleted == false).OrderByDescending(x=>x.Id).FirstOrDefault();
            sa.Deleted = true;
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }

        public bool DeletePersonnel(int ID)
        {
            throw new NotImplementedException();
        }
        public List<Sale> GetSaleforFullRoom(DateTime Tarih)
        {

            return ent.Sales.Where(x=>x.Deleted == false && x.CheckIn < Tarih && x.CheckOut > Tarih).Select(x=>x).ToList();
        }
        public int GetSaleIdByGuest(int GuestId)
        {
            int SaleId = Convert.ToInt32((from s in ent.Sales
                                          where s.GuestId==GuestId && s.Deleted == false
                                          select s.Id).FirstOrDefault());
            return SaleId;
        }
        public List<Guest> GetActiveGuest()
        {
            return ent.Sales.Where(x=>x.Status==true && x.Deleted == false).Select(x=>x.Guest).ToList();
        }
        public List<Guest> GetReservationGuest()
        {
            DateTime Tarih;
            Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return ent.Sales.Where(x => x.Status == false && x.CheckIn>Tarih && x.Deleted == false).Select(x => x.Guest).ToList();
        }
        public List<Sale> GetSales()
        {
            return ent.Sales.Where(x=>x.Status==true).ToList();
        }
        
        public Sale GetSaleById(int SaleId)
        {
            return ent.Sales.Where(x=>x.Id==SaleId && x.Status==true ).Select(x=>x).FirstOrDefault();
        }
        public Sale GetSaleByGuest(int GuestId)
        {
            return ent.Sales.Where(x => x.GuestId == GuestId && x.Status == true).Select(x => x).FirstOrDefault();

        }
        public List<ReservationsModel> GetSales(DateTime today)
        {
            List<ReservationsModel> SaleList = (from sl in ent.Sales
                                   where sl.CheckIn >= today.Date && sl.Status == false && sl.Deleted==false
                                   select new ReservationsModel { SalesId=sl.Id,GuestId=sl.GuestId,GuestFirstName=sl.Guest.FirstName,GuestLastName=sl.Guest.LastName,GuestIdtf=sl.Guest.IdentificationNo,GuestContactNo=sl.Guest.ContactNo,GuestMail=sl.Guest.Email,CheckIn=sl.CheckIn,CheckOut=sl.CheckOut }).ToList();
            return SaleList;
        }

        public int GetSalesId(int ID)
        {
            var sonuc = (from s in ent.Sales
                         where s.RoomId == ID && s.Deleted == false
                         select s.Id).FirstOrDefault();
            return sonuc;
        }

        //Gelen Tarihteki odteldeki satışlar
        public List<SaleModel> SalesIdGetByDate(DateTime Tarih)
        {
            List<SaleModel> Sales = (from s in ent.Sales
                                 where s.CheckIn <= Tarih.Date && s.CheckOut >= Tarih.Date && s.Deleted == false
                                 from g in ent.Guests where g.Id==s.GuestId
                                 select new SaleModel {SaleID=s.Id,FirstName=g.FirstName,LastName=g.LastName,Identification=g.IdentificationNo }).ToList();
            return Sales;
        }

        public bool UpdateSalesByGuestId(int ID)
        {
            bool sonuc = false;
            Sale sondeger = (from s in ent.Sales
                             where s.GuestId == ID 
                             select s).FirstOrDefault();
            sondeger.Status = false;
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
