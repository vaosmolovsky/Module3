namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Влад";
            byte myAge = 29;
            bool myPet = true;
            double mySize = 44.5; 
             
            Console.WriteLine("Меня зовут " + myName);
            Console.WriteLine("Мне {0} лет",myAge);
            Console.WriteLine("Если ли у вас питомец? " +myPet);
            Console.WriteLine("У меня {0} размер ноги",mySize);
            Console.ReadKey();
        }
    }
}


