using JobPoratal_MVC.Models;
using JobPoratal_MVC.Repositories;
using JobPoratal_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.IO;

namespace JobPoratal_MVC.Controllers
{
    public class UserDetailsController : Controller
    {
        private IUserRepository _repository = null;
        public UserDetailsController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: UserDetails
        [HttpGet]
        public ActionResult Index()
        {
            var user = _repository.userDetails();
            return View(user);
        }
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View(id);
            }
            var user = _repository.GetUserById(id);
            return View(user);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserDetails userDetails)
        {
            if( userDetails == null)
            {
                throw new ArgumentNullException();
            }
            

            
            _repository.Create(userDetails);
            

            return RedirectToAction("Index", "UserDetails");
        }
    
        [NonAction]
        public List<SelectListItem> Qualification()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text="B.E/B.Tech", Value="B.E/B.Tech"},
                new SelectListItem {Text="M.Tech", Value="M.Tech"},
                new SelectListItem {Text="MBA", Value="MBA"},
                new SelectListItem {Text="MCA", Value="MCA"},
                new SelectListItem {Text="BBA", Value="BBA"}
            };
        }

        
        
    }
}