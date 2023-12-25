using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Entities
{
    public class Student:BaseAudiTableEntityDto
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }
        public List<StudentsCourses> StudentsCourses { get; set; }
    }
}
