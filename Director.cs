using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
     class Director
    {
       public void Build(Builder builder)
        {
            builder.BuilderA();
            builder.BuilderB(); 
            builder.BuilderC();

        }
    }
}
