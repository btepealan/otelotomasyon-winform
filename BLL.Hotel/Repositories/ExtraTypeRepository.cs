using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public class ExtraTypeRepository
    {
        OtelResContext ent = new OtelResContext();
        public List<ExtraType> GetExtraTypes()
        {
            return ent.ExtraTypes.ToList();
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
        public bool AddExtra(ExtraType Ex)
        {
            bool Sonuc = false;
            ent.ExtraTypes.Add(Ex);
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
        public bool DeleteExtra(int ID)
        {
            bool Sonuc = false;
            ExtraType silinen = (from p in ent.ExtraTypes
                                 where p.Id == ID
                                 select p).FirstOrDefault();
            silinen.Deleted = true;
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
