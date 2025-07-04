using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        //private readonly IRepository<Contact> _repository;

        //public _ContactComponentPartial(IRepository<Contact> repository)
        //{
        //    _repository = repository;
        //}

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var model = await _repository.GetAllAsync();
        //    if (model == null || !model.Any())
        //    {
        //        return Content("Veri bulunamadı.");
        //    }
        //    return View(model);
        //}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
