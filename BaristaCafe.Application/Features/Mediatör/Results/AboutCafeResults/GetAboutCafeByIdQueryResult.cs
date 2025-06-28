using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.AboutCafeResults
{
    public class GetAboutCafeByIdQueryResult
    {
        public int AboutCafeId { get; set; }
        public string CafeName { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string VideoUrl { get; set; }
    }
}
