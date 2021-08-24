﻿using System.Globalization;
using System.Linq;
using AlvTime.Business.EconomyData;
using AlvTime.Persistence.EconomyDataDBModels;
using FluentValidation;

namespace AlvTime.Persistence.Repositories.AlvEconomyData
{
    public class OvertimePayoutStorage : IOvertimePayoutStorage
    {
        private readonly AlvEconomyDataContext _economyContext;

        public OvertimePayoutStorage(AlvEconomyDataContext economyContext)
        {
            _economyContext = economyContext;
        }

        public OvertimePayoutResponsDto DeleteOvertimePayout(int userId, int paidOvertimeId)
        {
            var overtimePayout =
                _economyContext.OvertimePayouts.FirstOrDefault(op => op.UserId == userId && op.RegisteredPaidOvertimeId == paidOvertimeId);

            if (overtimePayout == null)
            {
                throw new ValidationException("Could not find a payout registered for this user");
            }

            _economyContext.OvertimePayouts.Remove(overtimePayout);
            _economyContext.SaveChanges();

            return new OvertimePayoutResponsDto
            {
                
                Id = overtimePayout.Id,
                Date = overtimePayout.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                UserId = overtimePayout.UserId,
                TotalPayout = overtimePayout.TotalPayout,
                PaidOvertimeId = overtimePayout.RegisteredPaidOvertimeId
            };
        }

        public OvertimePayoutResponsDto SaveOvertimePayout(RegisterOvertimePayoutDto overtimePayout)
        {
            var overtimePayoutEntity = new OvertimePayout
            {
                UserId = overtimePayout.UserId,
                Date = overtimePayout.Date,
                TotalPayout = overtimePayout.TotalPayout,
                RegisteredPaidOvertimeId = overtimePayout.PaidOvertimeId
            };

            _economyContext.OvertimePayouts.Add(overtimePayoutEntity);

            _economyContext.SaveChanges();
            return new OvertimePayoutResponsDto
            {
                Id = overtimePayoutEntity.Id,
                UserId = overtimePayoutEntity.UserId,
                Date = overtimePayoutEntity.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                TotalPayout = overtimePayoutEntity.TotalPayout,
                PaidOvertimeId = overtimePayoutEntity.RegisteredPaidOvertimeId
            };
        }
    }
}