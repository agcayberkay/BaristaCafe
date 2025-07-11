﻿using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _WorkingHoursComponentPartial : ViewComponent
    {
        private readonly IRepository<WorkingHours> _repository;

        public _WorkingHoursComponentPartial(IRepository<WorkingHours> repository)
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
