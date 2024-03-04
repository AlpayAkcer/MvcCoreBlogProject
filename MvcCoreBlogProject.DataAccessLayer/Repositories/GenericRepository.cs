using MvcCoreBlogProject.DataAccessLayer.Abstract;
using MvcCoreBlogProject.DataAccessLayer.Concrete;

namespace MvcCoreBlogProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BlogContext _context;
        public GenericRepository(BlogContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
