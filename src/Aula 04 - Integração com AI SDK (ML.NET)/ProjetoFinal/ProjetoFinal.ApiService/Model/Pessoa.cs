using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.ApiService.Model
{
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string? Nome { get; set; }

        [Required, MaxLength(300)]
        public string? Endereco { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public Sexo Sexo { get; set; }
    }
}
