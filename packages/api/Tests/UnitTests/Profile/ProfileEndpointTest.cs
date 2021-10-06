using System;
using System.Linq;
using AlvTime.Business.Users;
using AlvTime.Persistence.Repositories;
using Xunit;
namespace Tests.UnitTests.Profile
{
    public class ProfileEndpointTest
    {

        private string GetUser(DateTime endDate)
        {
            var context = new AlvTimeDbContextBuilder().WithUsers().WithPersonalAccessTokens().CreateDbContext();

            var email = "test@test.no";
            var userStorage = new UserStorage(context);
            var accessTokenStorage = new AccessTokenStorage(context);

            userStorage.AddUser(new CreateUserDto
            {
                Name = "TestUser",
                Email = email,
                StartDate = DateTime.Now.AddMonths(-2),
                EndDate = endDate
            });

            var user = userStorage.GetUser(new UserQuerySearch
            {
                Email = email
            }).First();

            var token = accessTokenStorage.CreateLifetimeToken("test", user.Id);

            return token.Token;

        }

        [Fact]
        public void GetProfile_Future_EndDate()
        {
            var user = GetUser();


        }

        [Fact]
        public void GetProfile_Previous_EndDate()
        {

        }

        [Fact]
        public void GetProfile_No_EndDate()
        {

        }

        [Fact]
        public void GetProfile_Is_EndDate()
        {

        }
    }
}
