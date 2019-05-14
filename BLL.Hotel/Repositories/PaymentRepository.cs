using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        OtelContext ent = new OtelContext();
        public bool AddPayment(Payment p)
        {
            bool Sonuc = false;
            ent.Payments.Add(p);
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
