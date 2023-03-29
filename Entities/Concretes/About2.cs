using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class About2 : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
