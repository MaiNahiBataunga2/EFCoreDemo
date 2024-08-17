using System.Collections;
using Test.Models;

namespace Test.Services
{
    public interface IEmployeeService
    {
        public Task Create(EmployeeRequest employeeRequest);
        public Task<IEnumerable<Employee>> GetEmployee();
        public Task<Employee> GetEmployeeById(int id);
    }
}
