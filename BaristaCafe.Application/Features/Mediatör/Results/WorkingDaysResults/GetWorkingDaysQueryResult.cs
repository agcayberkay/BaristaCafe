using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaCafe.Application.Features.Mediatör.Results.WorkingDaysResults
{
    public class GetWorkingDaysQueryResult
    {
        public int WorkingHoursId { get; set; }
        public string WorkingDays { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string? HolidaysWorkTime { get; set; }
        public string? ClosedDay { get; set; }
    }
}
