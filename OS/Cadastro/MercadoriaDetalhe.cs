using Bibliotecas;
using SysCom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OS.Cadastro
{
    public partial class MercadoriaDetalhe : Form
    {
        private Banco _banco;
        private Mercadoria _mercadoria;

        private BindingList<Representante> _representante;

        private BindingList<Mercadoria> _mercadorias;

        public MercadoriaDetalhe(Banco banco, Mercadoria mercadoria, BindingList<Mercadoria> mercadorias)
        {
            InitializeComponent();

            _banco = banco;
            _mercadoria = mercadoria;
            _mercadorias = mercadorias;

            _representante = new BindingList<Representante>();

            mercadoriaBindingSource.DataSource = _mercadoria;
            fornecedorBindingSource.DataSource = _banco.Fornecedor.ToArray();
            representanteBindingSource.DataSource = _representante;


        }

        private void lukFornecedor_EditValueChanged(object sender, EventArgs e)
        {
            var fornecedorID = lukFornecedor.EditValue;
            if(fornecedorID != null)
            {
                var forPk = (int) fornecedorID;
                var reps = _banco.Representante.Where(rp => rp.FornecedorID == forPk);

                //var reps = from rp in _banco.Representante
                //where rp.FornecedorID == forPk
                //select rp;

                foreach (var rp in reps)
                {
                    _representante.Add(rp);
                }
                
            }
        }

        private void bbiSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validador.EhValido(_mercadoria))
            {
                if (_mercadoria.ID == 0)  // Identifica uma nova mercadoria
                {
                    _banco.Mercadoria.Add(_mercadoria); // Sinaliza ao banco a necessidade de insert.

                    _mercadorias.Add(_mercadoria);
                }

                _banco.SaveChanges();

                _mercadorias.ResetBindings();

                MensagemDlg.Info("Salvo com Sucesso");
                
                
                //
                //// Usa-se o Try catch afim de verificar o erro !!
                //try
                //{
                //    _banco.SaveChanges();
                //}
                //catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                //{
                //    MessageBox.Show(
                //        ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage);
                //    throw;
                //}
            }
        }

        private void bbiFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Close();
        }

        private void mercadoriaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mercadoria = mercadoriaBindingSource.Current as Mercadoria;

            if (mercadoria == null)
            {
                Text = "[Sem Mercadoria]";
            }
            else
            {
                string nome;
                if (String.IsNullOrEmpty(mercadoria.Nome))
                    nome = "...";
                else
                    nome = mercadoria.Nome;


                nome = nome.Substring(0, Math.Min(nome.Length, 10));
                if (mercadoria.ID == 0)
                {
                    Text = "[Novo]" + nome;
                }
                else
                {
                    Text = String.Format("{0} - {1}", mercadoria.ID, nome);
                }
            }
        }

    }
}
