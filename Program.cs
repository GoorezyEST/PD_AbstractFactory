using AbstractFactory_PD.Factories;

namespace AbstractFactory_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the Client class and pass in an instance of the ElegantClothesFactory class
            Client entreprenour = new Client(new ElegantClothesFactory());

            //Output the description of the entrepreneur's clothes
            Console.WriteLine($"Entrepreneur: {entreprenour.DecribeYourClothes()}");

            //Create an instance of the Client class and pass in an instance of the CasualClothesFactory class
            Client student = new Client(new CasualClothesFactory());

            //Output the description of the student's clothes
            Console.WriteLine($"Student: {student.DecribeYourClothes()}");
        }
    }
}