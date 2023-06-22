using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser appUser)
        {
            _appUserDal.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _appUserDal.Delete(appUser);
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _appUserDal.Get(x => x.Id == id);
        }

        public void Update(AppUser appUser)
        {
           _appUserDal.Update(appUser);
        }
    }

}
