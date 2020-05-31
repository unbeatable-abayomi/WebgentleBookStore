using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebgentleBookStore.Data
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public double Price { get; set; }
        public double Millage { get; set; }
    }
}
