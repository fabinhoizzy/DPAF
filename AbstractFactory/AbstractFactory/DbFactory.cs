using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFactory
{
    public abstract class AbstractFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
