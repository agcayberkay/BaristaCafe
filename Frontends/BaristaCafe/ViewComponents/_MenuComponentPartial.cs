using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _MenuComponentPartial:ViewComponent
    {
        private readonly IMenuRepository _menuService;

        public _MenuComponentPartial(IMenuRepository menuService)
        {
            _menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = await _menuService.GetAllMenusAsync();
            return View(menus);
        }
    }
}
