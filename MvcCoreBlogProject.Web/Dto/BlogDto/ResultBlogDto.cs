using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.Web.Dto.BlogDto
{
    public class ResultBlogDto
    {
        public int BlogID { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public int TopViewCount { get; set; }
        public bool IsStatus { get; set; }
        public string CategoryName { get; set; }
    }
}
