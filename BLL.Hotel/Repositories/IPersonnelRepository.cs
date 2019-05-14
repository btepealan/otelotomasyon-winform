﻿using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IPersonnelRepository
    {
        List<Personnel> GetPersonnels();
        bool AddPersonnel(Personnel p);
        bool UpdatePersonnel(Personnel p);
        bool DeletePersonnel(Personnel p);
        bool DeletePersonnel(int ID);
        bool AdminControl(int ID);
    }
}
