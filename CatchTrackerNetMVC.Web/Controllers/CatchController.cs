using CatchTrackerNetMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatchTrackerNetMVC.Web.Controllers;

public class CatchController
{
    [HttpGet][HttpPost]
    public IActionResult Add(AddCatchViewModel? model)
    {
        if (model != null)
        {
            
        }
        else
        {
            
        }
    }
    
   
    
}