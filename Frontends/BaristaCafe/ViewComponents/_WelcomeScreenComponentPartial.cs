using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _WelcomeScreenComponentPartial:ViewComponent
    {
        private readonly IRepository<WelcomeScreen> _repository;

        public _WelcomeScreenComponentPartial(IRepository<WelcomeScreen> repository)
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
