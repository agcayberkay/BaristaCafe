using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.WelcomeScreenResults
{
    public class GetWelcomeScreenByIdQueryResult
    {
        public int WelcomeScreenId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
