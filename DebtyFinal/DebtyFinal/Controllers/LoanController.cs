using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DebtyFinal.Controllers
{
    [Authorize]
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}