//
using VehicleRegistrationSystem;

Console.WriteLine("Welcome, this is Vehicle Registration System.");
Console.WriteLine("");

Console.WriteLine("Press 1 to register new vehicle to our system.");
Console.WriteLine("Press 2 to search by license plate.");
Console.WriteLine("Press 3 to display information about all vehicles in our system.");
Console.WriteLine("Press 4 to search by last name.");
Console.WriteLine("Press x button to exit.");

var menuInput = Console.ReadLine();
var registrationBook = new RegistrationBook();

while(true)
{
    switch (menuInput)
    {
        case "1":
            Console.WriteLine("Adding a new vehice to our system.");
            Console.WriteLine("");

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

            Console.WriteLine("");
            Console.WriteLine("A new vehicle has been successfully added to the system.");
            registrationBook.DisplayVehicleDetails(newVehicle);
            Console.WriteLine("");
            break;

        case "2":
            Console.WriteLine("Searching by license plate.");
            Console.WriteLine("");
            Console.WriteLine("Type license plate: ");
            var plateSearch = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("The vehicle was found using the license plate.");
            registrationBook.DisplayVehicles(plateSearch);
            Console.WriteLine("");
            break;

        case "3":
            Console.WriteLine("");
            Console.WriteLine("All vehicles from our system.");

            Console.WriteLine("");
            registrationBook.DisplayAllVehicles();
            Console.WriteLine("");

            break;

        case "4":
            Console.WriteLine("");
            Console.WriteLine("Searching by owner last name.");
            Console.WriteLine("");
            Console.WriteLine("Type last name: ");

            var inputLastName = Console.ReadLine();

            registrationBook.DisplayByLastName(inputLastName);

            break;

        case "x":
            return;

        default:
            Console.WriteLine("You need to type numbers 1-4, invalid number.");
            break;
    }
    Console.WriteLine("Press 1 to register new vehicle to our system.");
    Console.WriteLine("Press 2 to search by license plate.");
    Console.WriteLine("Press 3 to display information about all vehicles in our system.");
    Console.WriteLine("Press 4 to search by last name.");
    Console.WriteLine("Press x button to exit.");
    menuInput = Console.ReadLine();
}