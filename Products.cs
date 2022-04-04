using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Products
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void show()
        {
            Console.WriteLine("\nProduct part ...");
            foreach (string part in _parts)
             
                Console.WriteLine(part);    
             
        }
    }
}
