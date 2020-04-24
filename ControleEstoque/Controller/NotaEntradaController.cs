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
    public class NotaEntradaController
    {
        private ProdutosNotaEntradaController produtosNotaEntradaController = new ProdutosNotaEntradaController();
        private SqlConnection connection = DbConnection.DB_Connection;

        public void Save(NotaEntrada notaEntrada)
        {
            if (notaEntrada.Id != null)
            {
                this.Update(notaEntrada);
            }
            else
            {
                this.Insert(notaEntrada);
            }
        }
        private void Insert(NotaEntrada nota)
        {
            var command = new SqlCommand("insert into NotaDeEntrada (Numero, IdFornecedor, DataEmissao, DataEntrada) values (@Numero, @IdFornecedor, @DataEmissao, @DataEntrada)", connection);
            command.Parameters.AddWithValue("@Numero", nota.Numero);
            command.Parameters.AddWithValue("@IdFornecedor", nota.FornecedorNota.Id);
            command.Parameters.AddWithValue("@DataEmissao", nota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", nota.DataEntrada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Nota inserida com sucesso!");
        }
        private void Update(NotaEntrada nota)
        {
            var command = new SqlCommand("update NotaDeEntrada set Numero=@Numero, IdFornecedor=@IdFornecedor, DataEmissao=@DataEmissao, DataEntrada=@DataEntrada where Id=@Id", connection);
            command.Parameters.AddWithValue("@Numero", nota.Numero);
            command.Parameters.AddWithValue("@IdFornecedor", nota.FornecedorNota.Id);
            command.Parameters.AddWithValue("@DataEmissao", nota.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", nota.DataEntrada);
            command.Parameters.AddWithValue("@Id", nota.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Nota atualizada com sucesso!");
        }
        public void GetAllNotaEntrada(DataGridView data)
        {
            var adapter = new SqlDataAdapter("select Id, IdFornecedor, Numero, DataEmissao, DataEntrada from NotaDeEntrada", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            data.DataSource = table;
            connection.Close();
            data.ClearSelection();
        }
        public NotaEntrada GetNotaEntradabyId(long? id)
        {
            NotaEntrada nota = new NotaEntrada();
            FornecedorController fornecedorController = new FornecedorController();
            long? IdFornecedorNota = -1;
            var command = new SqlCommand("select Id, IdFornecedor, Numero, DataEmissao, DataEntrada from NotaDeEntrada where id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    nota.Id = reader.GetInt64(0);
                    IdFornecedorNota = reader.GetInt64(1);
                    nota.Numero = reader.GetString(2);
                    nota.DataEmissao = reader.GetDateTime(3);
                    nota.DataEntrada = reader.GetDateTime(4);
                }
            }
            connection.Close();
            if (IdFornecedorNota > 0)
            {
                nota.FornecedorNota = fornecedorController.GetFornecedorById(IdFornecedorNota);
            }
            return nota;
        }
        public void Remove(long? id)
        {
            var command = new SqlCommand("delete from NotaDeEntrada where @Id=Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
