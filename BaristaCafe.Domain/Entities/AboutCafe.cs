using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class AboutCafe
    {
        public int AboutId { get; set; }
        public string CafeName { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string VideoUrl { get; set; }
    }
}
