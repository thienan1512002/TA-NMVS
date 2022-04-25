using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NMVS.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NMVS.Models;

namespace NMVS.Controllers
{
    public class ItemDatasController : Controller
    {
        private readonly InItemData _services;
        public ItemDatasController(InItemData services)
        {
            _services = services;
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<JsonResult> GetItemData()
        {
            return Json(await _services.GetAllItemData());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ItemData itemData)
        {
            if (itemData.Active == null)
            {
                itemData.Active = false;
            }

            if (itemData.Flammable == null)
            {
                itemData.Flammable = false;
            }

            if (ModelState.IsValid)
            {
                if (await _services.AddItemData(itemData))
                {
                    return RedirectToAction("Index");
                }
            }

            return View(itemData);
        }
    }
}