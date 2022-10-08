using Microsoft.AspNetCore.Mvc;

namespace Employee_base_api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    [HttpGet(Name = "GetAllEmployees")]
    public IActionResult Get()
    {
        var employees = new Dictionary<int, string>()
        {
            { 1, "Henry Kamwamba" },
            { 2, "Smith Msiska" }
        };
        return Ok(employees);
    }
}