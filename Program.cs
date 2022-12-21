using System.Diagnostics;
using Newtonsoft.Json;
using Skorost;
using System.Data;
using System.Diagnostics;
internal class Program
{
    static void Main(string[] args)
    {
        Сod();
    }
    static void Сod()
    {
        Thread thread = new Thread(_ =>
        {
            int time = 1;
            while (time != 101)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("   ");
                Console.WriteLine(time);
                time++;

                Thread.Sleep(1000);
            }
        });
        Thread thrd = new Thread(_ =>
        {
            Stopwatch SW = new Stopwatch();
            SW.Start();
            Thread.Sleep(60000);
            SW.Stop();
        });
        Console.WriteLine("Введите ваше имя: ");
        chek user = new chek();
        user.name = Console.ReadLine();
        string nam = user.name;
        Console.Clear();
        Console.WriteLine("Тест на скоропечатание, нажмите Еnter для старта:");
        ConsoleKeyInfo Clava = Console.ReadKey();
        if (Clava.Key == ConsoleKey.Enter)
        {
            thread.Start();
            thrd.Start();
            Console.SetCursorPosition(0, 1);
            string text = ("Мой лучший подарок на День Рождения это то, что я не сижу в тюрьме.");
            Console.WriteLine(text);
            int x = 0;
            while (thrd.IsAlive)
            {
                char Key = Console.ReadKey(true).KeyChar;
                if (Key == text[x])
                {
                    Console.SetCursorPosition(x, 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Key);
                    Console.ResetColor();
                    x++;
                }
            }
            int minute = x;
            double second = x / 60;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine($"Всего введено символов: {x}, введено символов в минуту {user.minute}, введено символов в секунду {user.second}");
            Console.ReadKey();
            text record = new text();
            record.exel(user);
            Console.ReadKey();
            Сod();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Программа завершена");
        }
    }
}