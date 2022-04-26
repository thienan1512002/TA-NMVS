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
using Newtonsoft.Json;
using NMVS.Models.ViewModels;

namespace NMVS.Controllers
{
    public class ItemDatasController : Controller
    {
        private readonly InItemData _services;
        private readonly IUploadReports _reports;
        private readonly INotyfService _notyf;

        private readonly ApplicationDbContext _db;
        public ItemDatasController(InItemData services, INotyfService notyf, IUploadReports reports, ApplicationDbContext db)
        {
            _services = services;
            _notyf = notyf;
            _reports = reports;
            _db = db;
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
        [HttpPost]
        public async Task<String> CreateByExcel(List<ItemData> items, string name)
        {
            UploadReport report = new UploadReport();
            int count = 0;
            List<int> indexErrors = new List<int>();
            String result = "fail";
            foreach (var item in items)
            {

                if (!String.IsNullOrEmpty(item.ItemNo) && !String.IsNullOrEmpty(item.ItemName) && !String.IsNullOrEmpty(item.ItemType) && !String.IsNullOrEmpty(item.ItemUm) && !String.IsNullOrEmpty(item.ItemPkgQty) && !String.IsNullOrEmpty(item.ItemPkg) && item.ItemWhUnit != 0)
                {
                    count++;
                    await _services.AddItemData(item);
                    result = "success";
                }
                else
                {
                    indexErrors.Add(items.IndexOf(item));

                }

            }
            report = Report(name, "Add Item Data", items.Count, count);
            await _reports.AddReport(report);
            foreach (var countError in indexErrors)
            {
                UploadError error = new UploadError();
                error.UploadId = report.Id;
                error.Error = "Error at line " + (countError + 2);
                await _reports.AddError(error);
            }

            return result;
        }
        public UploadReport Report(String name, String function, int length, int insert)
        {
            string user = "";
            if (User.Identity.IsAuthenticated)
            {
                user = _db.Users.FirstOrDefault(x => x.UserName == User.Identity.Name).FullName;
            }
            UploadReport uploadReport = new UploadReport();
            uploadReport.FileName = name;
            uploadReport.UploadTime = DateTime.Now;
            uploadReport.UploadBy = user;
            uploadReport.UploadFunction = function;
            uploadReport.TotalRecord = length;
            uploadReport.Inserted = insert;
            uploadReport.Updated = 0;
            uploadReport.Errors = uploadReport.TotalRecord - uploadReport.Inserted;
            return uploadReport;

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