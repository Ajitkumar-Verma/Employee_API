using Microsoft.AspNetCore.Mvc;
using Employees.DataRepository;
using Employees.DataRepository.Interface;
using Employee_Model;

namespace Employee_API.Controllers
{
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee repository;

        public EmployeeController(IEmployee _repository)
        {
            repository = _repository;
        }

        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeDetailsModel> GetAllEmployee()
        {
            return repository.GetAllEmployee();
        }

        [Route("AddEmployee")]
        [HttpPost]
        public int AddEmployee([FromBody] EmployeeDetailsModel employee)
        {
            return repository.AddEmployee(employee);
        }

        [Route("UpdateEmployee")]
        [HttpPost]
        public int UpdateEmployee([FromBody] EmployeeDetailsModel employee)
        {
            return repository.UpdateEmployee(employee);
        }

        [Route("DeleteEmployee")]
        [HttpPost]
        public int DeleteEmployee([FromBody] EmployeeDetailsModel employee)
        {
            return repository.DeleteEmployee(employee.EmployeeId);
        }

        [Route("GetEmployeeById")]
        [HttpGet]
        public EmployeeDetailsModel GetEmployeeById(int employeeId)
        {
            return repository.GetEmployeeById(employeeId);
        }
    }
}

