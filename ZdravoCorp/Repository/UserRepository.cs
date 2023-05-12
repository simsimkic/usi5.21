using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Repository;
using ZdravoCorp.Users;
using Newtonsoft.Json;


namespace ZdravoCorp.Repository
{
    internal class UserRepository
    {
        public static User loggedUser;
        public static List<User> users = new List<User>();
        public int GetLastID() 
        {
            return users.LastOrDefault().GetId();
        }
        public void AddUser(int id)
        {
            //Add user to json

            throw new NotImplementedException();
        }
        public void DeleteUser(int id)
        {
            // Delete User

            throw new NotImplementedException();
        }
        public void EditUser(User user)
        {
            //Edit user

            throw new NotImplementedException();
        }
    }
}
