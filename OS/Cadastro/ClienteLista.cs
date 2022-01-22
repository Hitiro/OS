using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using OS.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS.Cadastro
{
    public partial class ClienteLista : XtraForm
    {
        Banco _banco;
        BindingList<Cliente> _clientes;

        public ClienteLista()
        {
            InitializeComponent();

            _banco = new OS.Banco();
            _clientes = new BindingList<Cliente>(_banco.Cliente.ToList());

            clienteBindingSource.DataSource = _clientes;

        }

        private void bbiNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = new Cliente
            {
                Documento = String.Empty,
                Telefone1 = String.Empty,
                Telefone2 = String.Empty
            };

            var telaDetalhe = new ClienteDetalhe(novo);
            var salvar = telaDetalhe.Executar();

            if(salvar == true)
            {
                _banco.Cliente.Add(novo);
                _banco.SaveChanges();

                _clientes.Add(novo);
            }
        }

        private void bbiEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editar = clienteBindingSource.Current as Cliente;
            var telaDetalhe = new ClienteDetalhe(editar);
            var salvar = telaDetalhe.Executar();

            if(salvar == true)
            {
                _banco.SaveChanges();
            }
            else
            {
                // Reverter as Alterações ?
                var registro = _banco.Entry(editar);
                registro.CurrentValues.SetValues(registro.OriginalValues);
            }

        }

        private void bbiExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var excluir = (Cliente)gvClientes.GetFocusedRow();

            var salvar = MessageBox.Show("Confirma Exclução?", "Excluindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if(salvar == true)
            {
                _banco.Cliente.Remove(excluir);
                _banco.SaveChanges();

                _clientes.Remove(excluir);
            }

        }

        private void gcClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var info = gvClientes.CalcHitInfo(e.Location);

            if (info.InRow)
            {
                bbiEditar.PerformClick();
            }
        }

        private void bbiListar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var relatorio = new ClienteListaTemplate();
            relatorio.DataSource = _clientes;

            relatorio.ShowRibbonPreviewDialog();
        }
    }
}