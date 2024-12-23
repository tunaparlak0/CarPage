namespace CarPage.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } 
        public string VehicleStatus { get; set; } = string.Empty;
        public string Transmission { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string EnginePower { get; set; } = string.Empty;

    
    }
}