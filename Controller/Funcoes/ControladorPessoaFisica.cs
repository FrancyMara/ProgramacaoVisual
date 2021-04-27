using Controller.Interfaces;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller.Funcoes
{
    public class ControladorPessoaFisica : DAO.DB.Controller, IControllerPessoaFisica
    {
        public ControladorPessoaFisica(List<object> BD)
        {
            Objetos = BD;
        }

        public ControladorPessoaFisica()
        {
            Objetos = new List<object>();
        }

        public PessoaFisica GetPessoaFisica(string CPF)
        {
            if (string.IsNullOrEmpty(CPF))
                return null;

            foreach (object o in Objetos)
            {
                PessoaFisica p = o as PessoaFisica;
                if (p.CPF.Equals(CPF))
                    return p;
            }

            return null;
        }

        public List<PessoaFisica> GetPessoas()
        {
            List<PessoaFisica> Pessoas = new List<PessoaFisica>();
            if (Objetos == null)
                return null;

            for (int i = 0; i < Objetos.Count; i++)
                Pessoas.Add(Objetos[i] as PessoaFisica);

            return Pessoas;
        }

        // returna Boolean (True ou False)
        public bool Remover(PessoaFisica PF)
        {
            if (PF == null)
                return false;

            Objetos.Remove(PF);

            return true;
        }

        public bool Salvar(PessoaFisica PF, bool Editando)
        {
            if (PF == null)
                return false;

            if (Editando)
                for (int i = 0; i < Objetos.Count; i++)
                {
                    if (Objetos[i].Equals(PF))
                        Objetos[i] = PF;
                }
            else
                Objetos.Add(PF);

            return true;
        }
    }
}
