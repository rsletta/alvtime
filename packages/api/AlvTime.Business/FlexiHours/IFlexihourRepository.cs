using System;
using System.Collections.Generic;
using AlvTime.Business.EconomyData;

namespace AlvTime.Business.FlexiHours
{
    public interface IFlexhourStorage
    {
        AvailableHoursDto GetAvailableHours(int userId, DateTime startDate, DateTime endDate);
        FlexedHoursDto GetFlexedHours(int userId);
        PayoutsDto GetRegisteredPayouts(int userId);
        PaidOvertimeEntry RegisterPaidOvertime(GenericHourEntry request, int userId);
        PaidOvertimeEntry CancelPayout(int userId, int id);

        RegisterOvertimePayout CalculateOvertimePayout(List<OvertimeEntry> overtimeEntries, int userId,
            GenericHourEntry requestedPayout, int paidOvertimeId);

        EmployeeWithOvertimePayoutResponseDto GetEmployeeOvertimePayoutForMonth(int year, int month, int userId);
        List<EmployeeWithOvertimePayoutResponseDto> GetOvetimePayoutForAllEmployeesForMonth (int year, int month);
    }
}
