﻿using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.Reviews
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Housing/Review/Index.cshtml");
        }
        public IActionResult Add()
        {
            return View("~/Views/Housing/Review/Add.cshtml");
        }
        //[HttpPost]
        //public IActionResult Add(Customer c)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        context.Customers.Add(c);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(c);
        //    }
        //}
    }
}
