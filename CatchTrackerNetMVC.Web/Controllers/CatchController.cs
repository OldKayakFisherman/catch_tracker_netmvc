using CatchTrackerNetMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using CatchTrackerNetMVC.Web.Data.Repositories; 

namespace CatchTrackerNetMVC.Web.Controllers;

public class CatchController: Controller
{
    private readonly CatchRepository _catchRepository;
    
    public CatchController(
        CatchRepository catchRepository,
        StatsRepository statsRepository
        )
    {
        _catchRepository = catchRepository;
    }
    
    
    [HttpGet][HttpPost]
    public IActionResult Add(AddCatchViewModel? model)
    {
        if (model == null)
        {
            return View();
        }
        else
        {
            if (ModelState.IsValid)
            {
                //Save the model
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
    }
    
}