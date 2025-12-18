namespace ProjetoFinal.ApiService.Model
{
    public class Aluno : Pessoa
    {
        [Required, MaxLength(20)]
        public string? Matricula { get; set; }

        [Required]
        public DateTime DataMatricula { get; set; }
    }
}
