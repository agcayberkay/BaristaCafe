using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.CafeMenuResluts
{
    public class GetCafeMenuQueryResult
    {
        public int CafeMenuId { get; set; }
        public string Title { get; set; }
        public string MenuName { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? Favorite { get; set; }
    }
}
