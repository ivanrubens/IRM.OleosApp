namespace IRM.OleosApp.Core.Entities
{
    public class Kit
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Produto Componente { get; set; }
        public Decimal Quantidade { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public decimal Lucro { get; set; }
        public decimal Valor { get; set; }
        public int Ordem { get; set; }

    }
}
