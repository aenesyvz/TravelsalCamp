using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class About2 : IEntity
    {
        public int About2ID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
