using Microsoft.AspNetCore.Mvc;
using CarPage.Models;
using System.Linq;

namespace CarPage.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly CarContext _context;

        public PurchaseController(CarContext context)
        {
            _context = context;
        }

        public IActionResult Index(int carId)
        {
            var car = _context.Cars.FirstOrDefault(c => c.Id == carId);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        [HttpPost]
        public IActionResult Message()
        {
            ViewBag.Message = "Your purchase request has been submitted successfully! We will contact you about payment details. Thanks for choosing us!";
            return View();
        }
    }
}