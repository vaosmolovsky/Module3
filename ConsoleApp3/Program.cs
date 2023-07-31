namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
              string? str = Console.ReadLine();
              Console.WriteLine(""+str);
              int counter = 10;
              Console.WriteLine("Value: {0} Increment: {1}", counter, --counter);
              double result = 10 % 3;
              Console.WriteLine("Value: {0}", result);
              Console.WriteLine();
              Console.Write("Введите Ваш возраст ");
              int ages;
              bool iscorrect = int.TryParse(Console.ReadLine(), out ages);
              Console.WriteLine("Оказывается Ваш возраст {0} ", ages);
              Console.ReadKey();
           */
            /*
            Console.WriteLine("Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Вас зовут {0} и ваш возраст {1}", name, age);
            Console.WriteLine("Какой у вас любимый день недели? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день недели: {0}", day);

            byte day = checked((byte)int.Parse(Console.ReadLine()));
            int intage = age;
            Console.WriteLine("Your name is {0} and age is {1} ", name, intage);
            Console.ReadKey();
                       */
            Console.Write("Введите ваше имя: ");
            var name = (Console.ReadLine());
            Console.Write("Введите ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и вас {1} лет ", name, age);
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Ваша дата рождения {0}", birthdate);
            Console.WriteLine("Какой у вас любимый день недели (укажите порядковый номер)? ");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.Write("Ваш любимый день недели {0}", day);
        }
    }
}


