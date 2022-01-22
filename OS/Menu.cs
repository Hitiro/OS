using DevExpress.XtraEditors;
using OS.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Menu : XtraForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tliCliente_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var tela = new ClienteLista();
            tela.ShowDialog();
        }

        private void tliOS_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var tela = new OrdemServicoLista();
            tela.ShowDialog();
        }

        private MercadoriaLista _mercadoriaLista;
        private void tliMercadoria_ItemClick(object sender, TileItemEventArgs e)
        {
            if (_mercadoriaLista == null)
            {
                _mercadoriaLista = new MercadoriaLista();
                _mercadoriaLista.FormClosed += (s, args) => _mercadoriaLista = null;
            }

            _mercadoriaLista.Show();
            _mercadoriaLista.Activate();

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            var tela = new FuncionarioLista();
            tela.ShowDialog();
        }
    }
}
