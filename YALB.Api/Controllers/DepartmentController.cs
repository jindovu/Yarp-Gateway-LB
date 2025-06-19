using Microsoft.AspNetCore.Mvc;
using YALB.Api.Models;

namespace YALB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public List<Department> departmentList = new List<Department>
        {
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "Finance" },
            new Department { Id = 3, Name = "HR" }
        };

        [HttpGet]
        public IActionResult GetDepartments()
        {
            string requestUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}{HttpContext.Request.QueryString}";
            GenericResponse<Department> departmentResponse = new GenericResponse<Department>();
            departmentResponse.DataList = departmentList;
            departmentResponse.Url = requestUrl;
            return Ok(departmentResponse);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            string requestUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}{HttpContext.Request.QueryString}";
            GenericResponse<Department> departmentResponse = new GenericResponse<Department>();
            departmentResponse.Data = departmentList.FirstOrDefault(x => x.Id == id);
            departmentResponse.Url = requestUrl;
            return Ok(departmentResponse);
        }
    }
}
