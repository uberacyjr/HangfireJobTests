using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hangfire.EF.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public PessoaUsuario Usuario { get; set; }
        public ICollection<PessoaEmails> Emails { get; set; }
    }

    public class PessoaUsuario
    {
        [Key]
        [ForeignKey("Pessoa")]
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public Pessoa Pessoa { get; set; }
    }
    public class PessoaEmails
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
