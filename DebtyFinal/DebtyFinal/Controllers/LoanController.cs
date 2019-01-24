using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtyFinal.Logics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DebtyFinal.Controllers
{
    [Authorize]
    public class LoanController : Controller
    {
        private LoanLogic loanLogic;

        public LoanController()
        {
            loanLogic = new LoanLogic();
        }

        public IActionResult Index()
        {
            var userID = User.Identity.Name;
            //var loans = loanLogic.GetLoansByUserID();
            return View();
        }
    }
}