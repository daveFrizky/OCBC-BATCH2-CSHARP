using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Model;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Constructer
        public EmployeeService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public Task<Employee> GetEmployeeDetails(int EmpId)
        {
            throw new NotImplementedException();
        }
        #endregion

        public async Task<string> GetEmployeeId(int EmpId)
        {
            var name = await _apiDbContext.Employees.Where(c=>c.Id == EmpId).Select(d=> d.Name).FirstOrDefaultAsync();
            return name;
        }
    }
}
