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
using AspNetCoreHero.ToastNotification.Abstractions;

namespace NMVS.Controllers
{
    public class ItemDatasController : Controller
    {
        private readonly InItemData _services;
        private readonly INotyfService _notyf;
        public ItemDatasController(InItemData services, INotyfService notyf)
        {
            _services = services;
            _notyf = notyf;
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
                    _notyf.Success("Item Data Created Successfully", 5);
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.ErrorMessage = "There are already Item that have code : " + itemData.ItemNo + " with name : " + itemData.ItemName;
                }
            }

            return View(itemData);
        }

        public async Task<ActionResult> Edit(int id)
        {
            ItemData model = await _services.GetItemDataById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ItemData itemData)
        {
            if (ModelState.IsValid)
            {
                if (itemData.Active == null)
                {
                    itemData.Active = false;
                }
                if (itemData.Flammable == null)
                {
                    itemData.Flammable = false;
                }
                if (await _services.UpdateItemData(itemData))
                {
                    _notyf.Success("Item Data Updated Successfully", 5);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = "There are already Item that have code : " + itemData.ItemNo + " with name : " + itemData.ItemName;
                }
            }
            return View(itemData);
        }
    }
}