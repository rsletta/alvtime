using System.Collections.Generic;

namespace AlvTime.Business.EconomyData
{
    public interface IEmployeeHourlySalaryStorage
    {
        EmployeeSalaryDto RegisterHourlySalary(EmployeeSalaryRequest employeeSalaryData);
        List<EmployeeSalaryDto> GetEmployeeSalaryData(int userId);
        List<OvertimePayoutDto> GetOvertimePayoutForMonth(int year, int month, int userId);
    }
}
