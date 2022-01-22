using OS.Cadastro;
using OS.Modelo;
using SysCom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Validador.RegistrarRegras(typeof(Cliente), typeof(ClienteRegras));
            Validador.RegistrarRegras(typeof(Mercadoria), typeof(MercadoriaRegras));
            Validador.RegistrarRegras(typeof(OrdemServico), typeof(OrdemServicoRegras));
            Validador.RegistrarRegras(typeof(FuncionarioAdm), typeof(FuncionarioAdmRegras));
            Validador.RegistrarRegras(typeof(OrdemServicoItem), typeof(OrdemServicoItemRegras));
            Validador.RegistrarRegras(typeof(FuncionarioComissao), typeof(FuncionarioComissaoRegras));

            DevExpress.Skins.SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            //Application.Run(new FuncionarioLista());
        }
    }
}
