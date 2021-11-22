using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Toto
    {
        public DatabaseSingleton Database;

        public Toto()
        {
            Database = DatabaseSingleton.GetInstance();
        }

    }
}
