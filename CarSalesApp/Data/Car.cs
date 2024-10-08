using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarSalesApp.Data
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public Fuel Fuel { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Sold { get; set; }

        // Default Constructor
        public Car()
        {
            Name = string.Empty;
            Manufacturer = string.Empty;
        }

        public Car(int id, string name, string manufacturer, int year, Fuel fuel, 
            double price, DateTime dateAdded, bool sold) 
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
            Fuel = fuel;
            Price = price;
            DateAdded = dateAdded;
            Sold = sold;
        }

        // Methods
        public override string ToString()
        {
            var str = Id + ": " + Manufacturer + " - " + Name + "(" + Year + ") £" 
                + Price + " " + Fuel + "(" + DateAdded.ToShortDateString() + ")";

            if (Sold)
            {
                str = str + " **";
            };
            return str;
        }
    }
}
