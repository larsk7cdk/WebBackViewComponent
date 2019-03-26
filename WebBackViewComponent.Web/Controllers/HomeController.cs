using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBackViewComponent.Web.Services;

namespace WebBackViewComponent.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index([FromServices]ICarService carService) => View(await carService.GetCars());
    }
}