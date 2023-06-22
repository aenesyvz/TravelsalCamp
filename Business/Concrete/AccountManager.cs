using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public void Add(Account account)
        {
            _accountDal.Add(account);
        }

        public void Delete(Account account)
        {
            _accountDal.Delete(account);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public Account GetById(int id)
        {
            return _accountDal.Get(x=> x.AccountID == id);
        }

        public void Update(Account account)
        {
            _accountDal.Update(account);
        }
    }

}
