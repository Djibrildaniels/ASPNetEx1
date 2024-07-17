using Microsoft.AspNetCore.Mvc;

namespace OdysseyASPex1.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        
        
        return View();
    }
}