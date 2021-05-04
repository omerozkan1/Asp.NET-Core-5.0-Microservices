using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalog
{
    public class CourseCreateInput
    {
        [Display(Name="Kurs ismi")]
        public string Name { get; set; }

        [Display(Name = "Kurs fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Kurs açıklaması")]
        public string Description { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

        [Display(Name = "Kurs resmi")]
        public IFormFile PhotoFormFile { get; set; }

        [Display(Name = "Kurs kategorisi")]
        public string CategoryId { get; set; }
        public FeatureViewModel Feature { get; set; }
    }
}
