using Soti.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soti.Model;
using Soti.BAL;
using Autofac;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace Soti.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // private readonly IEmployeeBal empBal;
        private EmployeeEntities db = new EmployeeEntities();
        //public EmployeeRepository(IEmployeeBal emp)
        //{
        //    empBal = emp;
        //}
        public int AddEmployee(Soti.Model.Employee employee)
        {
            var empData = new Repository.Employee()
            {
                Email = employee.Email,
                EmpName = employee.EmployeeName
            };

            db.Employees.Add(empData);
            db.SaveChanges();
            return empData.EmpId;

        }
    }


}

