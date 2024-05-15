using Microsoft.AspNetCore.Mvc;
using ListCreateSinglePage.Models;
using System.Collections.Generic;

namespace ListCreateSinglePage.Controllers
{
    public class UserController : Controller
    {
        protected static List<UserModel> users = new List<UserModel>();
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpPost]
        public IActionResult Create(int UserId,string Name,string Email)
        {
            if(UserId>0 && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email))
            {
                UserModel user = new UserModel
                {
                    UserId = UserId,
                    Name = Name,
                    Email = Email

                };
                users.Add(user);
            }
            
            return RedirectToAction("Index");
        }

    }
}
