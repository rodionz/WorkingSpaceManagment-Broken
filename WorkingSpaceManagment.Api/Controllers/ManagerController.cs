﻿using HotChairsApp.BL;
using HotChairsApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkingSpaceManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly EmployeesService _employeeSrv;

        public ManagerController(EmployeesService eservice) {

            _employeeSrv = eservice;
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployeeToTheCompany([FromBody]Employee newEmployee) {

            var result = _employeeSrv.AddEmployeeToCompany(newEmployee);

            return Ok(result);
        }

        public IActionResult FireEmployee(string id) {

            _employeeSrv.RemoveEmployee(id);

            return Ok();
        }

    }
}
