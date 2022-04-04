using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class ConcreteBuilder2 : Builder
    {
        Products _products = new Products(); 
        public override void BuilderA()
        {
            _products.Add("PartA2");
        }

        public override void BuilderB()
        {
            _products.Add("PartB2");
        }

        public override void BuilderC()
        {
            _products.Add("PartC2");
        }

        public override Products GetProducts()
        {
            return _products;
        }
    }
}
