using Microsoft.AspNetCore.Mvc;
namespace PortfolioProject

{
public class HomeController : Controller
  {
    // START CONTROLLER //
   //////////////////////
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    } 

    [HttpGet("projects")]
    public ViewResult Projects()
    {
      return View();
    } 

    [HttpGet("Contact")]
    public ViewResult Contact()
    {
      return View();
    } 


     ////////////////////
    // END CONTROLLER //
  }
}