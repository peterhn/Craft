using AutismAppJam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutismAppJam.Data;

using Dapper;
using System.Web.Security;


namespace AutismAppJam.Repositories
{
    public class PersonalityRepository
    {
        public Personality GetPersonality(string type)
        {
            using (var db = Data.DatabaseContext.GetDbConnection())
            {
                List<Personality> personalities = (List<Personality>)db.Query<Personality>("SELECT* FROM Personalities WHERE PersonalityType = '"+ type + "'");
                return personalities.First();
            }
        }
    }
}