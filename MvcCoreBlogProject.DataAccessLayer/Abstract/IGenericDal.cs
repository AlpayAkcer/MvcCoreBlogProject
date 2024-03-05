using System.Linq.Expressions;

namespace MvcCoreBlogProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetListAll();
        T GetByID(int id);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
