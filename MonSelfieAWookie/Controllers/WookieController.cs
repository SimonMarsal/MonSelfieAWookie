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
using MonSelfieAWookie.Models.Dtos;

namespace MonSelfieAWookie.Controllers
{
    public class WookieController : Controller
    {
        private readonly IWookieRepository _repository;
        private readonly IWeaponRepository _weaponRepository;

        public WookieController(IWookieRepository wookieRepository, IWeaponRepository weaponRepository)
        {
            _repository = wookieRepository;
            _weaponRepository = weaponRepository;
        }

        public async Task<IActionResult> Index(int id)
        {
            var result = await _repository.GetAllAsync();
            var wookiesDto = result.ToList().Convert();

            var vm = new WookieViewModel() { Wookies = wookiesDto };
            return View(vm);
        }

        public IActionResult WookiesAsJson()
        {
            return this.Json(_repository.GetAll().ToList().Convert());
        }

        public async Task<IActionResult> SuperIndex()
        {
            var result = await _repository.GetAllAsync();
            var wookiesDto = result.ToList().Convert();

            var vm = new WookieViewModel() { Wookies = wookiesDto };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //Création d'un WookieAddViewModel contenant la liste des armes prinsipales disponibles
            var mainweapons = await _weaponRepository.GetAllAsync();

            var vm = new WookieAddViewModel() { MainWeapons = mainweapons.ToList().Convert(),
                MainWeaponsSelectList = mainweapons.ToList().ConvertToSelectList()
            };

            return View(vm);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(WookieAddViewModel vm)
        {
            //Validation côté code
            //règles dans WookieEntityTypeConfiguration
            if (this.ModelState.IsValid)
                await _repository.CreateAsync(vm.WookieAddDto.Convert());

            return this.RedirectToAction("Index");

            //egalement possible :
            //return await Task.FromResult(View());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
