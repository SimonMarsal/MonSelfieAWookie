using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using MonSelfieAWookie.Models;
using MonSelfieAWookie.Models.Dtos;
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
        private readonly IWeaponRepository _weaponRepository;

        public SelfieController(ISelfieRepository selfieRepository, IWeaponRepository weaponRepository)
        {
            _selfieRepository = selfieRepository;
            _weaponRepository = weaponRepository;
        }

        public IActionResult Index()
        {
            //Liste de models selfie
            var vm = new SelfiesIndexViewModel
            {
                Selfies = _selfieRepository.GetAll().ToList().Convert(),
                Weapons = _weaponRepository.GetAll().ToList()
            };

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SelfieAddDto dto)
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
