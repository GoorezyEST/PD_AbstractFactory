using AbstractFactory_PD.Abstract_Products;
using AbstractFactory_PD.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_PD.Factories
{
    //Concrete class implementing the ClothesFactory class and representing an elegant clothes factory
    internal class ElegantClothesFactory : ClothesFactory
    {
        //Overridden method for creating a Dress shirt
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        //Overridden method for creating Suit trousers
        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
