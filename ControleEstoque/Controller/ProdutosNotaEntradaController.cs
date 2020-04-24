using ControleEstoque.ADO_NET;
using ControleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Controller
{
    public class ProdutosNotaEntradaController
    {
        private SqlConnection connection = DbConnection.DB_Connection;

        private void Insert(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
        {
            notaEntrada.Produtos.Add(produto);
            var command = new SqlCommand("insert into ProdutoNotaDeEntrada (IdNotaDeEntrada, IdProduto, PrecoCustoCompra, QuantidadeComprada) values (@IdNotaDeEntrada, @IdProduto, @PrecoCustoCompra, @QuantidadeComprada)", connection);
            command.Parameters.AddWithValue("@IdNotaDeEntrada", notaEntrada.Id);
            command.Parameters.AddWithValue("@IdProduto", produto.ProdutoNota.Id);
            command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@QuantidadeComprada", produto.QuantidadeComprada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Produto inserido na nota de entrada com sucesso!");
        }

        private void Update(ProdutoNotaEntrada produto)
        {
            var command = new SqlCommand("update ProdutoNotaDeEntrada set IdProduto = @IdProduto, IdNotaDeEntrada = @IdNotaDeEntrada, PrecoCustoCompra = @PrecoCustoCompra, QuantidadeComprada = @QuantidadeComprada where Id = @Id", connection);
            command.Parameters.AddWithValue("@IdProduto", produto.ProdutoNota.Id);
            command.Parameters.AddWithValue("@IdNotaDeEntrada", produto.NotaEntrada.Id);
            command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@QuantidadeComprada", produto.QuantidadeComprada);
            command.Parameters.AddWithValue("@Id", produto.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Produto atualizado na nota de entrada com sucesso!");
        }

        public void Save(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
        {
            if (produto.Id != null)
            {
                this.Update(produto);
            }
            else
            {
                this.Insert(notaEntrada, produto);
            }
        }

        public void GetAllprodutoNotaEntrada(long? Id, DataGridView data)
        {
            var command = new SqlCommand("select Id, IdProduto, IdNotaDeEntrada, PrecoCustoCompra, QuantidadeComprada from ProdutoNotaDeEntrada where IdNotaDeEntrada = @IdNotaDeEntrada", connection);
            command.Parameters.AddWithValue("@IdNotaDeEntrada", Id);
            var adapter = new SqlDataAdapter(command);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            data.DataSource = table;
            connection.Close();
        }

        public void RemoveAllProdutosPorNota(long? id)
        {
            var command = new SqlCommand("delete from ProdutoNotaDeEntrada where IdNotaDeEntrada = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Remove(long? Id)
        {
            var command = new SqlCommand("delete from ProdutoNotaDeEntrada where id = @id", connection);
            command.Parameters.AddWithValue("@id", Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Produto removido da nota de entrada com sucesso!");
        }

        internal ProdutoNotaEntrada GetProdutoNotaEntradaById(long? Id)
        {
            var produtoNotaEntrada = new ProdutoNotaEntrada();
            var produtoController = new ProdutoController();
            long? IdProduto = -1;
            var command = new SqlCommand("select Id, IdProduto, PrecoCustoCompra, QuantidadeComprada from ProdutoNotaDeEntrada where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", Id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produtoNotaEntrada.Id = reader.GetInt64(0);
                    IdProduto = reader.GetInt64(1);
                    produtoNotaEntrada.PrecoCustoCompra = reader.GetDouble(2);
                    produtoNotaEntrada.QuantidadeComprada = reader.GetDouble(3);
                }
            }
            connection.Close();
            if (IdProduto > 0)
            {
                produtoNotaEntrada.ProdutoNota = produtoController.GetProdutoById(IdProduto);
            }
            return produtoNotaEntrada;
        }
    }
}
