using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    internal class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //constructor
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }
        public Car()
        {
            Make = "Cardboard";
            Model = "b0xx";
            Year = DateTime.Now.Year;
            Price = .50m;
        }

        //method
        public override string ToString()
        {
            return $"{Year}\t{Make}\t{Model}\t${Price}";
        }
    }
}
