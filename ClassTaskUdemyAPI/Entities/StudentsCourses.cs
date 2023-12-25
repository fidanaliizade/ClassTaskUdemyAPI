using ClassTaskUdemyAPI.Dtos.BaseDtos;
using ClassTaskUdemyAPI.Entities.Common;

namespace ClassTaskUdemyAPI.Entities
{
    public class StudentsCourses:BaseAudiTableEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
