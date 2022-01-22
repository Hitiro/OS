using Bibliotecas;
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
    public partial class FuncionarioLista : Form
    {
        private BindingList<Funcionario> _funcionarios;
        private Banco _banco;
        public FuncionarioLista()
        {
            InitializeComponent();

            _banco = new Banco();

            _funcionarios = new BindingList<Funcionario>(_banco.Funcionario.ToList());

            funcionarioBindingSource.DataSource = _funcionarios;
        }

        private void bbiNovoAdm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var novo = new FuncionarioAdm();

            var tela = new FuncionarioDetalhe(novo, _banco);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                _funcionarios.Add(novo);
            }
        }



        private void bbiNovoCms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var novo = new FuncionarioComissao();

            var tela = new FuncionarioDetalhe(novo, _banco);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                _funcionarios.Add(novo);
            }
        }

        private void bbiEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editar = funcionarioBindingSource.Current as Funcionario;
            if(editar != null)
            {
                var tela = new FuncionarioDetalhe(editar, _banco);
                tela.ShowDialog();
            }
        }

        private void bbiExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var excluir = funcionarioBindingSource.Current as Funcionario;
            if(excluir != null)
            {
                if (MensagemDlg.Questao("Confirma a Exclução do funcionário " + excluir.Nome + " ?"))
                {
                    _banco.Funcionario.Remove(excluir);
                    _banco.SaveChanges();

                    _funcionarios.Remove(excluir);
                }
            }
        }
    }
}
