using System.Collections.Generic;
using System.Threading.Tasks;
using WebBackViewComponent.Web.Models;

namespace WebBackViewComponent.Web.Services
{
    public interface ICarService
    {
        Task<IEnumerable<CarViewModel>> GetCars();
    }

    public class CarService : ICarService
    {
        private readonly IList<CarViewModel> _cars = new List<CarViewModel>
        {
            new CarViewModel
            {
                Header = "Velholdt og som ny",
                Type = "BMW 320d",
                Model = "2,0 Gran Turismo aut. 5d",
                Year = 2017,
                Kilometers = 17000,
                Price = 399900,
                Image = "~/images/car_001.jpg"
            },
            new CarViewModel
            {
                Header = "Bilen til hele familien",
                Type = "Ford Focus",
                Model = "1,0 SCTi 125 5d",
                Year = 2017,
                Kilometers = 3000,
                Price = 224800,
                Image = "~/images/car_002.jpg"
            },
            new CarViewModel
            {
                Header = "Velholdt og nysynet",
                Type = "Skoda Citigo",
                Model = "1,0 60 Style GreenTec 5d",
                Year = 2016,
                Kilometers = 79000,
                Price = 74800,
                Image = "~/images/car_003.jpg"
            }
        };

        public async Task<IEnumerable<CarViewModel>> GetCars() => await Task.FromResult(_cars);
    }
}