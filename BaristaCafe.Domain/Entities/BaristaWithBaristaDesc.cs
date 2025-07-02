using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class BaristaWithBaristaDesc
    {
        public List<Baristas> Baristas { get; set; }
        public BaristaDesc BaristaDesc { get; set; }
    }
}
