using AutismAppJam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutismAppJam.Models
{
    public class DashboardModel
    {
        public ApplicationUser User { get; set; }
        public MBTITest MBTITest { get; set; }
        public List<OccupationalTrend> OccupationalTrends { get; set; }
    }
}
