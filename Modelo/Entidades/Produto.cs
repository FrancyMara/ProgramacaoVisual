namespace Modelo.Entidades
{
    public class Produto : ClasseBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal QuantidadeEstoque { get; set; }

        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        
    }
}