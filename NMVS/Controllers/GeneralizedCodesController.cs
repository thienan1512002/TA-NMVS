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
        public GeneralizedCodesController(IGeneralizedCode services)
        {
            _services = services;
        }

        public async Task<JsonResult> GetAll()
        {
            return Json(await _services.GetAll());
        }
    }
}