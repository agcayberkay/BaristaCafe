using BaristaCafe.Application.Interfaces;
using BaristaCafe.Domain.Entities;
using BaristaCafe.Persistence.Context;
using Microsoft.AspNetCore.Mvc;

namespace BaristaCafe.ViewComponents
{
    public class _BaristasComponentPartial:ViewComponent
    {
        private readonly IRepository<Baristas> _repository;
        private readonly IRepository<BaristaDesc> _baristaDescRepository;
        public _BaristasComponentPartial(IRepository<Baristas> repository, IRepository<BaristaDesc> baristaDescRepository)
        {
            _repository = repository;
            _baristaDescRepository = baristaDescRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var baristas = await _repository.GetAllAsync();
            var baristaDesc = (await _baristaDescRepository.GetAllAsync()).FirstOrDefault();

            var model = new BaristaWithBaristaDesc
            {
                Baristas = baristas,
                BaristaDesc = baristaDesc
            };

            return View(model);
        }
    }
}
