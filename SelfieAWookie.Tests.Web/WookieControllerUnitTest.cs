using Microsoft.AspNetCore.Mvc;

using MonSelfieAWookie.Controllers;
using MonSelfieAWookie.Models;

using SelfieAWookie.Core.Domain;

using System.Collections.Generic;

using Xunit;

namespace SelfieAWookie.Tests.Web
{
    public class WookieControllerUnitTest
    {
        private class FakeWookieRepository : IWookieRepository
        {
            public IList<Wookie> GetAll()
            => new List<Wookie>()
            {
                new Wookie(){ Id=1, Prenom="Ioda", NbPoils=655, Selfies = new List<Selfie>()
                    {
                        new Selfie(){ Id=1, Titre="ioda", Url="https://c1.staticflickr.com/1/39/85740389_00e3dfb5bf_b.jpg"}
                    },
                    MainWeapon = new Weapon(){ Id=1, Label="Sabre vert"},
                    SecondaryWeapons = new List<Weapon>()
                    {
                        new Weapon(){ Id=2, Label="CrossBow"},
                        new Weapon(){ Id=3, Label="RainBow"}
                    }
                },

                new Wookie(){ Id=2, Prenom="Chew", NbPoils=8985654, Selfies = new List<Selfie>()
                    {
                        new Selfie(){ Id=1, Titre="Chew", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=2, Titre="Chew", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=3, Titre="Chew", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=4, Titre="Chew", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                    },
                    MainWeapon = new Weapon(){ Id=1, Label="Bow"},
                    SecondaryWeapons = new List<Weapon>()
                    {
                        new Weapon(){ Id=2, Label="knife"},
                        new Weapon(){ Id=3, Label="fist"}
                    }
                },

                new Wookie(){ Id=3, Prenom="Obiwan", NbPoils=45, Selfies = new List<Selfie>()
                    {
                        new Selfie(){ Id=1, Titre="Obiwan", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=2, Titre="Obiwan", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=3, Titre="Obiwan", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=4, Titre="Obiwan", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"},
                        new Selfie(){ Id=5, Titre="Obiwan", Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg"}
                    },
                    MainWeapon = new Weapon(){ Id=1, Label="Sabre bleu"},
                    SecondaryWeapons = new List<Weapon>()
                    {
                        new Weapon(){ Id=2, Label="knife"},
                        new Weapon(){ Id=3, Label="fist"},
                        new Weapon(){ Id=4, Label="fist"},
                        new Weapon(){ Id=5, Label="fist"},
                        new Weapon(){ Id=6, Label="fist"},
                        new Weapon(){ Id=7, Label="fist"},
                    }

                },
            };
        }

        #region Public Methods
        [Fact]
        public void ShouldReturnListOfWookies()
        {
            IWookieRepository fakeRepo = new FakeWookieRepository();

            //1-Arrange
            WookieController ctrl = new WookieController(fakeRepo);

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
