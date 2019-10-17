using Microsoft.AspNetCore.Mvc;
namespace PortfolioProject

{
public class HomeController : Controller
  {
    [HttpGet("")]
    public string Index()
    {
      return "Hello from index";
    } 
  }
}