using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtyFinal.Interfaces;
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

        public LoanController(ILoan loanLogic)
        {
            loanLogic = loanLogic;

            logger.asda();

            loanLogic.AddLoan();
        }

        public IActionResult Index()
        {
            var userID = Http
            var loans = loanLogic.GetLoansByUserID();
            return View();
        }
    }
}