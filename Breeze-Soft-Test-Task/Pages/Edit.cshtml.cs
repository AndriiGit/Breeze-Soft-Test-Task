using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Breeze_Soft_Test_Task.Domain;

namespace Breeze_Soft_Test_Task.Pages;

public class EditModel : PageModel
{
    private readonly CarService _carService;
    public EditModel(CarService carService)
    {
        _carService = carService;
    }

    [BindProperty]
    public Car Car { get; set; } = default!;

    [BindProperty]
    public IFormFile? ImageFile { get; set; }

    [BindProperty]
    public byte[] Photo { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int id)
    {
        if (_carService != null)
        {
            var car = await _carService.FindByIdAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            Car = car;
            Photo = car.Image;
        }
        return Page();
    }

    public async Task<IActionResult> OnPostSave()
    {
        try
        {
            Car.Image = Photo;
            await _carService.UpdateCar(Car);
        }
        catch (Exception)
        {
            throw;
        }

        return RedirectToPage("./Index");
    }
    public async Task<IActionResult> OnPostUpload()
    {
        ModelState.Remove(nameof(Photo));
        if (ImageFile != null)
        {
            using (var memoryStream = new MemoryStream())
            {
                await ImageFile.CopyToAsync(memoryStream);
                Car.Image = memoryStream.ToArray();
            }
        }
        Photo = Car.Image;
        return Page();
    }
}
