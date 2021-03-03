using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using MonSelfieAWookie.Models;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Controllers
{
    public class SelfieController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SelfieController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Liste de models selfie
            var vm = new SelfiesIndexViewModel();
            vm.Selfies = new List<Selfie>()
            {
                new Selfie(){ Id=1, Url="https://c1.staticflickr.com/1/39/85740389_00e3dfb5bf_b.jpg", Titre = "Ioda"},
                new Selfie(){ Id=2, Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg", Titre="Chewbacca"}
            };

            vm.Weapons = new List<Weapon>()
            {
                new Weapon(){ Id=1, Label="Crossbow", GroupName = "Distance"},
                new Weapon(){ Id=1, Label="Bow", GroupName = "Distance"},
                new Weapon(){ Id=1, Label="RainBow", GroupName = "Distance"},
                new Weapon(){ Id=1, Label="PistoLaser", GroupName = "Cac"},
                new Weapon(){ Id=1, Label="Fusil", GroupName = "Cac"},
            };

            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
