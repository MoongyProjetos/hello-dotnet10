namespace ProjetoFinal.ApiService.Model
{
    public class Professor : Pessoa
    {
        [Required, MaxLength(20)]
        public string? RegistroProfissional { get; set; }
        [Required]
        public DateTime DataAdmissao { get; set; }
    }
}
