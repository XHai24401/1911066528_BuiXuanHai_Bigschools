using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1911066528_BuiXuanHai_Bigschool.Models;
using _1911066528_BuiXuanHai_Bigschool.ViewModels;
using Microsoft.AspNet.Identity;

namespace _1911066528_BuiXuanHai_Bigschool.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Lecturer
        private readonly ApplicationDbContext _dbContext;

        public LecturerController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Lecturer
        [Authorize]
        public ActionResult Following()
        {
            var userId = User.Identity.GetUserId();
            var lecturers = _dbContext.Followings
                .Where(a => a.FollowerId == userId)
                .Select(a => a.Followee)
                .ToList();

            return View(lecturers);


        }
    }
}