using AbstractFactory_PD.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_PD
{
    //Concrete class that uses the abstract factory pattern to create objects
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        //Constructor that takes in a ClothesFactory and uses it to create instances of Shirt and Trousers
        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        //Method that returns a string describing the client's clothes
        public string DecribeYourClothes()
        {
            return $"Today I'm dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }
    }
}
