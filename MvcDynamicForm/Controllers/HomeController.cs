using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDynamicForm.DataBase;
using MvcDynamicForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDynamicForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(MyData.MyFormData);
        }


        [HttpPost]
        public ActionResult SaveForm(string jsonInput = "")
        {
            var reqObj = JsonConvert.DeserializeObject<List<FormFiedlsModel>>(jsonInput);
            MyData.SaveData(reqObj);
            return Ok(true);
        }
    }
}
