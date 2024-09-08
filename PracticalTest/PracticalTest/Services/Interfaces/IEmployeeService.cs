using PracticalTest.DTOs;

namespace PracticalTest.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int employeeNo);
        Task<EmployeeDto> AddEmployeeAsync(EmployeeDto employeeDto);
        Task<EmployeeDto> UpdateEmployeeAsync(int employeeNo, EmployeeDto employeeDto);
        Task DeleteEmployeeAsync(int employeeNo);
        Task<decimal> GetAverageSalaryAsync();
    }
}
