using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class AnaliseVendasReport : Form
    {
        public AnaliseVendasReport()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            /*
             * 1 - Conectar 
             *        SqlConnection
             * 2 - Criar um comando 
             *        conexao.CreateCommand()
             * 3 - Definir o comando (SELECT, INSERT ou  EXEC PROC)  
             *        comando.ComandText = "Alguma Coisa"
             * 4 - Executar Comando 
             *        comando.ExecuteQuery ()
             * 5 - Fechar a Coexão 
             *        conexao.Close
             * 6 - Processar o Resultado 
             *        foreach(dados){ }
             */

            var conexao = new SqlConnection();
            conexao.ConnectionString = "Server=NB-HITIRO\\SQLEXPRESS;Database=OS;Integrated Security=True";
            conexao.Open();

            var cmd = conexao.CreateCommand();
            cmd.CommandText = "dbo.SpAnaliseVendasReport";
            cmd.CommandType = CommandType.StoredProcedure;

            var adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;

            var dados = new DataTable();
            adaptador.Fill(dados);

            conexao.Close();

            pgcItens.DataSource = dados;
            pgcItens.RetrieveFields();

        }
    }
}
