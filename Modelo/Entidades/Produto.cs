namespace Modelo.Entidades
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {
        }

        public Produto(long Codigo, string Nome, decimal Preco)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}