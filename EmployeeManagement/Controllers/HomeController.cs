using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        // Inject IEmployeeRepository using Constructor Injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            // retrieve all the employees
            var model = _employeeRepository.GetAllEmployees();
            // Pass the list of employees to the view
            return View(model);
        }
        public ViewResult Details(int? id)
        {
            //Employee model = _employeeRepository.GetEmployee(1);

            //ViewBag.PageTitle = "Employee Details";

            //return View(model);
            // Instantiate HomeDetailsViewModel and store Employee details and PageTitle
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };

            // Pass the ViewModel object to the View() helper method
            return View(homeDetailsViewModel);

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }
            return View();
        }
    }
}