namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Влад";
            byte age = 29;
            bool myPet = true;
            double mySize = 44.5;
            string favcolor = "black";

            Console.WriteLine("\tПривет, \n мир!");
            Console.WriteLine();
            Console.WriteLine("Меня зовут " + name);
            Console.WriteLine($"Мой возраст {age}");
            Console.WriteLine("Если ли у вас питомец? " +myPet);
            Console.WriteLine("У меня {0} размер ноги",mySize);
            Console.WriteLine();
            Console.WriteLine("{0}\n\t {1}\n\t{2}", name,age,favcolor);
            String str = Console.ReadLine();
            Console.WriteLine(""+str);

            Console.ReadKey();
        }
    }
}


