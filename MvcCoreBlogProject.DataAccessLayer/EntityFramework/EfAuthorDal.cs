using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;
using MvcCoreBlogProject.DataAccessLayer.Repositories;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.EntityFramework
{
    public class EfAuthorDal : GenericRepository<Author>, IAuthorDal
    {
        public EfAuthorDal(BlogContext context) : base(context)
        {
        }
    }
}
