using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Tugas9.Models;


namespace Tugas9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        [HttpGet("{id}", Name = "Get where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);

        }

        [HttpPost( Name = "Insert Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> AddEmployeeItem(EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.AddEmployee(item);

        }

        [HttpPut("{id}", Name = "Update Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeById(String id,EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateById(id,item);

        }

        [HttpDelete("{id}", Name = "Delete Employee")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeById(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteById(id);

        }
    }
}
