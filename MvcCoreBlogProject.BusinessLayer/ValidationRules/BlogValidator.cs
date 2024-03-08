using FluentValidation;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog başlığını boş bırakmayınız"); 
            RuleFor(x => x.Description).NotEmpty().WithMessage("Blog içeriğini boş bırakmayınız");
        }
    }
}
