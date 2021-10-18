using System.Threading.Tasks;
using Life.Models.TokenAuth;
using Life.Web.Controllers;
using Shouldly;
using Xunit;

namespace Life.Web.Tests.Controllers
{
    public class HomeController_Tests: LifeWebTestBase
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