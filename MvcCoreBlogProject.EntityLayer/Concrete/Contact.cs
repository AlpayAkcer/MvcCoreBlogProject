using System.ComponentModel.DataAnnotations;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class Contact
    {
        //İletişim Formu Bilgileri
        [Key]
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsStatus { get; set; }
    }
}
