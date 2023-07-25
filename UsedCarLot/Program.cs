using System.Xml;
using UsedCarLot;

Console.WriteLine("Hello, Welcome to the used car lot!");

List<Car> listCar = new List<Car>
{
    new Car($"chevrolet", "corvette", 2020, 59995m)
    new Car($"audi", "A4 premium", 2017, 26000m)
    new Car($"lamborghini", "Huracan", 2023, 212090m)
    new Car($"Buick", "Regal", 2003, 850m, 150000)
    new Car($"Ford", "Explorer", 2010, 8017m, 125000)
    new Car($"Honda", "accord", 2008, 2200m, 160500)
};