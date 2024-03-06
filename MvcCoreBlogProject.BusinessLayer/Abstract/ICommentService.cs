using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
       
        List<Comment> TGetCommentsByBlogList(int id);
    }
}
