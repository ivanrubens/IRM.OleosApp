namespace IRM.OleosApp.Core.Entities
{
    public class UnidadeMedida
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public ICollection<Kit> Kits { get; set; }

    }
}