using ProjetoFinal.ApiService.Model;

namespace ProjetoFinal.ApiService.DataModel
{
    public class EscolaDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EscolaDB;Trusted_Connection=True;");

            optionsBuilder.UseSqlServer("Server=tcp:moongyexemplo.database.windows.net,1433;Initial Catalog=sqldb-escoladb;Persist Security Info=False;User ID=exemplo;Password=abc,1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
    }
}
