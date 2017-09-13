namespace Hangfire.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.PessoaUsuarios",
                c => new
                    {
                        CodigoUsuario = c.Int(nullable: false),
                        NomeUsuario = c.String(),
                    })
                .PrimaryKey(t => t.CodigoUsuario)
                .ForeignKey("dbo.Pessoas", t => t.CodigoUsuario)
                .Index(t => t.CodigoUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaUsuarios", "CodigoUsuario", "dbo.Pessoas");
            DropIndex("dbo.PessoaUsuarios", new[] { "CodigoUsuario" });
            DropTable("dbo.PessoaUsuarios");
            DropTable("dbo.Pessoas");
        }
    }
}
