using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepositoryContracts;

namespace Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly CompanyDbContext _db;
        private readonly ILogger<EmployeesRepository> _logger;

        public EmployeesRepository(CompanyDbContext dbContext, ILogger<EmployeesRepository> logger)
        {
            _db = dbContext;
            _logger = logger;
        }

        public async Task<int> AddEmployee(Employee employee)
        {
            employee.ID = Guid.NewGuid(); 
            await _db.Employees.AddAsync(employee);
            var rowUpdated = await _db.SaveChangesAsync();
            return rowUpdated;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            _logger.LogInformation("execute {ClassName}.{MethodName}", nameof(EmployeesRepository), nameof(GetEmployee));
            var employees = await _db.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetEmployee(Guid EmployeeId)
        {
            var employee = await _db.Employees.FirstOrDefaultAsync(e => e.ID == EmployeeId);

            return employee;
        }
    }
}
