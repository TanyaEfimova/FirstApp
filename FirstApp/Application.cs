using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Application
    {
        public DbConnection DbConnection { get; set; }
        public void Launch(string dbServer)
        {
            DbConnection = DbConnection.GetConnectionInstance(dbServer);
        }
    }
}
