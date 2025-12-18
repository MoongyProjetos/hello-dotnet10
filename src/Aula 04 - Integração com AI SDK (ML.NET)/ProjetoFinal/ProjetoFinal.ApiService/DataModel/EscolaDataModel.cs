namespace ProjetoFinal.ApiService.DataModel
{
    public abstract class EscolaDataModel<T> where T : class
    {
        public List<T> ObterTodos()
        {
            var dbContext = new EscolaDBContext();
            return dbContext.Set<T>().ToList();
        }

        public void Adicionar(T entidade)
        {
            var dbContext = new EscolaDBContext();
            dbContext.Set<T>().Add(entidade);
            dbContext.SaveChanges();
        }

        public T? ObterPorId(params object[] keyValues)
        {
            var dbContext = new EscolaDBContext();
            return dbContext.Set<T>().Find(keyValues);
        }

        public void Atualizar(T entidade)
        {
            var dbContext = new EscolaDBContext();
            dbContext.Set<T>().Update(entidade);
            dbContext.SaveChanges();
        }

        public void Remover(params object[] keyValues)
        {
            var dbContext = new EscolaDBContext();
            var entidade = dbContext.Set<T>().Find(keyValues);
            if (entidade != null)
            {
                dbContext.Set<T>().Remove(entidade);
                dbContext.SaveChanges();
            }
        }
    }
}
