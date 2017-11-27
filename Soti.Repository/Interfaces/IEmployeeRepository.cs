using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soti.Model;
namespace Soti.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        int AddEmployee(Model.Employee employee);
    }
}
