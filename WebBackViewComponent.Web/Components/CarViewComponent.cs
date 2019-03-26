using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBackViewComponent.Web.Models;

namespace WebBackViewComponent.Web.Components
{
    public class CarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CarViewModel model) => View(model);
    }
}