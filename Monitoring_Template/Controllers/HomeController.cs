using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Monitoring_Template.Application.DTO;
using Monitoring_Template.Application.Services;
using Monitoring_Template.Application.Services.Interface;
using Monitoring_Template.Core.Entities;

namespace Monitoring_Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger,IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public async Task<IActionResult> Index(DateOnly? startDate,DateOnly? endDate)
        {
            var filterDateStart = startDate ?? DateOnly.FromDateTime(DateTime.Now);
            var filterDateEnd = endDate ?? filterDateStart; // Jika tidak ada endDate, gunakan startDate

            if (filterDateEnd < filterDateStart)
            {
                ModelState.AddModelError("", "Tanggal akhir tidak boleh lebih kecil dari tanggal mulai.");
                return View(new List<ResultPackingLabelsModel>()); // Kembalikan list kosong jika ada error
            }
            HomeRequestDTO response = new HomeRequestDTO();
            response.startDate = filterDateStart;
            response.endDate = filterDateEnd;

            var result = await _homeService.LoadTabel(response);
            return View(result);
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
