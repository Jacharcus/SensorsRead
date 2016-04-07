using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Dal
{
    using System.Data.Common;

    public class BaseDal
    {
        private DbConnection _connection;

        public DbConnection GetConnection
        {
            get
            {
                if (this._connection == null)
                {
                    this.OpenConnection();
                }
                return this._connection;
            }
        }

        public void OpenConnection()
        {
            this._connection = new DbConnection();
        }

        public void CloseConnection()
        {

        }
    }
}
