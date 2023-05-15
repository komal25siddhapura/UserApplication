using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UserIntraction;
using UserIntraction.Application;
using UserIntraction.Models;

namespace UserIntraction.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;
        private readonly IUserService _userService;

        public UserController(UserDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        // GET: User
        public ActionResult Index()
        {         
            return View();
        }

        [HttpGet]
        public JsonResult AjaxGetCall()
        {
            List<UserModel> modelData = _userService.GetAll();
            return Json(modelData);
        }

        //GET: User/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public JsonResult SaveUserData(UserModel userModel)
        {
            UserModel checkExist = _userService.FetchByemail(userModel.Email);
            if(checkExist == null)
            {
                 _userService.Add(userModel);
                 return Json("data saved successfully");
            }
            else
            {
                checkExist.FirstName = userModel.FirstName;
                checkExist.LastName = userModel.LastName;
                checkExist.Phone = userModel.Phone;
                checkExist.Email = userModel.Email;
                checkExist.Address = userModel.Address;
                checkExist.Country = userModel.Country;
                checkExist.State = userModel.State;
                checkExist.Pincode = userModel.Pincode;
                _userService.Update(checkExist);
                return Json("data modified successfully");
            }
        }
        
        [HttpPost]
        public JsonResult ValidateEmail(string email)
        {
            JSONResponse response = new JSONResponse();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
           
            if (match.Success)
            {
                UserModel checkExist = _userService.FetchByemail(email);
                if (checkExist != null)
                {
                    response.status = 0000;
                    response.data = checkExist;
                    return Json(response);
                }
                else
                {
                    response.status = 0001;
                    return Json(response);
                }
            }
            else {
                response.status = 0002;
                return Json(response);
            }   
        }

    }
}


public class JSONResponse
{
    public int status { get; set; }
    public UserModel data { get; set; }
}