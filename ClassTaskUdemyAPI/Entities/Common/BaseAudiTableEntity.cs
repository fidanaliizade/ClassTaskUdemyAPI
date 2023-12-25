namespace ClassTaskUdemyAPI.Entities.Common
{
    public class BaseAudiTableEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
