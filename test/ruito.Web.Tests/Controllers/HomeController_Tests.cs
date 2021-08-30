using System.Threading.Tasks;
using ruito.Models.TokenAuth;
using ruito.Web.Controllers;
using Shouldly;
using Xunit;

namespace ruito.Web.Tests.Controllers
{
    public class HomeController_Tests: ruitoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}