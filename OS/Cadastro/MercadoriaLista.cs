using Bibliotecas;
using DevExpress.XtraEditors;
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
    public partial class MercadoriaLista : XtraForm
    {

        private Banco _banco;
        private BindingList<Mercadoria> _mercadorias;

        private Dictionary<Mercadoria, MercadoriaDetalhe> _telasAbertas;


        public MercadoriaLista()
        {
            InitializeComponent();

            _banco = new Banco();

            _mercadorias = new BindingList<Mercadoria>(
                _banco.Mercadoria.Where(mc => mc.Excluido == false).ToList());

            mercadoriaBindingSource.DataSource = _mercadorias;

            _telasAbertas = new Dictionary<Mercadoria, MercadoriaDetalhe>();

            var gridForm = new Form();
            gridForm.Text = "Dados";
            gcMercadoria.Parent = null;
            gridForm.Controls.Add(gcMercadoria);
            gridForm.MdiParent = this;
            gridForm.Show();

            gcMercadoria.Dock = DockStyle.Fill;

        }

        private void bbiNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = new Mercadoria();

            var tela = new MercadoriaDetalhe(_banco, novo, _mercadorias);
            tela.MdiParent = this;
            tela.Show();
            //tela.Text = "Novo";
            _telasAbertas.Add(novo, tela);
            tela.FormClosed += (s, args) => _telasAbertas.Remove(novo);
        }

        private void bbiEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editar = mercadoriaBindingSource.Current as Mercadoria;

            if(editar != null)
            {
                if (_telasAbertas.ContainsKey(editar))
                {
                    _telasAbertas[editar].Activate();
                }
                else
                {
                    var tela = new MercadoriaDetalhe(_banco, editar, _mercadorias);
                    tela.MdiParent = this;
                    tela.Show();
                    // Muda o nome da aba para uso do nome
                    //tela.Text = "Editar - " + editar.Nome;
                    // muda o nome  da aba usando ID
                    //tela.Text = Convert.ToString(editar.ID);

                    _telasAbertas.Add(editar, tela);
                    tela.FormClosed += (s, args) => _telasAbertas.Remove(editar);
                }

            }
        }

        private void bbiExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mercadoria = mercadoriaBindingSource.Current as Mercadoria;
            if(mercadoria != null)
            {
                if(MensagemDlg.Questao("Confirma a exclusão da mercadoria: " + mercadoria.Nome +" ?"))
                {
                    mercadoria.Excluido = true;
                    _banco.SaveChanges();

                    _mercadorias.Remove(mercadoria);

                    if (_telasAbertas.ContainsKey(mercadoria))
                    {
                        _telasAbertas[mercadoria].Close();
                    }
                }
            }
        }
    }
}