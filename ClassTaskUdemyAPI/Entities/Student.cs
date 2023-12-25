using ClassTaskUdemyAPI.Dtos.BaseDtos;
using ClassTaskUdemyAPI.Entities.Common;

namespace ClassTaskUdemyAPI.Entities
{
    public class Student:BaseAudiTableEntity
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }
        public List<StudentsCourses> StudentsCourses { get; set; }
    }
}
