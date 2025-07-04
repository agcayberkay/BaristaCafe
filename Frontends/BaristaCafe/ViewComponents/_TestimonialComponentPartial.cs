using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        private readonly IRepository<Testimonial> _repository;

        public _TestimonialComponentPartial(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _repository.GetAllAsync();
            if (model == null || !model.Any())
            {
                return Content("Veri bulunamadı.");
            }
            return View(model);
        }
    }
}
