using System.ComponentModel.DataAnnotations;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class Author
    {
        //Yazar Bilgileri
        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public bool IsStatus { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
