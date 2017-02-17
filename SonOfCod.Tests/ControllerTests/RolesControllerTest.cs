using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class RolesControllerTest
    {

        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            //Arrange
            RolesController controller = new RolesController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_CreateRole_Test()
        {
            //Arrange
            RolesController controller = new RolesController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
