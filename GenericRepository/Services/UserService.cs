using GenericRepository.Context;
using GenericRepository.GenericRepository;

namespace GenericRepository.Services
{
    
    public class UserService:IUserService
    {
        public IRepository<User> _repository { get; set; }
        public UserService(IRepository<User> repository) 
        {
            _repository = repository;
        }

        public void AddUser(User user)
        {
            _repository.Add(user);  
        }


    }

    public interface IUserService 
    {
        public void AddUser(User user);
        
    }
}
