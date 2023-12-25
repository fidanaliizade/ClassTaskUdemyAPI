namespace ClassTaskUdemyAPI.Dtos.BaseDtos
{
    public class BaseAudiTableEntityDto:BaseEntityDto
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
