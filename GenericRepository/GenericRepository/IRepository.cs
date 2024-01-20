namespace GenericRepository.GenericRepository
{
    public interface IRepository<TEntity> 
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);   
        void Remove (TEntity entity);   
        void Update(TEntity entity);    

    }
}
