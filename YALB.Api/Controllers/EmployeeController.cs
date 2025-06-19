using Microsoft.AspNetCore.Mvc;
using YALB.Api.Models;

namespace YALB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> employeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "Rahim", Age = 30, Salary = 10, DepartmentId = 1 },
            new Employee { Id = 2, Name = "Karim", Age = 31, Salary = 12, DepartmentId = 2 },
            new Employee { Id = 3, Name = "Brahim", Age = 27, Salary = 10, DepartmentId = 3 },
            new Employee { Id = 4, Name = "Jake", Age = 28, Salary = 9, DepartmentId = 1 },
            new Employee { Id = 5, Name = "Jill", Age = 22, Salary = 5, DepartmentId = 2 }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            string requestUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}{HttpContext.Request.QueryString}";
            GenericResponse<Employee> employeeResponse = new GenericResponse<Employee>();
            employeeResponse.DataList = employeeList;
            employeeResponse.Url = requestUrl;
            return Ok(employeeResponse);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            string requestUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}{HttpContext.Request.QueryString}";
            GenericResponse<Employee> employeeResponse = new GenericResponse<Employee>();
            employeeResponse.Data = employeeList.FirstOrDefault(x => x.Id == id);
            employeeResponse.Url = requestUrl;
            return Ok(employeeResponse);
        }
    }
}
