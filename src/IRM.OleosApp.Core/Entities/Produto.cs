namespace IRM.OleosApp.Core.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public Organizacao Organizacao { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public string Nome { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Decimal Valor { get; set; }
        public Decimal FatorConversao { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal LucroSugerido { get; set; }
        public Decimal ValorUnitarioFinal { get; set; }
        public int Ordem { get; set; }
        public ICollection<Kit> Kits { get; set; }

    }
}
