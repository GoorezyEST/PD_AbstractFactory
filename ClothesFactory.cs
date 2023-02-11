using AbstractFactory_PD.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_PD
{
    //Abstract class representing the Clothes Factory
    abstract class ClothesFactory
    {
        //Abstract method for creating a shirt
        public abstract Shirt CreateShirt();

        //Abstract method for creating trousers
        public abstract Trousers CreateTrousers();
    }
}
