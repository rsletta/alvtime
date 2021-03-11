using AlvTime.Persistence.DataBaseModels;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests.UnitTests.TimeEntries
{
    public class GetTopThreePersonalTimeEntriesTests
    {
        private readonly AlvTime_dbContext _database = new AlvTimeDbContextBuilder()
                .WithUsers()
                .CreateDbContext();

        [Fact]
        public void GetTopTimeEntries_EmployeeHasOneTimeEntry_ReturnsThatTimeEntry()
        {
            _database.Hours.Add(new Hours
            {
                User = 1,
                Task = new Task
                {
                    Name = "Ute hos kunde"
                }
            });
            _database.SaveChanges();

            var topTimeEntries = new TopTimeEntryService(_database).GetTopTimeEntriesForUser(1);

            Assert.Equal("Ute hos kunde", topTimeEntries);
        }

        [Fact]
        public void GetTopTimeEntries_EmployeeHasTwoTimeEntries_ReturnMostUsedTimeEntry()
        {
            _database.Hours.Add(new Hours
            {
                User = 1,
                Task = new Task
                {
                    Id = 1,
                    Name = "Ute hos kunde"
                },
                Value = 1
            });
            _database.SaveChanges();

            _database.Hours.Add(new Hours
            {
                User = 1,
                Task = new Task
                {
                    Id = 3,
                    Name = "Ute hos kunde2"
                },
                Value = 2
            });
            _database.SaveChanges();

            var topOneTimeEntry = new TopTimeEntryService(_database).GetTopTimeEntriesForUser(1);

            Assert.Equal("Ute hos kunde2", topOneTimeEntry);
        }

        [Fact]
        public void GetTopTimeEntries_EmployeeHasMultipleTimeEntriesOnOneTask_ReturnMostUsedTimeEntryOnGivenTask()
        {
            _database.Task.Add(new Task
            {
                Id = 1,
                Name = "Ute hos kunde"
            });

            _database.Task.Add(new Task
            {
                Id = 3,
                Name = "Inne hos Alv"
            });

            _database.SaveChanges();

            _database.Hours.Add(new Hours
            {
                User = 1,
                TaskId = 1, // ute hos kunde
                Value = 3
            });

            _database.Hours.Add(new Hours
            {
                User = 1,
                TaskId = 3, // inne hos Alv
                Value = 2
            });

            _database.Hours.Add(new Hours
            {
                User = 1,
                TaskId = 3, // inne hos Alv
                Value = 2
            });

            _database.SaveChanges();

            var topOneTimeEntry = new TopTimeEntryService(_database).GetTopTimeEntriesForUser(1);

            Assert.Equal("Inne hos Alv", topOneTimeEntry);
        }
    }

    internal class TopTimeEntryService
    {
        private readonly AlvTime_dbContext _database;



        public TopTimeEntryService(AlvTime_dbContext database)
        {
            _database = database;
        }

        internal string GetTopTimeEntriesForUser(int userId)
        {

            var timeEntriesForPerson = _database.Hours.Where(t => t.User == userId);

            var timeEntries = new List<(int id, decimal sum)>();

            foreach (var timeentry in timeEntriesForPerson)
            {
                var e = timeEntries.SingleOrDefault(entry => entry.id == timeentry.Id);
                if (!e.Equals(default))
                {
                    e.sum += timeentry.Value;
                }
                else
                { timeEntries.Add((e.id, e.sum));  }
            }

            var timeIdKode = timeEntries.OrderByDescending(te => te.sum).First();

            var noe = _database.Hours.Where(h => h.Task.Id == timeIdKode.id).ToList();
            return noe[0].Task.Name;

            //var hours = _database.Hours
            //    .Where(h => h.User == userId)
            //    .GroupBy(h => h.Task.Name, h => h.Value, (name, val) => new
            //    {
            //        Task = name,
            //        Hours = val.Sum()
            //    }).ToList();

            //return hours.OrderByDescending(h => h.Hours).First().Task;
        }
    }
}
