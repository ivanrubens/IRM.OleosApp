namespace IRM.OleosApp.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "OleosApp.kit",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lucro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ordem = c.Int(nullable: false),
                        Componente_Id = c.Guid(),
                        UnidadeMedida_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("OleosApp.produto", t => t.Componente_Id)
                .ForeignKey("OleosApp.unidade_medida", t => t.UnidadeMedida_Id)
                .Index(t => t.Componente_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "OleosApp.produto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FatorConversao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LucroSugerido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorUnitarioFinal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ordem = c.Int(nullable: false),
                        Organizacao_Id = c.Guid(),
                        TipoProduto_Id = c.Guid(),
                        UnidadeMedida_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("OleosApp.organizacao", t => t.Organizacao_Id)
                .ForeignKey("OleosApp.tipo_produto", t => t.TipoProduto_Id)
                .ForeignKey("OleosApp.unidade_medida", t => t.UnidadeMedida_Id)
                .Index(t => t.Organizacao_Id)
                .Index(t => t.TipoProduto_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "OleosApp.organizacao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "OleosApp.tipo_produto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Tipo = c.String(nullable: false, maxLength: 30),
                        Ordem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "OleosApp.unidade_medida",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Ordem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("OleosApp.produto", "UnidadeMedida_Id", "OleosApp.unidade_medida");
            DropForeignKey("OleosApp.kit", "UnidadeMedida_Id", "OleosApp.unidade_medida");
            DropForeignKey("OleosApp.produto", "TipoProduto_Id", "OleosApp.tipo_produto");
            DropForeignKey("OleosApp.produto", "Organizacao_Id", "OleosApp.organizacao");
            DropForeignKey("OleosApp.kit", "Componente_Id", "OleosApp.produto");
            DropIndex("OleosApp.produto", new[] { "UnidadeMedida_Id" });
            DropIndex("OleosApp.produto", new[] { "TipoProduto_Id" });
            DropIndex("OleosApp.produto", new[] { "Organizacao_Id" });
            DropIndex("OleosApp.kit", new[] { "UnidadeMedida_Id" });
            DropIndex("OleosApp.kit", new[] { "Componente_Id" });
            DropTable("OleosApp.unidade_medida");
            DropTable("OleosApp.tipo_produto");
            DropTable("OleosApp.organizacao");
            DropTable("OleosApp.produto");
            DropTable("OleosApp.kit");
        }
    }
}
