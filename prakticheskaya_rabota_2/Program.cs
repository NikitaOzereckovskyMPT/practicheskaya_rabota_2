int command = 0;
while (command != 3)
{
    Console.WriteLine("Введите номер команды: ");
    Console.WriteLine("1. Игра: Угадай число");
    Console.WriteLine("2. Вывод делителей числа");
    Console.WriteLine("3. Закончить");
    int number = Convert.ToInt32(Console.ReadLine());
    command = number;

    if (command == 1)
    {
        Console.WriteLine("Добро пожаловать в игру: Угадай число");
        
        Random rand = new Random();
        int b = rand.Next(100);

        int a = 0;

        while (a != b)
        {
            Console.WriteLine("Введите число от 1 до 100: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c < b)
            {
                Console.Write("Вы ввели число меньше загаданного компьютером. ");
            }

            if (c >= b)
            {
                Console.Write("Вы ввели число больше загаданного компьютером. ");
            }

            if (c > 100)
            {
                Console.Write("Вы ввели число большее 100. ");
            }

            if (c == b)
            {
                Console.Write("Верно, компьютер загадал число ");
                Console.WriteLine(b);
                a = c;
            }
        }
    }
    
    if (command == 2) 
    {
        Console.WriteLine("Вывод делителей числа");

        Console.Write("Введите число: ");

        int a = int.Parse(Console.ReadLine());
        for (int b = 1; b <= a; b++)
        {
            if (a % b == 0) Console.WriteLine("{0} ", b);
        }
    }
}