using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.ADO_NET
{
    public sealed class DbConnection
    {
        private static volatile SqlConnection instance;

        private DbConnection() { }

        public static SqlConnection DB_Connection 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new SqlConnection(ConfigurationManager.ConnectionStrings["DbProjeto"].ConnectionString);
                }
                return instance;
            }
        
        }

    }
}
