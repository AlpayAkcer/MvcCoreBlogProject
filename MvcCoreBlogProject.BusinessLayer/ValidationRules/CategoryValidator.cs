using FluentValidation;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçmeyiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori adı minimum 3 karakter girmelisiniz");
        }
    }
}
