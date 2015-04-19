using AutismAppJam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

namespace AutismAppJam.Repositories
{
    public class OccupationalTrendsRepository
    {
        public List<OccupationalTrend> GetOccupationalTrendsByPersonalityType(string personalityType)
        {
            using (var db = Data.DatabaseContext.GetDbConnection())
            {
                var occupationalTrends = (List<OccupationalTrend>)db.Query<OccupationalTrend>("SELECT * FROM OccupationalTrends where PersonalityType = '" + personalityType + "'");
                return occupationalTrends;
            }
        }
    }
}
