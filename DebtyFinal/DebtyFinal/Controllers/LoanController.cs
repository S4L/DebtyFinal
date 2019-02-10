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
        private PersonLogic personLogic;

        public LoanController()
        {
            loanLogic = new LoanLogic();
            personLogic = new PersonLogic();
        }

        public IActionResult Index()
        {
            var userName = HttpContext.User.Identity.Name;
            var id = personLogic.GetPersonIDByUserName(userName);
            var loans = loanLogic.GetLoans(id);
            return View();
        }
    }
}