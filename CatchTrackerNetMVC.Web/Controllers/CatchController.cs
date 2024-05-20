using CatchTrackerNetMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatchTrackerNetMVC.Web.Controllers;

public class CatchController: Controller
{
    [HttpGet][HttpPost]
    public IActionResult Add(AddCatchViewModel? model)
    {
        if (model == null || !ModelState.IsValid)
        {
            return View();
        }

        return View();
    }
    
}