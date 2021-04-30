using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes
{
    public class ControladorPagamento : DAO.DB.Controller, IControllerPagamento
    {

        public ControladorPagamento (List<object> pagamento)
        {
            Objetos = pagamento;
        }


        public List<Pagamento> GetPagamento()
        {
            List<Pagamento> pagamento = new List<Pagamento>();

            foreach (var forn in Objetos)
            {
                pagamento.Add(forn as Pagamento);
            }

            return pagamento;
        }

        public Pagamento GetPagamento(string FormaPagamento)
        {
            foreach (var pag in Objetos)
            {
                var pagamento = (pag as Pagamento);

                if (pagamento.FormaPagamento.Equals(FormaPagamento)) return pagamento;
            }

            return null;
        }



        public bool Remover(Pagamento pagamento)
        {
            foreach(var pag in Objetos)
            {
                var temp = (pag as Pagamento);

                if (temp == pagamento)
                {
                    Objetos.Remove(pagamento);
                    return true;
                }

            }

            return false;
        }

        public bool Salvar(Pagamento pagamento, bool Editando)
        {
            if (pagamento == null)
                return false;

            if (Editando)
                for (int i = 0; i < Objetos.Count; i++)
                {
                    if (Objetos[i].Equals(pagamento))
                        Objetos[i] = pagamento;
                }
            else
                Objetos.Add(pagamento);

            return true;
        }
    }
}
