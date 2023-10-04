using System;
namespace slmq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько бензина у нас было? (в литрах ес че) ");
            float Zalili = float.Parse(Console.ReadLine());

            Console.Write("С какой скоростью стартует наш борт? (в километрах/час ес че) ");
            int Nachal_speed = int.Parse(Console.ReadLine());

            Carauto myCar = new Carauto(Zalili, Nachal_speed);
            myCar.Info("qwe123", Zalili, 7f, Nachal_speed, 0);

            while (true)
            {
                Console.WriteLine("\nЧе делать будем?");
                Console.WriteLine("1 - Поедем");
                Console.WriteLine("2 - Остановимся");
                Console.WriteLine("3 - Анти-ускоримся((");
                Console.WriteLine("4 - Ускоримся))");
                Console.WriteLine("5 - Покормим машинку");
                Console.WriteLine("6 - Паспорт машины");
                Console.WriteLine("7 - Выйти нафик отсюда\n");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        myCar.Move(Nachal_speed);
                        break;

                    case ConsoleKey.D2:
                        myCar.Ostanovka();
                        break;

                    case ConsoleKey.D3:
                        Console.Write("На сколько замедлимся?( (в км/ч): ");
                        int sum_speed1 = int.Parse(Console.ReadLine());
                        myCar.Tormoz(sum_speed1);
                        break;

                    case ConsoleKey.D4:
                        Console.Write("На сколько ускормися?) (в км/ч): ");
                        int sum_speed = int.Parse(Console.ReadLine());
                        myCar.Razgon(sum_speed);
                        break;

                    case ConsoleKey.D5:
                        double top = double.Parse(Console.ReadLine());
                        myCar.Zapravka(top);
                        break;

                    case ConsoleKey.D6:
                        myCar.Out();
                        break;

                    case ConsoleKey.D7:
                        Console.WriteLine("ББ");
                        return;

                    default:
                        Console.WriteLine("ТЫ КУДА ЖМАЕШЬ АЛЕ. ДАВАЙ ПО НОВОЙ МИША, ВСЕ @#&#@!");
                        break;
                }
            }
        }
    }
}