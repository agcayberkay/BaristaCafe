using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.LocationResults
{
    public class GetLocationByIdQueryResult
    {
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MapsUrl { get; set; }

    }
}
