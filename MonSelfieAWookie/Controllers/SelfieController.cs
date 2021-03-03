using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using MonSelfieAWookie.Models;
using MonSelfieAWookie.Tools;

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
        private readonly ISelfieRepository _selfieRepository;

        public SelfieController(ISelfieRepository selfieRepository)
        {
            _selfieRepository = selfieRepository;
        }

        public IActionResult Index()
        {
            //Liste de models selfie
            var vm = new SelfiesIndexViewModel
            {
                Selfies = _selfieRepository.GetAll().ToList().Convert(),

                Weapons = new List<Weapon>()
                {
                    new Weapon(){ Id=1, Label="Crossbow", GroupName = "Distance"},
                    new Weapon(){ Id=1, Label="Bow", GroupName = "Distance"},
                    new Weapon(){ Id=1, Label="RainBow", GroupName = "Distance"},
                    new Weapon(){ Id=1, Label="PistoLaser", GroupName = "Cac"},
                    new Weapon(){ Id=1, Label="Fusil", GroupName = "Cac"},
                }
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
