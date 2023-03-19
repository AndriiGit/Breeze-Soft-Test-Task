using Microsoft.AspNetCore.Mvc.RazorPages;
using Breeze_Soft_Test_Task.Domain;

namespace Breeze_Soft_Test_Task.Pages;

public class IndexModel : PageModel
{
    private readonly CarService _carService;
    public IndexModel(CarService carService)
    {
        _carService = carService;
    }

    public IList<Car> Cars { get;set; } = default!;

    public async Task OnGetAsync()
    {
        if (_carService != null)
        {
            var cars = await _carService.GetCarsAsync();
            Cars = cars.OrderBy(x=>x.Id).ToList();
        }
    }
}
