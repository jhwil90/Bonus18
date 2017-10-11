using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {
        //Members
        protected string carMake;
        private string carModel;
        private int carYear;
        private double carPrice;
        
        // property
        public string Make
        {
            set { Make = value; }
            get { return Make; }

        }

        public string Model
        {
            set { Model = value; }
            get { return Model; }
        }

        public int Year
        {
            set { Year = value; }
            get { return Year; }
        }

        public double Price
        {
            set { Price = value; }
            get { return Price; }
        }


        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
            
        }

        public Car(string CarMake, string CarModel, int CarYear, double CarPrice)
        {
            CarMake = Make;
            CarModel = Model;
            CarYear = Year;
            CarPrice = Price;
            


        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Make.PadRight(8, ' ') + "\t" + Model.PadRight(8, ' ') + "\t" + Year.ToString().PadRight(8, ' ') + "\t" + "$" + Price.ToString("N2"));
        }
    }
}
