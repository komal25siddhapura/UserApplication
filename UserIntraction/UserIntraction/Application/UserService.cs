using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserIntraction.Models;

namespace UserIntraction.Application
{
    public class UserService : IUserService
    {
        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public List<UserModel> GetAll()
        {
            return _context.ApplicationUser.ToList();
        }

        public UserModel FetchByID(int id)
        {
            var userModel = _context.ApplicationUser.FirstOrDefault(m => m.ID == id);
            return userModel;
        }

        public UserModel Add(UserModel userModel)
        {
            _context.Add(userModel);
            _context.SaveChanges();
            return userModel;
        }

        public UserModel Update(UserModel userModel)
        {
            _context.Update(userModel);
            _context.SaveChanges();
            return userModel;
        }

        public UserModel FetchByemail(string email)
        {
            var userModel = _context.ApplicationUser.FirstOrDefault(m => m.Email == email);
            return userModel;
        }
    }
}
