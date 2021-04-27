namespace Modelo.Entidades
{
    public class Endereco
    {
        public int IDEndereco { get; set; }

        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }

        public Municipio Cidade { get; set; }

        public Endereco() { }
    }
}
