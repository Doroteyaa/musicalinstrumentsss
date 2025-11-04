using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicalinstruments.Model
{
    public abstract class Instrument
    {
        protected Instrument(string brand,string model, double price, int year)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Year = year;
        }

        public string Brand {  get; set; }
        public string Model {  get; set; }
        public double Price {  get; set; }
        public int Year {  get; set; }

        public abstract string Type();
        public override string ToString()
        {
            return $"{Brand}: {Price} euro ,{Year} year";
        }
    }
}
