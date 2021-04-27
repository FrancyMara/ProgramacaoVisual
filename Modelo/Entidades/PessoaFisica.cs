using System;

namespace Modelo.Entidades
{
    public class PessoaFisica : Pessoa
    {
        //public long IDPessoaFisica { get; set; }

        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }

        public PessoaFisica() { }

        public override bool Equals(object obj)
        {
            // base = Referencia a classe pai (superclasse)
            // this = Referencia a classe atual (subclasse)

            if (obj == null || obj?.GetType() != typeof(PessoaFisica))
                return false;

            var PF = (obj as PessoaFisica);

            return RG.Equals(PF.RG) && CPF.Equals(PF.CPF);
        }

        public override string ToString()
        {
            return $"{Nome}, Rg: {RG}, Cpf: {CPF}";
        }
    }
}