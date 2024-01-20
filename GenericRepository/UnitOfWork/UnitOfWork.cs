using GenericRepository.Context;
using GenericRepository.GenericRepository;
using GenericRepository.Repository;

namespace GenericRepository.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        UserContext _userContext;

        public IRepository<User>UserRepository { get; private set; }
        public UnitOfWork(UserContext usercontext)
        {
            _userContext = usercontext;
            UserRepository=new Repository<User>(_userContext);
        }

        public int Commit()
        {
          return _userContext.SaveChanges();
        }
    }

    public interface IUnitOfWork
    {
        public int Commit();
    }
}
