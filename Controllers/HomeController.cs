using Microsoft.AspNetCore.Mvc;
namespace PortfolioProject

{
public class HomeController : Controller
  {
    // START CONTROLLER //
   //////////////////////
    [HttpGet("")]
    public string Index()
    {
      return "This is my Index!";
    } 

    [HttpGet("projects")]
    public string Projects()
    {
      return "This are my Projects!";
    } 

    [HttpGet("Contact")]
    public string Contact()
    {
      return "This is my Contact!";
    } 


     ////////////////////
    // END CONTROLLER //
  }
}