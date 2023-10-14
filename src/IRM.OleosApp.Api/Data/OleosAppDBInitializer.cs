using IRM.OleosApp.Core.Entities;
using System.Data.Entity;

namespace IRM.OleosApp.Api.Data
{
    public class OleosAppDBInitializer : DropCreateDatabaseAlways<OleosAppDBContext>
    {
        protected override void Seed(OleosAppDBContext context)
        {
            IList<TipoProduto> tiposProdutos = new List<TipoProduto>();
            tiposProdutos.Add(new TipoProduto() { Id = Guid.NewGuid(), Nome = "Óleo", Ordem = 1 });
            tiposProdutos.Add(new TipoProduto() { Id = Guid.NewGuid(), Nome = "Frasco Rolon", Ordem = 2 });
            tiposProdutos.Add(new TipoProduto() { Id = Guid.NewGuid(), Nome = "Frasco Blend", Ordem = 3 });
            tiposProdutos.Add(new TipoProduto() { Id = Guid.NewGuid(), Nome = "Base", Ordem = 4 });
            context.TiposProduto.AddRange(tiposProdutos);

            IList<UnidadeMedida> unidadesMedida = new List<UnidadeMedida>();
            unidadesMedida.Add(new UnidadeMedida() { Id = Guid.NewGuid(), Nome = "ML", Ordem = 1 });
            unidadesMedida.Add(new UnidadeMedida() { Id = Guid.NewGuid(), Nome = "UND", Ordem = 2 });
            unidadesMedida.Add(new UnidadeMedida() { Id = Guid.NewGuid(), Nome = "FRASCO", Ordem = 3 });
            unidadesMedida.Add(new UnidadeMedida() { Id = Guid.NewGuid(), Nome = "GOTAS", Ordem = 4 });
            context.UnidadesMedida.AddRange(unidadesMedida);

            IList<Organizacao> organizacao = new List<Organizacao>();
            organizacao.Add(new Organizacao() { Id = Guid.NewGuid(), Nome = "Organização 1" });
            context.Organizacoes.AddRange(organizacao);

            base.Seed(context);
        }
    }
}
