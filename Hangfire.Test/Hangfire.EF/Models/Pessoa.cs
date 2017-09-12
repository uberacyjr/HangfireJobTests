using System.ComponentModel.DataAnnotations;

namespace Hangfire.EF.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
