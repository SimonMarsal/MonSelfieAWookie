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

        public WookieController(IWookieRepository wookieRepository)
        {
            _repository = wookieRepository;
        }

        public async Task<IActionResult> Index()
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
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(WookieAddDto dto)
        {
            await _repository.CreateAsync(dto.Convert());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
