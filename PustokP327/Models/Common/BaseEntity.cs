namespace PustokP327.Models.Common
{
    public abstract class BaseEntity 
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual bool isDeleted { get; set; }
    }
}
