using System.Threading.Tasks;
using boiler-plate-core-angular.Models.TokenAuth;
using boiler-plate-core-angular.Web.Controllers;
using Shouldly;
using Xunit;

namespace boiler-plate-core-angular.Web.Tests.Controllers
{
    public class HomeController_Tests: boiler-plate-core-angularWebTestBase
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