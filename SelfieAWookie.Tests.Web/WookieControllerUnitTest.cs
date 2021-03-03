using System;

using Xunit;

using MonSelfieAWookie.Controllers;
using Microsoft.AspNetCore.Mvc;
using MonSelfieAWookie.Models.Dtos;
using MonSelfieAWookie.Models;

namespace SelfieAWookie.Tests.Web
{
    public class WookieControllerUnitTest
    {
        #region Public Methods
        [Fact]
        public void ShouldReturnListOfWookies()
        {
            //1-Arrange
            WookieController ctrl = new WookieController();

            //2-Act
            //Index renvoie un ViewResult
            IActionResult result = ctrl.Index();

            //3-Assert
            Assert.IsType<ViewResult>(result);
            ViewResult viewResult = result as ViewResult;

            //viewResult.Model est de type WookieViewModel
            Assert.IsType<WookieViewModel>(viewResult.Model);
            WookieViewModel vm = viewResult.Model as WookieViewModel;
            Assert.True(vm.Wookies.Count == 3);
        }
        #endregion
    }
}
