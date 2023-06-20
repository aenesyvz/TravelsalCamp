using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class SubAbout:IEntity
    {
        public int SubAboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
