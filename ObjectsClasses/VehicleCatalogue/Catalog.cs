using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePowers { get; set; }
    }

    class Catalog
    {
        static void Main()
        {
            List<Vehicle> vehicles = GetCarsTrucks();
            PrintVehiclesData(vehicles);
        }

        static void PrintVehiclesData(List<Vehicle> vehicles)
        {
            while (true)
            {
                string currentVehicle = Console.ReadLine();

                if (currentVehicle == "Close the Catalogue")
                {
                    PrintVehiclesStat(vehicles);
                    break;
                }

                Console.Write(String.Join("", vehicles.Where(s => s.Model == currentVehicle)
                                                                   .Select(s=>$"Type: {s.Type}" + Environment.NewLine + 
                                                                                $"Model: {s.Model}" + Environment.NewLine +
                                                                                $"Color: {s.Color}" + Environment.NewLine +
                                                                                $"Horsepower: {s.HorsePowers:f0}" + Environment.NewLine)));
            }
        }

        static void PrintVehiclesStat(List<Vehicle> vehicles)
        {
            double carAvgHorsePowers = 0.00;
            double truckAvgHorsePowers = 0.00;
            try
            {
                carAvgHorsePowers = vehicles.Where(s => s.Type == "Car").Average(d => d.HorsePowers);
            }
            catch { }
            try
            {
                truckAvgHorsePowers = vehicles.Where(s => s.Type == "Truck").Average(d => d.HorsePowers);
            }
            catch { }

            Console.WriteLine($"Cars have average horsepower of: {carAvgHorsePowers:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvgHorsePowers:f2}.");
        }

        static List<Vehicle> GetCarsTrucks()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string[] currentVehicle = Console.ReadLine().Split(' ').ToArray();
                if (currentVehicle[0] == "End")
                {
                    break;
                }

                Vehicle vehi = new Vehicle()
                {
                    Type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(currentVehicle[0].ToLower()),
                    Model = currentVehicle[1],
                    Color = currentVehicle[2],
                    HorsePowers = double.Parse(currentVehicle[3])
                };

                vehicles.Add(vehi);
            }

            return vehicles;
        }
    }
}
