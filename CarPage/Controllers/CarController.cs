using CarPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CarPage.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;
        private readonly IServiceProvider _serviceProvider;

        public CarController(CarContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }
        public IActionResult Details(int id)
        {
            var car = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
           {
            return NotFound();
           }
            return View(car);
        }

        public IActionResult Index()
        {
            SeedData.Initialize(_serviceProvider);
            return View(_context.Cars.ToList());
        }
        
        
        
    }
}