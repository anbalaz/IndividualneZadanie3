﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface ITownRepository
    {
        List<Town> SelectListData();
        DataSet SelectTopTowns();
    }
}