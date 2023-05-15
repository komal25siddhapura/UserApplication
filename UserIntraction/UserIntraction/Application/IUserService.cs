using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserIntraction.Models;

namespace UserIntraction.Application
{
    public interface IUserService
    {
        List<UserModel> GetAll();
        UserModel FetchByID(int id);
        UserModel Add(UserModel userModel);
        UserModel Update(UserModel userModel);
        UserModel FetchByemail(string email);
    }
}
