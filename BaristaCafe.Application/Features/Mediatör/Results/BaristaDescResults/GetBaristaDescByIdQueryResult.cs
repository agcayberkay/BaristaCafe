using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.BaristaDescResults
{
    public class GetBaristaDescByIdQueryResult
    {
        public int BaristaDescId { get; set; }
        public string Title { get; set; }
        public string BigTitle { get; set; }
    }
}
