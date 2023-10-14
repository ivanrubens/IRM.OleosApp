namespace IRM.OleosApp.Core.Entities
{
    public class TipoProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Ordem { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
