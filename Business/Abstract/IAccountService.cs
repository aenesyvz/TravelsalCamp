using Entities.Concretes;

namespace Business.Abstract
{
    public interface IAccountService
    {
        void Add(Account account);
        void Update(Account account);
        void Delete(Account account);
        List<Account> GetAll();
        Account GetById(int id);
    }
}
