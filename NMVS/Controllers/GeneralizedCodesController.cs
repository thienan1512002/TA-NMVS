using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NMVS.Models;
using NMVS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NMVS.Controllers
{
    public class GeneralizedCodesController : Controller
    {
        private readonly IGeneralizedCode _services;
        private readonly INotyfService _notyf;
        public GeneralizedCodesController(IGeneralizedCode services, INotyfService notyf)
        {
            _services = services;
            _notyf = notyf;
        }

        public ActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetAll()
        {
            return Json(await _services.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(GeneralizedCode code)
        {
            if (ModelState.IsValid)
            {
                if (await _services.Add(code))
                {
                    _notyf.Success("Generalized Code Created Successfully", 5);
                    return RedirectToAction("Index");
                }
            }
            ViewBag.ErrorMessage = "There are already existing that code named " + code.CodeFldName + " with value " + code.CodeValue;
            return View(code);
        }

        public async Task<ActionResult> Edit(int id)
        {
            GeneralizedCode code = await _services.GetById(id);
            return View(code);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Edit(GeneralizedCode code)
        {
            if (ModelState.IsValid)
            {
                if (await _services.Update(code))
                {
                    _notyf.Success("Update Code Successfully", 5);
                    return RedirectToAction("Index");
                }
            }
            ViewBag.ErrorMessage = "There are already existing that code named " + code.CodeFldName + " with value " + code.CodeValue;
            return View(code);
        }

        public async Task<ActionResult> Delete(int id)
        {
            if (await _services.Delete(id))
            {
                _notyf.Success("Delete Code Created Successfully", 5);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}