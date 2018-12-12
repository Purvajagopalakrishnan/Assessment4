using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class EmployeeController : ControllerBase
        
    {
        List<Employees> emp = new List<Employees>()
            {
                new Employees {Emp_Name = "Sam", Emp_Type = "Part-time"},
                new Employees {Emp_Name = "Sowmiya", Emp_Type = "Part-time"},
                new Employees {Emp_Name = "Nithya", Emp_Type = "Part-time"},
                new Employees {Emp_Name = "John", Emp_Type = "Full-time"},
                new Employees {Emp_Name = "Jim", Emp_Type = "Contractor"},
                new Employees {Emp_Name = "Seam", Emp_Type = "Part-time"},
                new Employees {Emp_Name = "Riya", Emp_Type = "Contractor"},
                new Employees {Emp_Name = "Priya", Emp_Type = "Full-time"},
                new Employees {Emp_Name = "Rahul", Emp_Type = "Part-time"},
                new Employees {Emp_Name = "Ram", Emp_Type = "Full-time"},
            };
        public ActionResult<Dictionary<string, Employees>> GetDetails()
        {
           
            return Ok(emp);
        }
       [HttpPost]
        [Route("UpdateDetails")]
        public void Post([FromBody] Employees e)
        {
            foreach (var employee in emp)
            {
                if(employee.Emp_Name == e.Emp_Name)
                {
                    employee.Emp_Type = e.Emp_Type;
                }
            }
          //  return Ok();
        }
    }
}