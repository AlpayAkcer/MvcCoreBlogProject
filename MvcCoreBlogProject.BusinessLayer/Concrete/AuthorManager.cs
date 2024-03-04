using MvcCoreBlogProject.BusinessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void TAdd(Author entity)
        {
            _authorDal.Add(entity);
        }

        public void TDelete(Author entity)
        {
            _authorDal.Delete(entity);
        }

        public Author TGetByID(int id)
        {
            return _authorDal.GetByID(id);
        }

        public List<Author> TGetListAll()
        {
            return _authorDal.GetListAll();
        }

        public void TUpdate(Author entity)
        {
            _authorDal.Update(entity);
        }
    }
}
