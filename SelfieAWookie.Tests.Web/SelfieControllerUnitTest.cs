using Microsoft.AspNetCore.Mvc;

using MonSelfieAWookie.Controllers;
using MonSelfieAWookie.Models;

using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Selfies;

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

using Xunit;

namespace SelfieAWookie.Tests.Web
{
    public class SelfieControllerUnitTest
    {
        private class FakeSelfieRepository : ISelfieRepository
        {
            public IList<Selfie> GetAll()
            => new List<Selfie>()
                {
                    new Selfie(){ Id=1, Url="https://c1.staticflickr.com/1/39/85740389_00e3dfb5bf_b.jpg", Titre = "Ioda"},
                    new Selfie(){ Id=2, Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg", Titre="Chewbacca"},
                    new Selfie(){ Id=3, Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg", Titre="Selfie3"}
                };
        }

        #region Public Methods
        [Fact]
        public void ShouldReturnListOfSelfies()
        {
            FakeSelfieRepository fakeRepo = new FakeSelfieRepository();

            //1-Arrange
            SelfieController ctrl = new SelfieController(fakeRepo);

            //2-Act
            //Index renvoie un ViewResult
            IActionResult result = ctrl.Index();

            //3-Assert
            Assert.IsType<ViewResult>(result);
            ViewResult viewResult = result as ViewResult;

            //viewResult.Model est de type SelfiesIndexViewModel
            Assert.IsType<SelfiesIndexViewModel>(viewResult.Model);
            SelfiesIndexViewModel vm = viewResult.Model as SelfiesIndexViewModel;

            Assert.True(vm.Selfies.Count == 3);
            Assert.True(vm.Selfies[0].Titre == "Ioda");
            Assert.True(vm.Selfies[1].Titre == "Chewbacca");
            Assert.True(vm.Selfies[2].Titre == "Selfie3");
        }

        [Fact]
        public void ShouldReturnListOfSelfiesFromJson()
        {
            JsonSelfieRepository fakeRepo = new JsonSelfieRepository();

            //1-Arrange
            SelfieController ctrl = new SelfieController(fakeRepo);

            //2-Act
            //Index renvoie un ViewResult
            IActionResult result = ctrl.Index();

            //3-Assert
            Assert.IsType<ViewResult>(result);
            ViewResult viewResult = result as ViewResult;

            //viewResult.Model est de type SelfiesIndexViewModel
            Assert.IsType<SelfiesIndexViewModel>(viewResult.Model);
            SelfiesIndexViewModel vm = viewResult.Model as SelfiesIndexViewModel;

            Assert.True(vm.Selfies.Count == 3);
            Assert.True(vm.Selfies[0].Titre == "Ioda");
            Assert.True(vm.Selfies[1].Titre == "Chewbacca");
            Assert.True(vm.Selfies[2].Titre == "SelfieJson3");
        }
        #endregion
    }
}
