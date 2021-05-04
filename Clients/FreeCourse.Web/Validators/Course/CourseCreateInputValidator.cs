﻿using FluentValidation;
using FreeCourse.Web.Models.Catalog;

namespace FreeCourse.Web.Validators.Course
{
    public class CourseCreateInputValidator:AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş olamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş olamaz.");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("Süre alanı boş olamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş olamaz.").ScalePrecision(2,6).WithMessage("Hatalı format.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori seçiniz");
        }
    }
}
