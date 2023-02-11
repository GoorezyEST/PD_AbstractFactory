using AbstractFactory_PD.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_PD
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        public string DecribeYourClothes()
        {
            return $"Today I'm dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }
    }
}
