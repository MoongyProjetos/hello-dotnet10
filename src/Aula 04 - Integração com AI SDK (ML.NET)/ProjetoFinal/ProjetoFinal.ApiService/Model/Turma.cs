namespace ProjetoFinal.ApiService.Model
{
    public class Turma
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? Nome { get; set; }
        /// <summary>
        /// Ano letivo da turma
        /// </summary>
        public int AnoLetivo { get; set; }
        [Required]
        public Professor? Professor { get; set; }
        public List<Aluno>? Alunos { get; set; }

        [Required, Range(1,10)]
        public int AnoDaTurma { get; set; }
    }
}
