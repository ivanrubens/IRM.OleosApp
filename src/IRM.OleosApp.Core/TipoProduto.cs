namespace IRM.OleosApp.Core
{
    public class TipoProduto
    {
        public Guid Id { get; set; }
        public Organizacao Organizacao { get; set; }
        public string Nome { get; set; }
        public bool OleoEssencial { get; set; }
        public bool Embalagem { get; set; }
        public bool Base { get; set; }
        public int Ordem { get; set; }
    }
}
