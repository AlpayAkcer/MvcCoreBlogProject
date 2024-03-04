using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreBlogProject.EntityLayer.Concrete
{
    public class About
    {
        //Blog hakkında kısmı bilgileri
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
