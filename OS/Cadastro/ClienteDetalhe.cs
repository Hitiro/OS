using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SysCom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            if (Validador.EhValido(_cliente))
            {
                _salvar = true;

                Close();
            }
            

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

        private void CepButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var cep = CepButtonEdit.EditValue as String;

            if(cep == null || cep.Length != 8)
            {
                return;
            }

            try
            {
                using (var web = new WebClient())
                {
                    web.Encoding = Encoding.UTF8;

                    var json = web.DownloadString("http://correiosapi.apphb.com/cep/" + cep);

                    var obj = JObject.Parse(json);

                    _cliente.CEP = cep;

                    _cliente.Logradouro = String.Format(
                        "{0} {1}",
                        obj.Value<string>("tipoDeLogradouro"),
                        obj.Value<string>("logradouro"));
                    _cliente.Cidade = obj.Value<string>("cidade");
                    _cliente.UF = obj.Value<string>("estado");

                    clienteBindingSource.ResetCurrentItem();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar obter o CEP");

            }

        }

        private string _cep;

        private void CepButtonEdit_Enter(object sender, EventArgs e)
        {
            _cep = _cliente.CEP;
        }

        private void CepButtonEdit_Leave(object sender, EventArgs e)
        {
            if (_cliente.CEP != _cep) 
            {
                CepButtonEdit_ButtonClick(null, null);
            }
        }
    }
}
