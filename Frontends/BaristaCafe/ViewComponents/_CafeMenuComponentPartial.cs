using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _CafeMenuComponentPartial : ViewComponent
    {
        private readonly IRepository<CafeMenu> _repository;

        public _CafeMenuComponentPartial(IRepository<CafeMenu> repository)
        {
            _repository = repository;
        }

        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
