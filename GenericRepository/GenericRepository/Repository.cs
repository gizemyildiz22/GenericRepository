using GenericRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity>where TEntity : class
    {
        public UserContext _context {  get; set; }

        private DbSet<TEntity> _dbset { get; set; }
        public Repository(UserContext context) 
        {
            _context = context; 
            _dbset = _context.Set<TEntity>();
            
        } 
        public void Add(TEntity entity)
        {
            //_context.Set<TEntity>().Add(entity);
            _context.Add(entity);
            _context.SaveChanges();

        }

        public IEnumerable<TEntity> GetAll()
        {
          //return  _context.Set<TEntity>().AsEnumerable();    
          return _dbset.AsEnumerable();
        }

        public TEntity GetById(int id)
        {
          return  _dbset.Find(id);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
        }
    }
}
