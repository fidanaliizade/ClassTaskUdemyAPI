using ClassTaskUdemyAPI.Dtos.BaseDtos;
using ClassTaskUdemyAPI.Entities.Common;

namespace ClassTaskUdemyAPI.Entities
{
    public class Teacher:BaseAudiTableEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }
}
