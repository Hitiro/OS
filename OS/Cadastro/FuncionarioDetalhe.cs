using DevExpress.XtraLayout.Utils;
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
    public partial class FuncionarioDetalhe : Form
    {
        private Funcionario _funcionario;
        private Banco _banco;

        public FuncionarioDetalhe(Funcionario funcionario, Banco banco)
        {
            InitializeComponent();

            _funcionario = funcionario;
            _banco = banco;

            funcionarioBindingSource.DataSource = funcionario;

            if (funcionario is FuncionarioAdm)
            {
                funcionarioAdmBindingSource.DataSource = funcionario;
                layComissionado.Visibility = LayoutVisibility.Never; 
            }

            else
            {
                funcionarioComissaoBindingSource.DataSource = funcionario;
                layAdministrativo.Visibility = LayoutVisibility.Never;
            }
                

        }

        private void bbiSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validador.EhValido(_funcionario))
            {
                if (_funcionario.ID == 0)
                {
                    _banco.Funcionario.Add(_funcionario);
                }

                _banco.SaveChanges();

                DialogResult = DialogResult.OK;
            }
            
        }

        private void bbiFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_funcionario.ID != 0)
            {
                _banco.Entry(_funcionario).Reload();

                // Outra forma de recaregar as infomrações do banco.
                // var entrada = _banco.Entry(_funcionario);
                // entrada.CurrentValues.SetValues(entrada.OriginalValues);
            }

            DialogResult = DialogResult.Cancel;
        }
    }
}