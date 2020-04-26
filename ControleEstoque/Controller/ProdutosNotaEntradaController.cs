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

            double qtdProduto = BuscaEstoqueProduto(produto.ProdutoNota.Id) + produto.QuantidadeComprada;
            UpdateEstoqueProdutos(qtdProduto, produto.ProdutoNota.Id);

            MessageBox.Show("Produto inserido na nota de entrada com sucesso!");
        }
        private void Update(ProdutoNotaEntrada produto)
        {
            double qtdProdutoAntigo = BuscaEstoqueProduto(produto.ProdutoNota.Id) - BuscaEstoqueProdutoPorNota(produto.Id);
            UpdateEstoqueProdutos(qtdProdutoAntigo, produto.ProdutoNota.Id);

            double qtdProdutoNovo = BuscaEstoqueProduto(produto.ProdutoNota.Id) + produto.QuantidadeComprada;
            UpdateEstoqueProdutos(qtdProdutoNovo, produto.ProdutoNota.Id);

            var command = new SqlCommand("update ProdutoNotaDeEntrada set IdProduto = @IdProduto, IdNotaDeEntrada = @IdNotaDeEntrada, PrecoCustoCompra = @PrecoCustoCompra, QuantidadeComprada = @QuantidadeComprada where Id = @Id", connection);
            command.Parameters.AddWithValue("@IdProduto", produto.ProdutoNota.Id);
            command.Parameters.AddWithValue("@IdNotaDeEntrada", produto.NotaEntrada.Id);
            command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@QuantidadeComprada", produto.QuantidadeComprada);
            command.Parameters.AddWithValue("@Id", produto.Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            UpdateEstoqueProdutos(produto.QuantidadeComprada, produto.ProdutoNota.Id);

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
            foreach (var produto in GetAllIdProdutoDaNotaEntrada(id))
            {
                double qtdProduto = BuscaEstoqueProduto(Convert.ToInt64(produto.ItemArray[0])) - BuscaEstoqueProdutoPeloIdNota(id);
                UpdateEstoqueProdutos(qtdProduto, Convert.ToInt64(produto.ItemArray[0]));
            }

            var command = new SqlCommand("delete from ProdutoNotaDeEntrada where IdNotaDeEntrada = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Remove(long? Idproduto, long? Id)
        {

            double qtdProduto = BuscaEstoqueProduto(Idproduto) - BuscaEstoqueProdutoPorNota(Id);
            UpdateEstoqueProdutos(qtdProduto, Idproduto);

            var command = new SqlCommand("delete from ProdutoNotaDeEntrada where id = @id", connection);
            command.Parameters.AddWithValue("@id", Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Produto removido da nota de entrada com sucesso!");
        }
        public ProdutoNotaEntrada GetProdutoNotaEntradaById(long? Id)
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

        public List<DataRow> GetAllIdProdutoDaNotaEntrada(long? Id)
        {
            var command = new SqlCommand("select IdProduto from ProdutoNotaDeEntrada where IdNotaDeEntrada = @IdNotaDeEntrada", connection);
            command.Parameters.AddWithValue("@IdNotaDeEntrada", Id);
            var adapter = new SqlDataAdapter(command);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            connection.Close();



            return table.AsEnumerable().ToList();
        }
        private double BuscaEstoqueProduto(long? Id)
        {
            double aux = 0;

            var command1 = new SqlCommand("select Estoque from Produtos where Id = @IdProduto", connection);
            command1.Parameters.AddWithValue("@IdProduto", Id);

            connection.Open();
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    aux = reader.GetDouble(0);
                }
            }
            connection.Close();
            return aux;
        }
        private void UpdateEstoqueProdutos(double qtdProduto, long? Id)
        {
            var command2 = new SqlCommand("update Produtos set Estoque = @aux where Id = @IdProduto", connection);
            command2.Parameters.AddWithValue("@aux", qtdProduto);
            command2.Parameters.AddWithValue("@IdProduto", Id);

            connection.Open();
            command2.ExecuteNonQuery();
            connection.Close();
        }
        private double BuscaEstoqueProdutoPorNota(long? Id)
        {
            double aux = 0;

            var command1 = new SqlCommand("select QuantidadeComprada from ProdutoNotaDeEntrada where Id = @Id", connection);
            command1.Parameters.AddWithValue("@Id", Id);

            connection.Open();
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    aux = reader.GetDouble(0);
                }
            }
            connection.Close();
            return aux;
        }
        private double BuscaEstoqueProdutoPeloIdNota(long? Id)
        {
            double aux = 0;

            var command1 = new SqlCommand("select QuantidadeComprada from ProdutoNotaDeEntrada where IdNotaDeEntrada = @Id", connection);
            command1.Parameters.AddWithValue("@Id", Id);

            connection.Open();
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    aux = reader.GetDouble(0);
                }
            }
            connection.Close();
            return aux;
        }
    }
}
