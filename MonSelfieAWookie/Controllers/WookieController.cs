using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using MonSelfieAWookie.Models;

using SelfieAWookie.Core.Domain;
using MonSelfieAWookie.Tools;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MonSelfieAWookie.Controllers
{
    public class WookieController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public WookieController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Liste de models selfie
            var vm = new WookieViewModel();


            vm.Wookies = new List<Wookie>()
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
            }.Convert();

            vm.MainWeapons = new List<Weapon>()
                    {
                        new Weapon(){ Id=1, Label="Sabre bleu"},
                        new Weapon(){ Id=2, Label="Sabre vert"},
                        new Weapon(){ Id=3, Label="Bow"}
                    };
            vm.MainWeaponsSelectList = new SelectList(vm.MainWeapons, "Id", "Label");

            return View(vm);
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
