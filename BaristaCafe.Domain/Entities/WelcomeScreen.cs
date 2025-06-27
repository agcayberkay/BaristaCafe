using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class WelcomeScreen
    {
        public int WScreenId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
