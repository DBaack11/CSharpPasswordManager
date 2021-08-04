using CSharpFinal_PasswordManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFinal_PasswordManager.Controllers
{
    public class HomeController : Controller
    {
        private AccountContext context { get; set; }

        public HomeController(AccountContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var accounts = context.Accounts.OrderBy(a => a.Resource).ToList();
            return View(accounts);
        }
    }
}
