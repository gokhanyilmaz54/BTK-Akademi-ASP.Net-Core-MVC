using BtkAkademiDers1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiDers1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Employee>()
            {
                new Employee { Id = 1,FirstName = "Gökhan", LastName = "Yılmaz", Age = 34},
                new Employee { Id = 2,FirstName = "Yaşar", LastName = "Yılmaz", Age = 63},
                new Employee { Id = 3,FirstName = "Zekiye", LastName = "Yılmaz", Age = 62}
            };
            return View(list);
        }
    }
}
