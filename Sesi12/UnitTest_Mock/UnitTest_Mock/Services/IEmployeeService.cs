using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeeId(int EmpId);
        Task<Employee> GetEmployeeDetails(int EmpId);
    }
}
