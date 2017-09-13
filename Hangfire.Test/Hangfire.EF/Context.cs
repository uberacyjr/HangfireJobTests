using Hangfire.EF.Models;
using System.Data.Entity;

namespace Hangfire.EF
{
    public class Context : DbContext
    {
        public Context() : base("Hangfire")
        {}
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaUsuario> PessoaUsuario { get; set; }

    }
}
