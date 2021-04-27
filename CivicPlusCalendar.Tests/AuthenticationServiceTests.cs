using CivicPlusCalendar.Services;
using Xunit;

namespace CivicPlusCalendar.Tests
{
    public class AuthenticationServiceTests
    {
        AuthenticationService _authenticationService;

        public AuthenticationServiceTests()
        {
            _authenticationService = new AuthenticationService(Constants.CLIENT_ID, Constants.CLIENT_SECRET, Constants.BASE_URI, Constants.REQUEST_PREFIX);
        }

        [Fact]
        public void GetToken()
        {
            var token = _authenticationService.GetToken().Result;
            Assert.True(!string.IsNullOrEmpty(token));
        }
    }
}
