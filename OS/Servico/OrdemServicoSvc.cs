using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS.Servico
{
    public class OrdemServicoSvc
    {
        private Banco _banco;

        public OrdemServicoSvc(Banco banco)
        {
            _banco = banco;
        }

        public void Inserir(OrdemServico os)
        {
            _banco.OrdemServico.Add(os);
            _banco.SaveChanges();
        }

        public bool ChecarEstoque(OrdemServicoItem item)
        {
            var mercadoria = _banco.Mercadoria.Find(item.MercadoriaID);
            if (mercadoria.EhServico)
            {
                return true;
            }

            var qtdeDesejada = item.Qtde;

            return _banco.SpVerificaEstoque(item.MercadoriaID, qtdeDesejada).First().Value;

        }

        public List<Mercadoria> RecuperarMercadorias()
        {
            return _banco.Mercadoria.ToList();
        }

        public List<Cliente> RecuperarClientes()
        {
            return _banco.Cliente.ToList(); 
        }

        public void Atualizar(OrdemServico os)
        {
            _banco.SaveChanges();
        }

        public bool ChecarItem(OrdemServicoItem item)
        {
            var estoqueok = ChecarEstoque(item);

            if (!estoqueok)
            {
                MessageBox.Show("Quantidade em estoue insuficiente");
            }

            return estoqueok;

        }

        public void Recarregar(OrdemServico os)
        {
            _banco.Entry(os).Reload();
        }

        public void AlterarSituacao(OrdemServico os, EOrdemServicoSituacao st)
        {
            switch (st)
            {
                case EOrdemServicoSituacao.Aberto:
                    os.DtFechamento = null;
                    os.Situacao = "A";
                    break;
                case EOrdemServicoSituacao.Cancelado:
                    os.DtFechamento = DateTime.Now;
                    os.Situacao = "C";
                    break;
                case EOrdemServicoSituacao.Fechado:
                    os.DtFechamento = DateTime.Now;
                    os.Situacao = "F";
                    break;
            }

              _banco.SaveChanges();
        }

        public List<OrdemServico> RecuperaTudo()
        {
            return _banco.OrdemServico.ToList();
        }

        public List<OrdemServico> Recupera(EOrdemServicoSituacao st)
        {
            string situacao;
            if (st == EOrdemServicoSituacao.Cancelado)
                situacao = "C";
            else if (st == EOrdemServicoSituacao.Fechado)
                situacao = "F";
            else
                situacao = "A";

            return (
                from os in _banco.OrdemServico
                where os.Situacao == situacao
                select os).ToList();
        }

        public List<OrdemServico> Recupera (String situacao)
        {
            return (
               from os in _banco.OrdemServico
               where os.Situacao == situacao
               select os).ToList();
        }
        //public void Excluir(OrdemServico os)
        //{
        //    _banco.OrdemServico.Remove(os);
        //    _banco.SaveChanges();   
        //}


    }

    public enum EOrdemServicoSituacao
    {
        Aberto,
        Fechado,
        Cancelado
    }
}
