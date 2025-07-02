using BaristaCafe.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Interfaces
{
    public interface IMenuRepository
    {
        Task<List<MenuViewModel>> GetAllMenusAsync();
    }
}
