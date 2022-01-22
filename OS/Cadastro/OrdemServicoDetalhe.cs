using OS.Servico;
using SysCom;
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
    public partial class OrdemServicoDetalhe : Form
    {
        private OrdemServicoSvc _svc;
        private bool _salvar;

        private OrdemServico _os;
        private BindingList<OrdemServicoItem> _osItens;
        private OrdemServicoLista _gestao;

        public OrdemServicoDetalhe(OrdemServicoSvc svc, OrdemServico os, OrdemServicoLista gestao)
        {
            InitializeComponent();

            _gestao = gestao;
            _svc = svc;

            _os = os;
            ordemServicoBindingSource.DataSource = os;
            
            var clientes = _svc.RecuperarClientes();
            clienteBindingSource.DataSource = clientes;

            var itens = os.OrdemServicoItem.ToList();
            _osItens = new BindingList<OrdemServicoItem>(itens);
            ordemServicoItemBindingSource.DataSource = _osItens;

            ConfigurarUI();

        }

        private void ConfigurarUI()
        {
            var habilitado = _os.Situacao == "A";

            bbiSalvar.Enabled = habilitado;
            bbiAdicionar.Enabled = habilitado;
            bbiEditar.Enabled = habilitado;
            bbiExcluir.Enabled = habilitado;
            ClienteIDTextEdit.Enabled = habilitado;
            DtAberturaDateEdit.Enabled = habilitado;
            ObservacaoMemoEdit.Enabled = habilitado;
        }

        private void bbiFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _salvar = false;
            Close();
        }

        private void bbiSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (_svc.ChecarOS(_os, _osItens))
            {
                if (_os.ID == 0)
                {
                    _svc.MesclarMemoriaDB(_os, _osItens);
                    _svc.Inserir(_os);
                    _gestao.InserirGrid(_os);
                    
                }
                else
                {
                    _svc.MesclarMemoriaDB(_os, _osItens);

                    _svc.Atualizar(_os);
                }
                
                Close();
            }
           
        }

        public bool Executar()
        {
            Show();

            return _salvar;
        }

        private void bbiAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = new OrdemServicoItem();

            var detalhe = new OrdemServicoItemDetalhe(_svc, novo);
            var salvar = detalhe.Executar();

            if (salvar == true)
            {
                _osItens.Add(novo);
            }
        }

        private void bbiEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editar = ordemServicoItemBindingSource.Current as OrdemServicoItem;

            var detalhe = new OrdemServicoItemDetalhe(_svc, editar);
            var salvar = detalhe.Executar();

        }

        private void bbiExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var excluir = ordemServicoItemBindingSource.Current as OrdemServicoItem;
            
            var msg = $"Confirma a exclusão do item '{excluir.Mercadoria.Nome}'";
            
            var confirmado = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmado == DialogResult.Yes)
            {
                _osItens.Remove(excluir);
            }
        }

    }
}
