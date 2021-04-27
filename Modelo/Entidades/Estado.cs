namespace Modelo.Entidades
{
    public class Estado
    {
        public long IDEstado { get; set; }
        public string Descricao { get; set; }
        public string UF { get; set; }

        public Estado() { }

        public Estado(long IDEstado, string Descricao, string UF) 
        {
            this.IDEstado = IDEstado;
            this.Descricao = Descricao;
            this.UF = UF;        
        }
    }
}