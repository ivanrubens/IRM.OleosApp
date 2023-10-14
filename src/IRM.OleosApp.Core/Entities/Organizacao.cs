namespace IRM.OleosApp.Core.Entities
{
    public class Organizacao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set;}
    }
}
