using Entities;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts;

namespace BlogLogging.Controllers
{
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesRepository employeesRepository)
        {
            _logger = logger;
            _employeesRepository = employeesRepository;
        }

        [Route("[action]")]
        [Route("/")]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("execute {ClassName}.{MethodName}", nameof(EmployeesController), nameof(Index));
            var employees = await _employeesRepository.GetEmployee();
            
    
            //execute service to get employees data
            return Ok(new {Data = employees});
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create(Employee employee)
        {
            _logger.LogInformation("execute {ClassName}.{MethodName}", nameof(EmployeesController), nameof(Create));

            var rowUpdated = await _employeesRepository.AddEmployee(employee);
            if (rowUpdated > 0)
            {
                _logger.LogInformation("{Employee} success to add to database", employee);
            }
            else
            {
                _logger.LogWarning("{Employee} failed to add to database", employee);
            }


            //execute service to get employees data
            return Ok(new {Message = "Succes add new employee"});
        }


    }
}
