//
using VehicleRegistrationSystem;

Console.WriteLine("Welcome, this is Vehicle Registration System.");
Console.WriteLine("");

Console.WriteLine("Press 1 to register new vehicle to our system.");
Console.WriteLine("Press 2 to search by license plate.");
Console.WriteLine("Press 3 to display information about all vehicles in our system.");
Console.WriteLine("Press 4 to search by last name.");

var menuInput = Console.ReadLine();
var registrationBook = new RegistrationBook();

switch(menuInput)
{
    case "1":
        Console.WriteLine("Adding a new vehice to our system.");

        Console.WriteLine("Please type id: ");
        var id = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please type License Plate: ");
        var plate = Console.ReadLine();
        Console.WriteLine("Please type first name: ");
        var fname = Console.ReadLine();
        Console.WriteLine("Please type last name: ");
        var lname = Console.ReadLine();
        Console.WriteLine("Please type manufacturer: ");
        var manufacturer = Console.ReadLine();
        Console.WriteLine("Please type model: ");
        var model = Console.ReadLine();
        Console.WriteLine("Please type color: ");
        var color = Console.ReadLine();
        Console.WriteLine("Please type engine: ");
        var engine = Console.ReadLine();
        Console.WriteLine("Please type HP: ");
        var horsepower = Console.ReadLine();

        var newVehicle = new Vehicle(id, plate, fname, lname, manufacturer, model, color, engine, horsepower);

        registrationBook.AddVehicle(newVehicle);

        registrationBook.DisplayVehicleDetails(newVehicle);
        break;

    case "2":

        break;

    case "3":

        break;

    case "4":

        break;

    default:
        Console.WriteLine("You need to type numbers 1-4, invalid number.");
        break;
}