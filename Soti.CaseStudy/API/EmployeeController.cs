using Soti.Model;
using Soti.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Soti.CaseStudy.API
{
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [HttpPost]
        public HttpResponseMessage AddEmployee(Employee model)
        {

            var secs = 3;
            Log.Fatal("Start log FATAL...");

            Log.Error("dddddddddddddd");
            Log.Warn("sssssssssssssssss");
            

            var a = employeeRepository.AddEmployee(model);
            return Request.CreateResponse(HttpStatusCode.OK, 1);
        }
    }
}
