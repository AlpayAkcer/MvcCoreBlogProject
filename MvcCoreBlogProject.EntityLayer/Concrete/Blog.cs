using System.ComponentModel.DataAnnotations;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class Blog
    {
        //Blog içerik bilgileri
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
