using System.ComponentModel.DataAnnotations;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class Blog
    {
        //Blog içerik bilgileri
        [Key]
        public int BlogID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public int TopViewCount { get; set; }
        public bool IsStatus { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
