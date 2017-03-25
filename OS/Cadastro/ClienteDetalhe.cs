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
    public partial class ClienteDetalhe : Form
    {

        Cliente _cliente;
        bool _salvar;

        public ClienteDetalhe(Cliente cliente)
        {
            InitializeComponent();

            _cliente = cliente;
            clienteBindingSource.DataSource = cliente;

            

        }

        private void bbiSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _salvar = true;
            Close();
        }

        private void bbiFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        public bool Executar()
        {
            ShowDialog();
            return _salvar;
        }

        private void clienteBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var atual = clienteBindingSource.Current as Cliente;

            ItemForDocuemtno.Text = atual.EhFisico ? "Cpf" : "Cnpj";
            DocuemtnoTextEdit.Properties.Mask.EditMask = atual.EhFisico ? "000.000.000-00" : "00.000.000/0000-00";

        }
    }
}
