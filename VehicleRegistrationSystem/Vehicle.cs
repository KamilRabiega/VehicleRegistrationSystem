using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationSystem
{
    //This class is pattern for "Vehicle" object
    public class Vehicle
    {
        //Constructors
        public Vehicle(int id, string plate, string firstName, string lastName, 
            string manufacturer, string model, string color, string engine, string hp)
        {
            IdVehicle = id;
            LicensePlate = plate;
            OwnerFirstName = firstName;
            OwnerLastName = lastName;
            VehicleManufacturer = manufacturer;
            VehicleModel = model;
            VehicleColor = color;
            VehicleEngine = engine;
            VehicleHP = hp;
        }
        //Getters & Setters
        public int IdVehicle { get; set; }
        public string LicensePlate { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string VehicleManufacturer { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleEngine { get; set; }
        public string VehicleHP { get; set; }
    }
}
