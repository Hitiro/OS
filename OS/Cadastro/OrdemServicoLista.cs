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
using DevExpress.XtraReports.UI;
using OS.Servico;

namespace OS.Cadastro
{
    public partial class OrdemServicoLista : Form
    {
        private OrdemServicoSvc _svc;
        private BindingList<OrdemServico> _itens;

        public OrdemServicoLista()
        {
            InitializeComponent();
            var banco = new Banco();
            _svc = new OrdemServicoSvc(banco);
            _itens = new BindingList<OrdemServico>();
            ordemServicoBindingSource.DataSource = _itens;
            btnAplicar_Click(null, null);

        }

        private void bbiNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = new OrdemServico();
            novo.DtAbertura = DateTime.Now;
            novo.Situacao = "A";

            var detalhe = new OrdemServicoDetalhe(_svc, novo, this);
            var salvar = detalhe.Executar();

           
        }

        private Dictionary<OrdemServico, OrdemServicoDetalhe> _emEdicao = new Dictionary<OrdemServico, OrdemServicoDetalhe>();

        private void bbiEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editar = ordemServicoBindingSource.Current as OrdemServico;
            if (_emEdicao.ContainsKey(editar))
            {
                _emEdicao[editar].Activate();
            }
            else
            {
                var detalhe = new OrdemServicoDetalhe(_svc, editar, this);
                detalhe.Executar();

                _emEdicao.Add(editar, detalhe);

                detalhe.FormClosed += (s, args) => _emEdicao.Remove(editar);
            }
            
        }

        private void bbiExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var situacao = (string) icbSituacao.EditValue;

            List<OrdemServico> ordens;

            if (situacao == "T")
            {
                ordens = _svc.RecuperaTudo();
            }
            else
            {
                ordens = _svc.Recupera(situacao);                                 
            }

            _itens.Clear();
            foreach (var os in ordens)
                _itens.Add(os);
        }

        internal void InserirGrid(OrdemServico os)
        {
            _itens.Add(os);
        }

        private void bbiFinalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var os = ordemServicoBindingSource.Current as OrdemServico;

            _svc.AlterarSituacao(os, EOrdemServicoSituacao.Fechado);

            btnAplicar.PerformClick();

        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var os = ordemServicoBindingSource.Current as OrdemServico;

            _svc.AlterarSituacao(os, EOrdemServicoSituacao.Cancelado);

            btnAplicar.PerformClick();
        }

        private void bbiReabrir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var os = ordemServicoBindingSource.Current as OrdemServico;

            _svc.AlterarSituacao(os, EOrdemServicoSituacao.Aberto);

            btnAplicar.PerformClick();
        }

        private void ordemServicoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var os = ordemServicoBindingSource.Current as OrdemServico;

            if (os == null)
            {
                bbiEditar.Enabled = false;
                bbiExcluir.Enabled = false;
                bbiReabrir.Enabled = false;
                bbiCancelar.Enabled = false;
                bbiFinalizar.Enabled = false;

                return;
            }

            bbiEditar.Enabled = true;
            bbiExcluir.Enabled = true;

            var aberta = os.Situacao == "A";
            var fechada = os.Situacao == "F";

            bbiReabrir.Enabled = fechada || !aberta;
            bbiFinalizar.Enabled = aberta;
            bbiCancelar.Enabled = !aberta && !fechada;


        }

        private void bbiPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var os = ordemServicoBindingSource.Current as OrdemServico;

            var preview = new OSPreviewTemplate();
            preview.DataSource = new List<OrdemServico> { os };

            preview.ShowRibbonPreviewDialog();
        }
    }
}
