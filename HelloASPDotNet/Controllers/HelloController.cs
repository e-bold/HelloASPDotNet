﻿using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet;



public class HelloController : Controller 
{
    // GET: /hello
[HttpGet]
   public IActionResult Index() 
   {
      return View();
   }


    [HttpPost("/hello")]
    public IActionResult Welcome(string name)
    {
        ViewBag.person =name;
        return View();
    }
 

}