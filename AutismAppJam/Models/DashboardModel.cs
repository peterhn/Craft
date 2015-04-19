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
        public User User { get; set; }
        public Personality Personality { get; set; }
        public List<OccupationalTrend> OccupationalTrends { get; set; }
    }
}
