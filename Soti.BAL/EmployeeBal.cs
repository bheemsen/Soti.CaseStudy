using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.BAL
{
    public class EmployeeBal : IEmployeeBal
    {
        public void Test()
        {
            //throw new NotImplementedException();
        }
    }

    public interface IEmployeeBal
    {
        void Test();
    }
}
