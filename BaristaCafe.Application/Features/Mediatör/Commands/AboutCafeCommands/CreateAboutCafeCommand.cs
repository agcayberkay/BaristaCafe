using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Commands.AboutCafe
{
    public class CreateAboutCafeCommand:IRequest
    {
        public string CafeName { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string VideoUrl { get; set; }
    }
}
