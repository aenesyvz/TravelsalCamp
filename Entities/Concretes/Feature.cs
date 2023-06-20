using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Feature:IEntity
    {
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
    public class Feature2 : IEntity
    {
        public int Feature2ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
