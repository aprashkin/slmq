using System;
namespace slmq
{
    class Carauto
    {
        private string nomer;
        private double bak;
        private double rasshod;
        private double ostatok;
        private int speed;
        private double probeg;

        public Carauto(double initialFuel, int initialSpeed)
        {
            this.bak = initialFuel;
            this.speed = initialSpeed;
        }

        public void Info(string nom, double bak, double ras, int speed, double probeg)
        {
            this.nomer = nomer;
            this.bak = bak;
            this.rasshod = ras;
            this.ostatok = bak;
            this.speed = speed;
            this.probeg = probeg;
        }

        public void Out()
        {
            Console.WriteLine($"Номер и серия тачки: {nomer}");
            Console.WriteLine($"Сколько в баке осталось: {ostatok} л");
            Console.WriteLine($"Сколько требуется бенза на 100 км: {rasshod:F2}");
            Console.WriteLine($"С какой скоростью летим: {speed:F2} км/ч");
            Console.WriteLine($"Сколько проехали уже: {probeg:F2} км");
        }

        public void Zaprawka(double top)
        {
            ostatok += top;
            Console.WriteLine($"Заправились, в нём осталось {ostatok} литров");
        }


        public void Move(int speed)
        {

            Console.Write("Далеко поедем? (в км ес че) ");
            double distance = double.Parse(Console.ReadLine());


            double kmNalitr = 100 / rasshod;
            double rashod = distance * (rasshod / 100);



            if (ostatok >= rashod && ostatok != 0 && speed != 0)
            {
                ostatok -= rashod;
                probeg += distance;
                Console.WriteLine($"Мы проехали {distance:F2} км со скоростью {this.speed} км/ч. Бенза осталось: {ostatok:F2}\nВсего проехали: {probeg:F2} км");
                this.speed = speed;

            }
            else if (ostatok <= rashod && ostatok != 0 && speed != 0)
            {
                double distance1;
                distance1 = ostatok * kmNalitr;
                probeg += distance1;
                ostatok = 0;
                Console.WriteLine($"Мы проехали {distance1:F2} км со скоростью {this.speed} км/ч. Бенза больше нема(. Ласточка наша остановилась...\nОбщий пробег: {probeg:F2} км");
                speed = 0;
                this.speed = 0;
            }
            else if (ostatok == 0)
            {
                Console.WriteLine("В баке пересохло уже.");
            }
            else if (speed == 0)
            {
                Console.WriteLine("Тапочку в пол прожми да.");
            }
        }

        public void Zapravka(double top)//заправка ахахааххаха
        {

            Console.WriteLine("Желаете дозаправиться? (y or n)");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "y":
                    Console.WriteLine("На сколько литров заправляемся?");
                    top = int.Parse(Console.ReadLine());
                    ostatok += top;
                    Console.Clear();

                    break;
                case "n":
                    Console.WriteLine("Ну и толкай дальше сам, я не поеду(");
                    Console.Clear();
                    break;
            }
        }
        public void Ostanovka()
        {
            speed = 0;
            Console.WriteLine("По тормозам!!!");

        }

        public void Razgon(int sum_speed)
        {
            if (ostatok >= 1.0)
            {
                rasshod += 0.1;
                ostatok -= 1.0;
                speed += sum_speed;

                Console.WriteLine($"Наш борт набирает скорость, равную  {speed} км/ч. Бензин льется в двигатель, как из шланга.");
            }
            else
            {
                Console.WriteLine("В баке пересохло, никак быстрее не поедем.");
            }
        }
        public void Tormoz(int sum_speed1)
        {
            rasshod -= 0.1;
            ostatok += 1.0;
            speed -= sum_speed1;

            Console.WriteLine($"Наш борт замедляется до  {speed} км/ч. Бензин течет медленнее.");
        }
    }
}