using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Entities
{
    public class Course:BaseAudiTableEntityDto
    {
        public string Title { get; set; }
        public string  Description { get; set; }
        public int TaecherId { get; set; }
        public List<StudentsCourses> StudentsCourses { get; set; }
    }
}
