using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PaymentsRepository : IPaymentsRepository
    {
        OtelResContext ent = new OtelResContext();

        //public List<Payment> GetPayments()
        //{
        //    return ent.Payments.ToList();
        //}

        //public List<decimal> PaymentsToDate(DateTime Date)
        //{
        //    List<Decimal> payments = new List<decimal>();
        //    Date = Convert.ToDateTime(Date.ToShortDateString());
        //    decimal borc = (from g in ent.Payments
        //                     where g.Status == true && (g.Date < Date)
        //                     select g.Debt).DefaultIfEmpty(0).Sum();
        //    payments.Add(borc);
        //    decimal odenen = (from g in ent.Payments
        //                    where g.Status == true && (g.Date < Date)
        //                    select g.Credit).DefaultIfEmpty(0).Sum();
        //    payments.Add(odenen);
        //    payments.Add(borc - odenen);//kalan borç
        //    return payments;

        //}

        //public List<Payment> PaymentsByDate(DateTime Date)
        //{
        //    var payments = (from p in ent.Payments
        //                    where p.Status == true && p.Date.Month == Date.Month && p.Date.Day==Date.Day
        //                    select p).ToList();
        //    return payments;
        //}
        //public List<Payment> PaymentsByDate(DateTime Date,string TransType)
        //{
        //    var payments = (from p in ent.Payments
        //                    where p.Status == true && p.Date.Month == Date.Month && p.Date.Day == Date.Day && p.TransType==TransType
        //                    select p).ToList();
        //    return payments;
        //}

        //public bool PaymentsAdd(Payment pay)
        //{
        //    bool sonuc = false;
        //    ent.Payments.Add(pay);
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


        //public List<decimal> PaymentTransBySalesId(int SalesId)
        //{
        //    List<Decimal> payments = new List<decimal>();
        //    decimal borc = (from g in ent.Payments
        //                    where g.Status == true && g.SalesId == SalesId
        //                    select g.Debt).DefaultIfEmpty(0).Sum();
        //    payments.Add(borc);
        //    decimal odenen = (from g in ent.Payments
        //                      where g.Status == true && g.SalesId == SalesId
        //                      select g.Credit).DefaultIfEmpty(0).Sum();
        //    payments.Add(odenen);
        //    payments.Add(borc - odenen);//kalan borç
        //    return payments;
        //}
        //public List<PaymentModel> GetPaymentsByGuest(List<Sale> Sl,string ad)
        //{
        //    List<PaymentModel> liste = new List<PaymentModel>();
        //    foreach (Sale item in Sl)
        //    {
        //        List<PaymentModel> paym = (from s in ent.Sales
        //                                   where s.Id == item.Id
        //                                   from p in ent.Payments
        //                                   where p.SalesId == item.Id && p.Status==true 
        //                                   from g in ent.Guests
        //                                   where g.Id == s.GuestId && g.FirstName.StartsWith(ad)
        //                                   select new PaymentModel { PaymentId = p.Id, FirstName = g.FirstName, LastName = g.LastName, IdentificationNo = g.IdentificationNo, TransType = p.TransType, Debt = p.Debt, Credit = p.Credit ,Status=p.Status}).ToList();
        //        foreach (PaymentModel paymod in paym)
        //        {
        //            liste.Add(paymod);
        //        }


        //    }

        //    return liste;
        //}
        //public List<PaymentModel> GetPaymentsByGuest(List<Sale> Sl, DateTime Tarih)
        //{
        //    List<PaymentModel> liste = new List<PaymentModel>();
        //    foreach (Sale item in Sl)
        //    {
        //        List<PaymentModel> paym = (from s in ent.Sales
        //                                   where s.Id == item.Id
        //                                   from p in ent.Payments
        //                                   where p.SalesId == item.Id && p.Status == true && p.Date.Month==Tarih.Month &&p.Date.Day==Tarih.Day
        //                                   from g in ent.Guests
        //                                   where g.Id == s.GuestId 
        //                                   select new PaymentModel { PaymentId = p.Id, FirstName = g.FirstName, LastName = g.LastName, IdentificationNo = g.IdentificationNo, TransType = p.TransType, Debt = p.Debt, Credit = p.Credit }).ToList();
        //        foreach (PaymentModel paymod in paym)
        //        {
        //            liste.Add(paymod);
        //        }


        //    }

        //    return liste;
        //}
        //public bool UpdatePaymentStatusForCheckin(int Sales)
        //{
        //    bool sonuc = false;
        //    try
        //    {
        //        var sonuc1 = (from p in ent.Payments
        //                      where p.SalesId == Sales
        //                      select p).FirstOrDefault();
        //        sonuc1.Status = true;
        //        sonuc = true;
        //        ent.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        string hata = ex.Message;

        //    }
        //    return sonuc;
        //}
        //public List<PaymentModel> PaylistByGuestId(int SalesId,string Type)
        //{
        //    List<PaymentModel> list = new List<PaymentModel>();
        //    if (Type == "Hepsi")
        //    {
        //         list = (from s in ent.Sales where s.Id==SalesId
        //                 from g in ent.Guests where g.Id==s.GuestId
        //                 from p in ent.Payments where p.SalesId==SalesId
        //                 select new PaymentModel { PaymentId = p.Id, FirstName = g.FirstName, LastName = g.LastName, IdentificationNo = g.IdentificationNo, TransType = p.TransType, Debt = p.Debt, Credit = p.Credit }).ToList();
        //    }
        //    else if (Type == "Ödemeler")
        //    {
        //        list = (from s in ent.Sales
        //                where s.Id == SalesId
        //                from g in ent.Guests
        //                where g.Id == s.GuestId
        //                from p in ent.Payments
        //                where p.SalesId == SalesId && p.TransType=="Tahsilat"
        //                select new PaymentModel { PaymentId = p.Id, FirstName = g.FirstName, LastName = g.LastName, IdentificationNo = g.IdentificationNo, TransType = p.TransType, Debt = p.Debt, Credit = p.Credit }).ToList();
        //    }
        //    else
        //    {
        //        list = (from s in ent.Sales
        //                where s.Id == SalesId
        //                from g in ent.Guests
        //                where g.Id == s.GuestId
        //                from p in ent.Payments
        //                where p.SalesId == SalesId && p.TransType !="Tahsilat"
        //                select new PaymentModel { PaymentId = p.Id, FirstName = g.FirstName, LastName = g.LastName, IdentificationNo = g.IdentificationNo, TransType = p.TransType, Debt = p.Debt, Credit = p.Credit }).ToList();
        //    }
        //    return list;
        //}
        //public bool UpdatePaymentBySalesId(int ID)
        //{
        //    bool sonuc = false;
        //    List<Payment> sondeger = (from s in ent.Payments
        //                     where s.SalesId == ID
        //                     select s).ToList();
        //    foreach (Payment item in sondeger)
        //    {
        //        item.Status = false;
        //    }
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
        public List<Payment> GetAllPayments()
        {
            return ent.Payments.ToList();
        }
        public List<PaymentModel> GetAllPaymentsModel()
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing,Description=p.Description }).ToList();
            return liste;
        }
        public List<PaymentModel> GetAllPaymentsModelByDate(DateTime Tarih)
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        where p.Date.Month == Tarih.Month && p.Date.Day == Tarih.Day
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing, Description = p.Description }).ToList();
            return liste;
        }
        public List<PaymentModel> GetAllPaymentsModelByDate(DateTime Tarih,string Defin)
        {
            List<PaymentModel> liste = (from p in ent.Payments
                                        where p.Date.Month == Tarih.Month && p.Date.Day == Tarih.Day && p.TransactionType.Defin==Defin
                                        select new PaymentModel { Id = p.Id, Date = p.Date, Defin = p.TransactionType.Defin, TtName = p.TransactionType.Transtype, Incoming = p.Incoming, Outgoing = p.Outgoing, Description = p.Description }).ToList();
            return liste;
        }
        public bool AddPaymentByIncoming(Payment pay, string TransType)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool sonuc = false;
                try
                {
                    ent.Payments.Add(pay);
                    ent.SaveChanges();

                    GuestTransaction gt = new GuestTransaction();
                    gt.Date = pay.Date;
                    gt.TransType = TransType;
                    gt.Debt = 0;
                    gt.Credit = pay.Incoming;
                    gt.GuestId = pay.GuestId;
                    gt.Status = true;
                    gt.Description = pay.Description;
                    ent.GuestTransactions.Add(gt);
                    ent.SaveChanges();

                    trans.Commit();
                    sonuc = true;

                }
                catch (Exception)
                {
                    trans.Rollback();
                }
                return sonuc;

            }
        }

        public bool AddPaymentByOutgoing(Payment pay)
        {
            bool Sonuc = false;
            ent.Payments.Add(pay);
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

    }
}

