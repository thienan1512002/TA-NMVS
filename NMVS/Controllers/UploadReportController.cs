using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NMVS.Models;
using NMVS.Services;

namespace NMVS.Controllers
{
    public class UploadReportController : Controller
    {
        private readonly IUploadReports _services;
        public UploadReportController(IUploadReports services)
        {
            _services = services;
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<JsonResult> GetReports()
        {
            var reports = await _services.GetAllReports();
            return Json(reports);
        }

        public async Task<ActionResult> Details(int id)
        {
            UploadReport report = await _services.GetReportById(id);
            return View(report);
        }
        //Testing

        public async Task<ActionResult> Create()
        {
            UploadError error = new UploadError();
            error.UploadId = 1;
            error.Error = "Demo Error";
            Boolean result = await _services.AddError(error);
            return RedirectToAction("Index");
        }
    }
}