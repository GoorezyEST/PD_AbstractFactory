using AbstractFactory_PD.Abstract_Products;
using AbstractFactory_PD.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_PD.Factories
{
    //Concrete class implementing the ClothesFactory class and representing a casual clothes factory
    internal class CasualClothesFactory : ClothesFactory
    {
        //Overridden method for creating a Polo shirt
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        //Overridden method for creating jeans
        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
