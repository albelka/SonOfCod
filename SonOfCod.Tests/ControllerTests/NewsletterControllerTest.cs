﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class NewsletterControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Create_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}

       
