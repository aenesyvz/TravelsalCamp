using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Announcement:IEntity
    {
        public int AnnouncementID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
