using ARD.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARD.Controllers
{
    public class BlocksController : Controller
    {
        private readonly IBlocksService _service;

        public BlocksController(IBlocksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _service.GetAll();
            return View(Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,X,Y,Z")]WatchedPosition watchedPosition)
        {
            if (!ModelState.IsValid)
            {
                return View(watchedPosition);
            }
            _service.Add(watchedPosition);
            return RedirectToAction(nameof(Index));
        }
    }
}