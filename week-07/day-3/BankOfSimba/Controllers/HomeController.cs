﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        //private Client client;

        public static List<Client> BankAccounts = new List<Client>()
        {
            new Client("Pumbaa", 100, "Warthog"),
            new Client("Timon", 250, "Meerkat"),
            new Client("Rafiki", 1500, "Baboon"),
            new Client("Zazu", 456, "Red-billed Hornbill")
        };

        //public HomeController(Client client)
        //{
        //    this.client = client;
        //}

        [HttpGet("")]
        public IActionResult Index()
        {
            var bankAcc = new Client("Simba", 2000, "Lion")
            {
                King = true
            };
            BankAccounts.Add(bankAcc);

            return View(bankAcc);
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddAccount(Client client)
        {
            BankAccounts.Add(client);

            return RedirectToAction("/bank");
        }

        [HttpGet("bank")]
        public IActionResult Accounts()
        {
            return View(BankAccounts);
        }
    }
}
