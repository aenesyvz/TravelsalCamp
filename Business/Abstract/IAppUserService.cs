using Entities.Concretes;

namespace Business.Abstract
{
    public interface IAppUserService
    {
        void Add(AppUser appUser);
        void Update(AppUser appUser);
        void Delete(AppUser appUser);
        List<AppUser> GetAll();
        AppUser GetById(int id);
    }
}
