using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Account:IEntity
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
