using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _SocailMediaComponenetPartial : ViewComponent
    {
        private readonly IRepository<SocailMedia> _repository;

        public _SocailMediaComponenetPartial(IRepository<SocailMedia> repository)
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
