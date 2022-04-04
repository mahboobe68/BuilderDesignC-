using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class ConcreteBuilder1 : Builder
    {   Products _products = new Products();   
        public override void BuilderA()
        {
            _products.Add("PartA");
        }

        public override void BuilderB()
        {
            _products.Add("PartB");
        }

        public override void BuilderC()
        {
            _products.Add("PartC");
        }

        public override Products GetProducts()
        {
            return _products;   
        }
    }
}
