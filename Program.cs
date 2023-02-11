using AbstractFactory_PD.Factories;

namespace AbstractFactory_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client entreprenour = new Client(new ElegantClothesFactory());

            Console.WriteLine($"Entrepreneur: {entreprenour.DecribeYourClothes()}");

            Client student = new Client(new CasualClothesFactory());

            Console.WriteLine($"Student: {student.DecribeYourClothes()}");
        }
    }
}