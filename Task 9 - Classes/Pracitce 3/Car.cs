using System;
using System.Collections.Generic;
using System.Text;

namespace Pracitce_3
{
    internal class Car
    {
        public int modelNumber { get; set; }
        public string brand { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }

        public Car()
        {
        }
        public Car(int modelNumber, string brand, int year, decimal price)
        {
            this.modelNumber = modelNumber;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

     

    }
}
