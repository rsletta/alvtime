using System;
using System.Linq;
using AlvTime.Persistence.DataBaseModels;
using AlvTime.Persistence.EconomyDataDBModels;
using Xunit;

namespace Tests.UnitTests.Flexihours
{
    public class GetEmployeesOvertimePayoutForGivenMonthTests
    {
        private readonly AlvTime_dbContext _context = new AlvTimeDbContextBuilder().WithUsers().CreateDbContext();

        private readonly AlvEconomyDataContext _economyDataContext =
            new AlvEconomyDataDbContextBuilder().CreateDbContext();

        [Fact]
        public void GetEmployeesOvertimePayoutForGivenMonth_UserHasOvertimePayoutRegisteredInEconomyDatabase_ReturnsPayout()
        {
            var userId = 1;
            var firstSalary = new EmployeeHourlySalary
            {
                UserId = userId,
                HourlySalary = 100.0M,
                FromDateInclusive = new DateTime(2019, 07, 01),
                ToDate = null
            };

            var overtmePayout = new OvertimePayout
            {
                Date = new DateTime(2020, 07, 07),
                RegisteredPaidOvertimeId = 1,
                TotalPayout = 1.0M * firstSalary.HourlySalary * 0.5M,
                UserId = userId
            };

            _economyDataContext.EmployeeHourlySalaries.Add(firstSalary);
            _economyDataContext.OvertimePayouts.Add(overtmePayout);
            _economyDataContext.SaveChanges();

            //overtime
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 7.5M, out var taskid));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid, 1.0M));
            //comprate 1.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 1.5M, out var taskid4));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid4, 1.5M));
            //comprate 1.0
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 12), 1.5M, out var taskid3));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid3, 1.0M));
            //comprate 0.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 21), 1.5M, out var taskid2));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid2, 0.5M));

            _context.SaveChanges();

            //act
            var sut = FlexiHoursTestUtils.CreateStorage(_context, _economyDataContext, new DateTime(2020,07,01));

            var calculatedPayoutForEmployeeForGivenMonth = sut.GetEmployeeOvertimePayoutForMonth(2020, 07, 1);

            //assert
            Assert.Equal(50M, calculatedPayoutForEmployeeForGivenMonth.OvertimePayout.Sum(x => x.TotalPayout));
        }

        [Fact]
        public void GetEmployeesOvertimePayoutForGivenMonth_UserOnlyHasPaidOvertimeRegisteredInAlvtimeDb_ReturnsCalculatedPayout()
        {
            var userId = 1;
            var firstSalary = new EmployeeHourlySalary
            {
                UserId = userId,
                HourlySalary = 100.0M,
                FromDateInclusive = new DateTime(2019, 07, 01),
                ToDate = null
            };

            _economyDataContext.EmployeeHourlySalaries.Add(firstSalary);
            _economyDataContext.SaveChanges();

            var paidOvertime = new PaidOvertime
            {
                Date = new DateTime(2020, 07, 07), HoursAfterCompRate = 0.5M, HoursBeforeCompRate = 1.0M, User = userId
            };

            _context.PaidOvertime.Add(paidOvertime);
            //overtime
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 7.5M, out var taskid));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid, 1.0M));
            //comprate 1.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 1.5M, out var taskid4));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid4, 1.5M));
            //comprate 1.0
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 12), 1.5M, out var taskid3));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid3, 1.0M));
            //comprate 0.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 21), 1.5M, out var taskid2));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid2, 0.5M));

            _context.SaveChanges();

            //act
            var sut = FlexiHoursTestUtils.CreateStorage(_context, _economyDataContext);

            var calculatedPayoutForEmployeeForGivenMonth = sut.GetEmployeeOvertimePayoutForMonth(2020, 07, 1);

            //assert
            Assert.Equal(50M, calculatedPayoutForEmployeeForGivenMonth.OvertimePayout.Sum(x => x.TotalPayout));
        }

        [Fact]
        public void GetEmployeesOvertimePayoutForGivenMonth_UserOnlyHasPaidOvertimeRegisteredTwiceInAlvtimeDb_ReturnsCalculatedPayout()
        {
            var userId = 1;
            var firstSalary = new EmployeeHourlySalary
            {
                UserId = userId,
                HourlySalary = 100.0M,
                FromDateInclusive = new DateTime(2019, 07, 01),
                ToDate = null
            };

            _economyDataContext.EmployeeHourlySalaries.Add(firstSalary);
            _economyDataContext.SaveChanges();

            var paidOvertime1 = new PaidOvertime
            {
                Date = new DateTime(2020, 07, 07),
                HoursAfterCompRate = 0.5M,
                HoursBeforeCompRate = 1.0M,
                User = userId
            };

            var paidOvertime2 = new PaidOvertime
            {
                Date = new DateTime(2020, 06, 30),
                HoursAfterCompRate = 0.5M,
                HoursBeforeCompRate = 1.0M,
                User = userId
            };

            _context.PaidOvertime.Add(paidOvertime1);
            _context.PaidOvertime.Add(paidOvertime2);
            //overtime
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 7.5M, out var taskid));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid, 1.0M));
            //comprate 1.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 1.5M, out var taskid4));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid4, 1.5M));
            //comprate 1.0
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 12), 1.5M, out var taskid3));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid3, 1.0M));
            //comprate 0.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 21), 1.5M, out var taskid2));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid2, 0.5M));

            _context.SaveChanges();

            //act
            var sut = FlexiHoursTestUtils.CreateStorage(_context, _economyDataContext);

            var calculatedPayoutForEmployeeForJune2020 = sut.GetEmployeeOvertimePayoutForMonth(2020, 06, 1);
            var calculatedPayoutForEmployeeForJuly2020 = sut.GetEmployeeOvertimePayoutForMonth(2020, 07, 1);

            //assert
            Assert.Equal(50M, calculatedPayoutForEmployeeForJune2020.OvertimePayout.Sum(x => x.TotalPayout));
            Assert.Equal(50M, calculatedPayoutForEmployeeForJuly2020.OvertimePayout.Sum(x => x.TotalPayout));
        }

        [Fact]
        public void GetEmployeesOvertimePayoutForGivenMonth_UserOnlyHasOvertimeButNoPaidOvertime_ReturnsNull()
        {
            var userId = 1;
            var firstSalary = new EmployeeHourlySalary
            {
                UserId = userId,
                HourlySalary = 100.0M,
                FromDateInclusive = new DateTime(2019, 07, 01),
                ToDate = null
            };

            _economyDataContext.EmployeeHourlySalaries.Add(firstSalary);
            _economyDataContext.SaveChanges();

            //overtime
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 7.5M, out var taskid));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid, 1.0M));
            //comprate 1.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 05), 1.5M, out var taskid4));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid4, 1.5M));
            //comprate 1.0
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 12), 1.5M, out var taskid3));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid3, 1.0M));
            //comprate 0.5
            _context.Hours.Add(FlexiHoursTestUtils.CreateTimeEntry(new DateTime(2020, 06, 21), 1.5M, out var taskid2));
            _context.CompensationRate.Add(FlexiHoursTestUtils.CreateCompensationRate(taskid2, 0.5M));

            _context.SaveChanges();

            //act
            var sut = FlexiHoursTestUtils.CreateStorage(_context, _economyDataContext);

            var calculatedPayoutForEmployeeForJuly2020 = sut.GetEmployeeOvertimePayoutForMonth(2020, 07, 1);

            //assert
            Assert.Equal(userId, calculatedPayoutForEmployeeForJuly2020.UserId);
            Assert.Null(calculatedPayoutForEmployeeForJuly2020.OvertimePayout);
        }
    }
}