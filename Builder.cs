using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A abstract class
namespace BuilderDesignPattern
{
    abstract class Builder
    {

        public abstract void BuilderA();
        public abstract void BuilderB();    
        public abstract void BuilderC();    
        public abstract Products GetProducts(); 


    }
}
