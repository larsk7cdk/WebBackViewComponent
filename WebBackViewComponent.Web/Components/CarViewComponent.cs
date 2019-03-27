using Microsoft.AspNetCore.Mvc;
using WebBackViewComponent.Web.Models;

namespace WebBackViewComponent.Web.Components
{
    public class CarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CarViewModel model) => View(model);
    }
}