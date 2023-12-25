using ClassTaskUdemyAPI.Dtos.BaseDtos;

namespace ClassTaskUdemyAPI.Dtos.CategoryDtos
{
    public class CategoryGetDto:BaseAudiTableEntityDto
    {
        public string Title { get; set; }
        public int ParentCategoryId { get; set; }
}
}
