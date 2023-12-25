using ClassTaskUdemyAPI.Dtos.BaseDtos;
using ClassTaskUdemyAPI.Entities.Common;

namespace ClassTaskUdemyAPI.Entities
{
    public class Category:BaseAudiTableEntity
    {
        public string Title { get; set; }

        public int? ParentId { get; set; }
        public virtual Category? Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
    }
}
