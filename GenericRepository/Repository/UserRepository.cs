using GenericRepository.Context;
using GenericRepository.GenericRepository;

namespace GenericRepository.Repository
{
    public class UserRepository : IRepository<User>,IUserRepository
    {
        
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }

    public  interface IUserRepository
    { }
}
