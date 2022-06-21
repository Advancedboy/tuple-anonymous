using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var product = new
            {
                Name = "Milk",
                Energy = 42,
            };

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var product2 = new
            {
                eat.Name,
                Energy = 200,
            };

            Console.WriteLine(product2);

            Tuple<int, string> tuple = new Tuple<int, string>(5, "Five");
            Console.WriteLine(tuple.Item1);

            var tuple2 = (1, "one");
            var tuple3 = (Name: "Anastasia", Age: 15);
            tuple3.Name = "Pavel";
            tuple3.Age = 16;
            Console.WriteLine(tuple3.Name);

            Console.WriteLine(GetData());

            Console.ReadLine();
        }

        public static (int number, string name, bool isNormal) GetData()
        {
            var number = 3425;
            var name = "Serzh";
            var isNormal = true;
            return (number, name, isNormal);
        }
    }
}
