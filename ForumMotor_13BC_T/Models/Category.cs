namespace ForumMotor_13BC_T.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string ForumUserId { get; set; }

        public virtual ForumUser User { get; set; }
        
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
