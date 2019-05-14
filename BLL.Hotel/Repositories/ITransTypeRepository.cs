using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface ITransTypeRepository
    {
        List<TransactionType> GetAllTransType();
        List<TransactionType> GetTransTypeByDefin(string Defin);

    }
}
