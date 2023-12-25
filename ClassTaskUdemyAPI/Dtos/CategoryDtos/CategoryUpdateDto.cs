using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Dtos.CategoryDtos
{
    public class CategoryUpdateDto:BaseEntityDto
    {
        public string Title { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
