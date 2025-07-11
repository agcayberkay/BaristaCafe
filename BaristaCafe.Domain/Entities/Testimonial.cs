﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
        public int? Rating { get; set; } 
    }
}
