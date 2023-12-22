using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        

       

        public IActionResult Index()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Seda", LastName="Çoban"},
                new Employee(){Id=2, FirstName="Ahmet", LastName="Can"},
                new Employee(){Id=3, FirstName="Mehmet", LastName="Yılmaz"},
            };
            return View("Index",list);
        }
    }
}