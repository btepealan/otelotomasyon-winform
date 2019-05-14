using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class TransTypeRepository : ITransTypeRepository
    {
        OtelResContext ent = new OtelResContext();
        public List<TransactionType> GetAllTransType()
        {
            return ent.TransactionTypes.ToList();
        }

        public List<TransactionType> GetTransTypeByDefin(string Defin)
        {
            return ent.TransactionTypes.Where(x => x.Defin == Defin).ToList();
        }
        public int TransIdByTransType(string TransType)
        {
            return ent.TransactionTypes.Where(x => x.Transtype == TransType).Select(x=>x.Id).FirstOrDefault();
        }
    }
}
