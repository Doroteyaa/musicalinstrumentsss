using musicalinstruments.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicalinstruments.Controller
{
    public class InstrumentController
    {
        public List<Instrument> Instruments =new List<Instrument>();
        public string AddGuitar(string brand, string model, double price, int year)
        {
            Instruments.Add(new Guitar(brand,model, price, year));

            return "Guitar added";
        }
        public string AddPiano(string brand, string model, double price, int year)
        {
            Instruments.Add(new Piano(brand, model, price, year));
            return "Piano added";
        }
        public string AddDrums(string brand, string model, double price, int year)
        {
            Instruments.Add(new Drums(brand, model, price, year));
            return "Drums added";
        }
        public string AddViolin(string brand, string model, double price, int year)
        {
            Instruments.Add(new Violin(brand, model, price, year));
            return "Violin added";
        }
        public List<string> ListAll()
        {
            if (!Instruments.Any()) return new List<string> { "No instruments" };
            return Instruments.Select(x => x.ToString()).ToList();
        }
        public List<string> ShowGuitars()
        {
            var guitars=Instruments.Where(x=>x is Guitar).ToList();
            if (!guitars.Any()) return new List<string> { "No guitars" };
            return guitars.Select(x => x.ToString()).ToList();
        }
        public List<string> ShowPiano()
        {
            var guitars = Instruments.Where(x => x is Piano).ToList();
            if (!guitars.Any()) return new List<string> { "No pianos" };
            return guitars.Select(x => x.ToString()).ToList();
        }
        public List<string> ShowDrums()
        {
            var guitars = Instruments.Where(x => x is Drums).ToList();
            if (!guitars.Any()) return new List<string> { "No Drums" };
            return guitars.Select(x => x.ToString()).ToList();
        }
        public List<string> ShowViolins()
        {
            var guitars = Instruments.Where(x => x is Violin).ToList();
            if (!guitars.Any()) return new List<string> { "No violins" };
            return guitars.Select(x => x.ToString()).ToList();
        }
        public List<string> Alltypes()
        {
            if (!Instruments.Any()) return new List<string> { "No instruments" };
            return Instruments.Select(x => x.Type()).ToList();
        }
        public string Delete(string model)
        {
            var ins=Instruments.FirstOrDefault(x=>x.Model==model);
            if (ins == null) return $"No instrument with this model";
            else if (ins is Guitar)
            {
                Instruments.Remove(ins);
                return "Guitar deleted";
            }
            else if (ins is Piano)
            {
                Instruments.Remove(ins);
                return "Piano deleted";
            }
            else if (ins is Drums)
            {
                Instruments.Remove(ins);
                return "Drums deleted";
            }
            else 
            {
                Instruments.Remove(ins);
                return "Violin deleted";
            }
        }
        public string MostEx()
        {
            var c=Instruments.OrderByDescending(x=>x.Price).ToList();
            var s = c.Select(x => x.ToString()).ToList();
            return $"{s[0]}";
        }
        public List<string> Year()
        {
            var c=Instruments.Where(x=>x.Year>2000).ToList();
            return c.Select(x=>x.ToString()).ToList();
        }
    }
}
