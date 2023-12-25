using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Entities
{
    public class Category:BaseAudiTableEntityDto
    {
        public string Title { get; set; }
        public int MyProperty { get; set; }

        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
    }
}
