﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<CLASS,ID>
    {
        CLASS Create(CLASS obj);
        List<CLASS> Get();
        CLASS Get(ID id);
        CLASS Update(CLASS obj);
        bool Delete(ID id);
    }
}
