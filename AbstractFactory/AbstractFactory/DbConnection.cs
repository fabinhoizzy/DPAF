using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /* Abstract Product */
    public abstract class DbConnection
    {
        public abstract void Open();
    }
}
