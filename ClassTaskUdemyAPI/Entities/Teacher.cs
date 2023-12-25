using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Entities
{
    public class Teacher:BaseAudiTableEntityDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }
}
