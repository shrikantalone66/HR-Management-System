using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using HR_Management_System.Models;

namespace HR_Management_System.Controllers
{
    public class AdminController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult AddEmployee()

        {
            Models.Employee obj = new Employee();
            obj.EmpId = 10;
            obj.EmpName= "Shrikant";
            obj.EmpMobile = 8329497657;
            obj.EmpEmailId = "shrikantalone66@gmail.com";
            obj.EmpDesignation = "Software Enginner";
            obj.EmpSalary = 20000;


            return View();
        }

        public IActionResult ShowEmployee()
        {
            return View();
        }

        public IActionResult SearchEmployee()
        {
            return View();
        }

        public IActionResult Logout()
        {
            // Clear the user's authentication session
            HttpContext.SignOutAsync();

            // Redirect to the login page or home page
            return RedirectToAction("Index", "Home");
        }

    }
}

