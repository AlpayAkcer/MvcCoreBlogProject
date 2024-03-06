using FluentValidation;
using MvcCoreBlogProject.EntityLayer.Concrete;

namespace MvcCoreBlogProject.BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar Adını Boş Geçmeyiniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçmeyiniz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Yazar Maili Boş Geçmeyiniz");
        }
    }
}
