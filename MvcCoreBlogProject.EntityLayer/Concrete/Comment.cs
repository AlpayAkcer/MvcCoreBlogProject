using System.ComponentModel.DataAnnotations;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class Comment
    {
        //Yorumların Bilgileri
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsStatus { get; set; }
    }
}
