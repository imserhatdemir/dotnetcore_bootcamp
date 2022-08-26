using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik Boş Geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel Boş Geçilemez.");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Başlık 150 karakterden fazla olamaz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık minimum 5 karakterden oluşmalı.");
            RuleFor(x => x.Content).MinimumLength(150).WithMessage("İçerik minimum 150 karakterden oluşmalı.");
        }
    }
}
