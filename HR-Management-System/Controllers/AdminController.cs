using HR_Management_System.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
//using HR_Management_System.Models;

namespace HR_Management_System.Controllers
{
    public class AdminController : Controller
    {

        private readonly HrManagementSystemContext db;
        public AdminController(HrManagementSystemContext context) 
        {
            db = context;
        
        }



      
        public IActionResult Index()
        {
            return View();
            
        }

     
        public IActionResult AddEmployee()

        {

            return View();
        }


        [HttpPost]
        public IActionResult AddEmployee(string empid, string empname,string empmobile, string empemail, string empcity, string empdesignation,string empsalary)

        {

            // Create an object of the Employee class (Models)
            Employee obj1 = new Employee();
            obj1.EmpId = Convert.ToInt32(empid);
            obj1.EmpName = empname;
            obj1.EmpMobile = empmobile;
            obj1.EmpEmailid = empemail;
            obj1.EmpCity = empcity;
            obj1.EmpDesignation = empdesignation;
            obj1.EmpSalary = empsalary;

            //// create an object of the context class 
            //HrManagementSystemContext db = new HrManagementSystemContext();
            //db.Employees.Add(obj1);
            //db.SaveChanges();

            db.Employees.Add(obj1);  // ORM techniques (object ralation mapping)
            db.SaveChanges();

            ViewBag.message = "Employee added successfully";

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

