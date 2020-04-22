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
    public class ProdutoController
    {
        public void GetAllProdutos(DataGridView data)
        {
            var connection = DbConnection.DB_Connection;

            var adapter = new SqlDataAdapter("select Id, Descricao, PrecoDeVenda, PrecoDeCusto, Estoque from Produtos", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            data.DataSource = table;
            connection.Close();
            data.ClearSelection();
        }
        public Produto GetProdutoById(long? id)
        {
            Produto produto = new Produto();

            var connectionP = DbConnection.DB_Connection;
            var command = new SqlCommand("select Id, Descricao, PrecoDeVenda, PrecoDeCusto, Estoque from Produtos where Id = @Id", connectionP);
            command.Parameters.AddWithValue("@Id", id);
            connectionP.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.Id = reader.GetInt64(0);
                    produto.Descricao = reader.GetString(1);
                    produto.PrecoDeVenda = reader.GetDouble(2);
                    produto.PrecoDeCusto = reader.GetDouble(3);
                }
            }
            connectionP.Close();
            return produto;
        }
        public void Save(Produto produto)
        {
            if (produto.Id != null)
            {
                this.Update(produto);
            }
            else
            {
                this.Insert(produto);
            }
        }
        private void Insert(Produto produto)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("insert into Produtos(Descricao, PrecoDeVenda, PrecoDeCusto, Estoque) values (@Descricao, @PrecoDeVenda, @PrecoDeCusto, 0)", connection);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Produto adicionado com sucesso!");
        }
        private void Update(Produto produto)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("update Produtos set Descricao=@Descricao, PrecoDeVenda=@PrecoDeVenda, PrecoDeCusto=@PrecoDeCusto", connection);
            command.Parameters.AddWithValue("@Id", produto.Id);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Remove(long? Id)
        {
            var connection = DbConnection.DB_Connection;
            var command = new SqlCommand("delete from Produtos where id = @id", connection);
            command.Parameters.AddWithValue("@id", Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
