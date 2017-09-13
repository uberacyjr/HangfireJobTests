namespace Hangfire.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PessoaEmails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaEmails",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Pessoa_Codigo = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Codigo)
                .Index(t => t.Pessoa_Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaEmails", "Pessoa_Codigo", "dbo.Pessoas");
            DropIndex("dbo.PessoaEmails", new[] { "Pessoa_Codigo" });
            DropTable("dbo.PessoaEmails");
        }
    }
}
