using System.Collections.Generic;

namespace AlvTime.Business.EconomyData
{
    public record EmployeeWithOvertimePayoutResponseDto(int UserId, List <OvertimePayoutDto> OvertimePayout)
    {
    }
}
