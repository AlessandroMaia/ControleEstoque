using ModelProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ControllerProject
{
    public class FornecedorController
    {
        private void GetAllFornecedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbProjeto"].ConnectionString;
            var connection = new SqlConnection(connectionString);
        }
    }
}
