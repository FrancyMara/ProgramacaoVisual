namespace Modelo.Entidades
{
    public class Produto 

    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string QuantidadeEstoque { get; set; }

        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        
    }
}