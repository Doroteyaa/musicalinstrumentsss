using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicalinstruments.Model
{
    public class Drums : Instrument
    {
        public Drums(string brand, string model, double price, int year) : base(brand, model, price, year)
        {
        }

        public override string Type() => "Percussion instrument";
        
        
    }
}
