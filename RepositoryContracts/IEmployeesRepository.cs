using Entities;

namespace RepositoryContracts
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<Employee>> GetEmployee();    
        Task<Employee?> GetEmployee(Guid EmployeeId);  
        
        Task<int> AddEmployee(Employee Employee);
    }
}
