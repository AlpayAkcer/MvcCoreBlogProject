using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(BlogContext context) : base(context)
        {
        }
    }
}
