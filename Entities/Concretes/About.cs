using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class About: IEntity
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public bool Status { get; set; }
    }
}
