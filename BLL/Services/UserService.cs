using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static UserDTO createUser(UserDTO data)
        {
            if (data == null)
            {
                return data;
            }


            var objUser = new User();
            objUser.UserID = data.UserID;
            objUser.Username = data.Username;
            objUser.Password = data.Password;
            objUser.Role = data.Role;

            var saveUser = DataFactory.UserData().Create(objUser);

            return data;

        }

        public static List<UserDTO> GetAllUsers()
        {
            var data = DataFactory.UserData().Get();
            var returnList = new List<UserDTO>();
            foreach (var u in data)
            {
                var returnModel = new UserDTO()
                {
                    UserID = u.UserID,
                    Username = u.Username,
                    Password = u.Password,
                    Role = u.Role
                };
                returnList.Add(returnModel);
            }
            return returnList;

        }


        public static UserDTO UsersById(int id)
        {
            var data = DataFactory.UserData().Get(id);

            {
                var returnModel = new UserDTO()
                {
                    UserID = data.UserID,
                    Username = data.Username,
                    Password = data.Password,
                    Role = data.Role
                };
                return returnModel;
            }

        }
    }
}
