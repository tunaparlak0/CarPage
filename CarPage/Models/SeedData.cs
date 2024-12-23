using CarPage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CarPage.Models
{
    public static class SeedData // veritabanını başlangıç verileriyle doldurmak için kullanılan sınıf
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarContext(
                serviceProvider.GetRequiredService<DbContextOptions<CarContext>>()))
            {
                // Look for any cars.
                if (context.Cars.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cars.AddRange(
                    new Car { Make = "Renault", Model = "Clio", Year = 2020, Price = 20000, Description = "Reliable and fuel-efficient. Perfect for city driving.", ImageUrl = "/images/clio.jpg", VehicleStatus = "Second Hand", Transmission = "Manual", FuelType = "Diesel", Color = "Orange", EnginePower = "130 HP" },
                    new Car { Make = "Mercedes", Model = "Benz", Year = 2019, Price = 35000, Description = "Compact and sporty. A true luxury experience.", ImageUrl = "/images/mercedes.jpg", VehicleStatus = "Brand New", Transmission = "Automatic", FuelType = "Gasoline", Color = "Black", EnginePower = "150 HP" },
                    new Car { Make = "Tesla", Model = "Y", Year = 2021, Price = 42000, Description = "Powerful and stylish. Leading the way in electric vehicles.", ImageUrl = "/images/elektrikli.jpg", VehicleStatus = "Brand New", Transmission = "Automatic", FuelType = "Electric", Color = "Gray", EnginePower = "200 HP" },
                    new Car { Make = "Volkswagen", Model = "Beetle", Year = 1992, Price = 16000, Description = "Classic and timeless. A piece of automotive history.", ImageUrl = "/images/klasik.jpg", VehicleStatus = "Second Hand", Transmission = "Manual", FuelType = "Gasoline", Color = "Yellow", EnginePower = "90 HP" },
                    new Car { Make = "Opel", Model = "Corsa", Year = 2021, Price = 23000, Description = "Compact and efficient. Ideal for everyday use.", ImageUrl = "/images/opel.jpg", VehicleStatus = "Second Hand", Transmission = "Manual", FuelType = "Gasoline", Color = "Red", EnginePower = "120 HP" },
                    new Car { Make = "Ferrari", Model = "SF90", Year = 2018, Price = 60000, Description = "Powerful and stylish. Experience the thrill of driving.", ImageUrl = "/images/sport.jpg", VehicleStatus = "Brand New", Transmission = "Automatic", FuelType = "Gasoline", Color = "Orange", EnginePower = "300 HP" },
                    new Car { Make = "BMW", Model = "X5", Year = 2020, Price = 40000, Description = "Luxury and performance. Perfect for long drives.", ImageUrl = "/images/bmw.jpeg", VehicleStatus = "Brand New", Transmission = "Automatic", FuelType = "Gasoline", Color = "Blue", EnginePower = "250 HP" },
                    new Car { Make = "Audi", Model = "A4", Year = 2019, Price = 30000, Description = "Elegant and efficient. A blend of style and performance.", ImageUrl = "/images/audi.jpeg", VehicleStatus = "Second Hand", Transmission = "Automatic", FuelType = "Diesel", Color = "White", EnginePower = "190 HP" },
                    new Car { Make = "Toyota", Model = "Corolla", Year = 2020, Price = 22000, Description = "Reliable and economical. A favorite among families.", ImageUrl = "/images/corolla.jpeg", VehicleStatus = "Brand New", Transmission = "Automatic", FuelType = "Hybrid", Color = "Silver", EnginePower = "121 HP" },
                    new Car { Make = "Ford", Model = "Mustang", Year = 2018, Price = 45000, Description = "Iconic and powerful. Feel the power of a true muscle car.", ImageUrl = "/images/mustang.jpeg", VehicleStatus = "Second Hand", Transmission = "Manual", FuelType = "Gasoline", Color = "Red", EnginePower = "450 HP" }
    
                    );
                context.SaveChanges();
            }
        }
    }
}