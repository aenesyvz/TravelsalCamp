using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfGuideDal : EfEntityRepositoryBase<Guide, Context>, IGuideDal
    {
        public void ChangeToFalseByGuide(int id)
        {
            using (var context = new Context())
            {
                var values = context.Guides.Find(id);
                values.Status = false;
                context.Update(values);
                context.SaveChanges();
            }
            
        }

        public void ChangeToTrueByGuide(int id)
        {
            using (var context = new Context())
            {
                var values = context.Guides.Find(id);
                values.Status = true;
                context.Update(values);
                context.SaveChanges();
            }
         
        }
    }
}
