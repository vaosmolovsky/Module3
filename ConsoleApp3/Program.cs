namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            var name = (Console.ReadLine());
            Console.Write("Введите ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и вас {1} лет ", name, age);
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.Write("Ваша дата рождения {0}", birthdate);
            Console.ReadKey();

        }
    }
}


