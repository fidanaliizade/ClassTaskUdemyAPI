using ClassTaskUdemyAPI.Dtos.BaseDtos;
using ClassTaskUdemyAPI.Entities.Common;

namespace ClassTaskUdemyAPI.Entities
{
    public class Course:BaseAudiTableEntity
    {
        public string Title { get; set; }
        public string  Description { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<StudentsCourses> StudentsCourses { get; set; }
    }
}
