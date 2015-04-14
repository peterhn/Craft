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
    public class UserRepository
    {
        public bool CreateNewUser(MembershipUser user, RegisterModel registrationModel)
        {
            using (var db = Data.DatabaseContext.GetDbConnection())
            {
                
                db.Execute("UPDATE Memberships SET DateOfBirth = '" + registrationModel.DateOfBirth  + "' WHERE UserId = '" + user.ProviderUserKey + "'");
                db.Execute("UPDATE Users SET FirstName = '" + registrationModel.FirstName + "', LastName = '" + registrationModel.LastName + "' WHERE UserId = '" + user.ProviderUserKey + "'");
            }

            return false;
        }
    }
}