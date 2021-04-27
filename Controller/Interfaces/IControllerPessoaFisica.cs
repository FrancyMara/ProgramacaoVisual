using Modelo.Entidades;
using System.Collections.Generic;

namespace Controller.Interfaces
{
    public interface IControllerPessoaFisica
    {
        bool Salvar(PessoaFisica PF, bool Editando);
        bool Remover(PessoaFisica PF);
        List<PessoaFisica> GetPessoas();
        PessoaFisica GetPessoaFisica(string CPF);
    }
}