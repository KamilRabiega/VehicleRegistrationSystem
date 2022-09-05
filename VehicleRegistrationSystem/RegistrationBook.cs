using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationSystem
{
    public class RegistrationBook
    {
        //List of vehicles property
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        //Void method, adding vehicle to list of vehicles
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        //Private void method, for display details about vehicle
        public void DisplayVehicleDetails(Vehicle vehicle)
        {
            //Example: 
            //Vehicle id: 0001, plate: FZA55555, owner is Marian Kowalski. 
            //Vehicle information: Opel Zafira, color Black, engine 1.9 TDI, 150hp.

            Console.WriteLine($"Vehicle id: {vehicle.IdVehicle}, plate: {vehicle.LicensePlate}, owner is {vehicle.OwnerFirstName} {vehicle.OwnerLastName}.");
            Console.WriteLine($"Vehicle information: {vehicle.VehicleManufacturer} {vehicle.VehicleModel}, " +
                $"color {vehicle.VehicleColor}, engine {vehicle.VehicleEngine}, {vehicle.VehicleHP}.");
        }

        //Private void method, for display details of vehicles
        private void DisplayVehiclesDetails(List<Vehicle> vehicles)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (var vehicle in vehicles)
            {
                DisplayVehicleDetails(vehicle);
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
        }

        //Void method, display vehicles by license plate
        public void DisplayVehicles(string licensePlate)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.LicensePlate == licensePlate);

            if (vehicle == null)
            {
                Console.WriteLine("License plate doesn't exist.");
            }
            else
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                DisplayVehicleDetails(vehicle);
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
        }

        //Void method, display all vehicles
        public void DisplayAllVehicles()
        {
            DisplayVehiclesDetails(Vehicles);
        }

        //Display by lastname
        public void DisplayByLastName(string searchPhrase)
        {
            var matchingLastName = Vehicles.Where(v => v.OwnerLastName.Contains(searchPhrase)).ToList();
            DisplayVehiclesDetails(matchingLastName);
        }

        public void DeleteRecord()
        {

        }
    }
}
