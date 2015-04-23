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
            try
            {
                using (var db = Data.DatabaseContext.GetDbConnection())
                {
                    db.Execute("UPDATE Users SET DateOfBirth = '" + registrationModel.DateOfBirth + "' WHERE UserId = '" + user.ProviderUserKey + "'");
                    db.Execute("UPDATE Users SET FirstName = '" + registrationModel.FirstName + "', LastName = '" + registrationModel.LastName + "' , Email = '"+ registrationModel.Email  +"' WHERE UserId = '" + user.ProviderUserKey + "'");
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public ApplicationUser GetUserByUsername(string username)
        {
            try
            {
                using (var db = Data.DatabaseContext.GetDbConnection())
                {
                    var users = (List<User>)db.Query<User>("SELECT * FROM Users WHERE Username = '" + username + "'");
                    var user = users[0];

                    var applicationUser = new ApplicationUser();
                    applicationUser.UserName = user.UserName;
                    applicationUser.Id = user.UserId.ToString();
                    applicationUser.FirstName = user.FirstName;
                    applicationUser.LastName = user.LastName;
                    applicationUser.Email = user.Email;

                    return applicationUser;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public User GetUserById(string userId)
        {
            try
            {
                using(var db = Data.DatabaseContext.GetDbConnection())
                {
                    var users = (List<User>)db.Query<User>("SELECT * FROM Users WHERE UserId = '" + userId + "'");
                    return users.First();
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool UpdateUserPersonalityType(string userId, Personality personality)
        {
            try
            {
                using(var db = Data.DatabaseContext.GetDbConnection())
                {
                    string query = string.Format("UPDATE Users SET PersonalityType = '{0}' WHERE UserId = '{1}'", personality.PersonalityType, userId);
                    db.Execute(query);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUserAttentionSpan(string userId, int attentionSpan)
        {
            try
            {
                using (var db = Data.DatabaseContext.GetDbConnection())
                {
                    string query = string.Format("UPDATE Users SET AttentionSpan = '{0}' WHERE UserId = '{1}'", attentionSpan , userId);
                    db.Execute(query);
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