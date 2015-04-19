using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

namespace AutismAppJam.Repositories
{
    public class MBTITestRepository
    {
        public bool CreateTestForUser(string userId)
        {
            try
            {
                using(var db = Data.DatabaseContext.GetDbConnection())
                {
                    string newTestId = Guid.NewGuid().ToString();
                    db.Execute(string.Format("INSERT INTO MBTITests (MbtiTestId, Responses, Completed) VALUES ('{0}', '{1}', {2})", newTestId, "", 0));
                    db.Execute(string.Format("UPDATE Users SET MbtiTestId = '{0}' WHERE UserId = '{1}'", newTestId, userId));
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCompleteTestForUser(string userId)
        {
            try
            {
                using (var db = Data.DatabaseContext.GetDbConnection())
                {
                    string newTestId = Guid.NewGuid().ToString();
                    db.Execute(string.Format("INSERT INTO MBTITests (MbtiTestId, Responses, Completed) VALUES ('{0}', '{1}', {2})", newTestId, "", 0));
                    db.Execute(string.Format("UPDATE Users SET MbtiTestId = '{0}' WHERE UserId = '{1}'", newTestId, userId));
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
