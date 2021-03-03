using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        private readonly IWookieRepository _repository;

        public WookieController(IWookieRepository wookieRepository)
        {
            _repository = wookieRepository;
        }

        public IActionResult Index()
        {
            //Liste de models selfie
            var vm = new WookieViewModel();

            vm.Wookies = _repository.GetAll().ToList().Convert();

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
