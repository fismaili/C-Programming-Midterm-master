using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexDataModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComplexDataModel.Controllers
{

    public class EmployeeController : Controller
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

        public ViewResult EmployeeList()
        {
            var model = employeeRepository.GetEmployees();
            return View(model);
       
        }

     
        public ViewResult Details(int id)
        {
            Employee model = employeeRepository.GetEmployee(id);
      
            return View(model);
        }
    }
}