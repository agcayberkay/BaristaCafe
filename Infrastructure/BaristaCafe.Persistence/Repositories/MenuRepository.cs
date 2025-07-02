using BaristaCafe.Application.DTOs;
using BaristaCafe.Application.Interfaces;
using BaristaCafe.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Persistence.Repositories
{
    public class MenuRepository: IMenuRepository
    {
        private readonly BaristaCafeContext _context;

        public MenuRepository(BaristaCafeContext context)
        {
            _context = context;
        }

        public async Task<List<MenuViewModel>> GetAllMenusAsync()
        {
            var menus = await _context.Menus
                .Include(m => m.MenuItems)
                .ToListAsync();

            return menus.Select(m => new MenuViewModel
            {
                Id = m.Id,
                Title = m.Title,
                Items = m.MenuItems.Select(mi => new MenuItemViewModel
                {
                    Name = mi.Name,
                    Price = mi.Price,
                    Description = mi.Description
                }).ToList()
            }).ToList();
        }
    }
}
