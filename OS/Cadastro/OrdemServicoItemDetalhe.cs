using OS.Servico;
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
    public partial class OrdemServicoItemDetalhe : Form
    {
        private OrdemServicoSvc _svc;
        private OrdemServicoItem _item;
        
        private bool _salvar;

        public OrdemServicoItemDetalhe(OrdemServicoSvc svc, OrdemServicoItem item)
        {
            InitializeComponent();

            _svc = svc;

            var mercadorias = _svc.RecuperarMercadorias();
            mercadoriaBindingSource.DataSource = mercadorias;

            _item = item;
            ordemServicoItemBindingSource.DataSource = _item;
        }

        private void bbiFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (_svc.ChecarItem(_item))
            {
                _salvar = true;

                Close();
            }
            
        }

        public bool Executar()
        {
            ShowDialog();

            return _salvar;
        }

        private void MercadoriaIDTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var mercadoria = MercadoriaIDTextEdit.GetSelectedDataRow() as Mercadoria;

            if (mercadoria == null)
            {
                return;
            }

            _item.Mercadoria = mercadoria;
            _item.Preco = mercadoria.Preco;

            //ordemServicoItemBindingSource.ResetCurrentItem();
        }
    }
}
