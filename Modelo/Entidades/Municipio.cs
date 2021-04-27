namespace Modelo.Entidades
{
    public class Municipio
    {
        public long IDMunicipio { get; set; }

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Estado UF { get; set; }

        public Municipio() { }

        public Municipio(long IDMunicipio, int Codigo, string Descricao, Estado UF)
        {
            this.IDMunicipio = IDMunicipio;
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.UF = UF;
        }
    }
}
