using System.Collections.Generic;
using System.Linq;
using AlvTime.Business.EconomyData;
using AlvTime.Business.FlexiHours;
using AlvTimeWebApi.Authentication;
using AlvTimeWebApi.Controllers.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AlvTimeWebApi.Controllers.EconomyData
{
    [Route("api/EconomyData")]
    [ApiController]
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;
        private readonly IFlexhourStorage _flexhourStorage;

        public SalaryController(ISalaryService salaryService, IFlexhourStorage flexhourStorage)
        {
            _salaryService = salaryService;
            _flexhourStorage = flexhourStorage;
        }

        [AuthorizeAdmin]
        [HttpPost("/EmployeeSalary")]
        public ActionResult<EmployeeSalaryResponse> RegisterHourlySalary([FromBody] EmployeeSalaryRequest employeeSalaryData)
        {
            var salary = ToEmployeeSalaryResponse(_salaryService.RegisterHourlySalary(employeeSalaryData));
            return Ok(salary);
        }

        [AuthorizeAdmin]
        [HttpPost("/SearchEmployeesSalary")]
        public ActionResult<List<List<EmployeeSalaryResponse>>> GetEmployeeSalaryData([FromBody] IEnumerable<int> userIds)
        {
            var employeesSalaryData = new List<List<EmployeeSalaryResponse>>();
            foreach (var userId in userIds)
            {
                var salaryData = _salaryService.GetEmployeeSalaryData(userId).Select(ToEmployeeSalaryResponse)
                    .ToList();
                employeesSalaryData.Add(salaryData);
            }

            return Ok(employeesSalaryData);
        }
        
        //[AuthorizeAdmin]
        [HttpGet("/overtimePayouts/{year}/{month}")]
        public ActionResult<List<EmployeeWithOvertimePayoutResponseDto>> GetOvertimePayoutForEmployees(int year, int month)
        {
            return Ok(_flexhourStorage.GetOvetimePayoutForAllEmployeesForMonth(year, month));
        }

        private EmployeeSalaryResponse ToEmployeeSalaryResponse(EmployeeSalaryDto employeeHourlySalary)
        {
            return new(employeeHourlySalary.Id,
                employeeHourlySalary.UserId,
                employeeHourlySalary.HourlySalary,
                employeeHourlySalary.FromDate.ToDateOnly(),
                employeeHourlySalary.ToDate?.ToDateOnly());
        }
    }
}