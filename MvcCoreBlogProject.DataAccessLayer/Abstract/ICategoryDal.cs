using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        //Kategorilerin toplamını almak için gerekli method
        //Buraya entitye özgü bir çok method yazılabilir. 
        // Kategorilere bağlı blog yazılarının toplamı gibi,
        // En çok görüntülenen blog yazıları gibi,
        // En çok yorum yapılan bloglarlar gibi.
        int CategoryByCount();
    }
}
