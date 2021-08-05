using CSharpFinal_PasswordManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFinal_PasswordManager.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext context { get; set; }

        public AccountController(AccountContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            ViewBag.Action = "Add";
            return View("Edit", new Account());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var account = context.Accounts.Find(id);
            
            return View(account);
        }

        [HttpPost]
        public IActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                account.setAccountUser(User.Identity.Name);
                if (account.AccountId == 0)
                {
                    context.Accounts.Add(account);
                    
                }
                else
                {
                    context.Accounts.Update(account);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (account.AccountId == 0) ? "Add" : "Edit";

                return View(account);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var account = context.Accounts.Find(id);
            return View(account);
        }

        [HttpPost]
        public IActionResult Delete(Account account)
        {
            context.Accounts.Remove(account);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
