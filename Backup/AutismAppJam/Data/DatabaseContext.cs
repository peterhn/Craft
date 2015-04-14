using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace AutismAppJam.Data
{
    public class DatabaseContext
    {
        public static IDbConnection GetDbConnection()
        {
            var dbFactory = new OrmLiteConnectionFactory(
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString,
                SqlServerDialect.Provider);

            return dbFactory.OpenDbConnection();
        }
    }
}