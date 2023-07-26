using CircleLab;
using System.Xml;
using UsedCarLot;

Console.WriteLine("Hello, Welcome to the used car lot!");

List<Car> listCar = new List<Car>
{
    new Car($"chevrolet", "corvette", 2020, 59995m),
    new Car($"audi", "A4 premium", 2017, 26000m),
    new Car($"lamborghini", "Huracan", 2023, 212090m),
    new UsedCar($"Buick", "Regal", 2003, 850m, 150000),
    new UsedCar($"Ford","Explorer", 2010, 8017m, 125000),
    new UsedCar($"Honda", "accord", 2008, 2200m, 160500)
};

//main code
//looping
bool runProgram = true;
while (runProgram)
{

    //Console.WriteLine("\nSelect a car from the list:");
    //listCar.ForEach(c => Console.WriteLine(c));


    DisplayMenu(listCar);


    int menuChoice = -1;
    while (menuChoice <= -1 || menuChoice >= listCar.Count + 2)
{
        Console.WriteLine($"Choose a menu option. 0 - {listCar.Count + 1}");
        while (int.TryParse(Console.ReadLine(), out menuChoice) == false)
        {
            Console.WriteLine("Incorrect Format");
        }
    }

    // buying car
    if (menuChoice < listCar.Count)
    {
        Car carChoice = listCar[menuChoice];
        if (BuyCar(carChoice) == true)
        {
            listCar.Remove(carChoice);
            Console.WriteLine("Our finance team will reach out to you shortly");
        }
        else
        {
            Console.WriteLine("Feel free to keep looking around");
        }
    }
    //adding car
    else if (menuChoice == listCar.Count)
    {
        Car newCar = AddCar();
        listCar.Add(newCar);
    }
    //quitting
    else if (menuChoice == listCar.Count + 1)
    {
        runProgram = false;
    }
}


//methods

static bool BuyCar(Car c)
{
    Console.WriteLine("Would you like to buy this car? y/n");
    Console.WriteLine(c);
    string buyChoice = Console.ReadLine();
    if (buyChoice == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static Car AddCar()
{
    //pretend these are all validated
    Console.WriteLine("What is the car's make?");
    string make = Console.ReadLine();
    Console.WriteLine("What is the car's model?");
    string model = Console.ReadLine();
    Console.WriteLine("What is the car's year?");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the car's price?");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Is the car used? y/n");
    string used = Console.ReadLine();
    if (used == "y")
    {
        Console.WriteLine("What is the used car's mileage?");
        double mileage = double.Parse(Console.ReadLine());

        return new UsedCar(make, model, year, price, mileage);
    }
    else
    {
        return new Car(make, model, year, price);
    }
}
static void DisplayMenu(List<Car> allCars)
{
    for (int i = 0; i < allCars.Count; i++)
    {
        Console.WriteLine($"{i}. {allCars[i]}");
    }
    Console.WriteLine($"{allCars.Count}. Add Car");
    Console.WriteLine($"{allCars.Count + 1}. Quit");
}

