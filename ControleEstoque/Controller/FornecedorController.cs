using ControleEstoque.ADO_NET;
using ControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Controller
{
    public class FornecedorController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbProjeto"].ConnectionString;
       
        public void GetAllFornecedores(DataGridView data)
        {
            var connection = DbConnection.DB_Connection;
 
            var adapter = new SqlDataAdapter("select id, cnpj, nome from Fornecedores", connectionString);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            data.DataSource = table;
            connection.Close();
            data.ClearSelection();
        }
        public Fornecedor GetFornecedorById(long? id)
        {
            Fornecedor fornecedor = new Fornecedor();

            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("select id, cnpj, nome from Fornecedores where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt64(0);
                    fornecedor.CNPJ = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
            }
            connection.Close();
            return fornecedor;
        } 

        public void Save(Fornecedor fornecedor)
        {
            if (fornecedor.Id != null)
            {
                this.Update(fornecedor);
            }
            else
            {
                this.Insert(fornecedor);
            }
        }
        private void Insert(Fornecedor fornecedor)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("insert into Fornecedores(nome, cnpj) values (@nome, @cnpj)", connection);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fornecedor registrado com sucesso!");
        }
        private void Update(Fornecedor fornecedor)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("update Fornecedores set Cnpj = @cnpj, Nome = @nome where Id = @Id", connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@id", fornecedor.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Remove(long? id)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("delete from Fornecedores where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
