﻿using Freedi.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedi.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
     
        IGoodRepository Goods{ get; }
        IOrderRepository Orders{ get; }
        void Save();
    }
}
