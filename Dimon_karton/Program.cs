using System;

namespace Dimon_karton
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog vovchik = new Dog("мартышка", new DateTime(2001,03,30));
            Console.WriteLine(vovchik.Age);
            ((IWalking)vovchik).Walk();

            Butterfly anton = new Butterfly("кот", new DateTime(2000, 05, 05));
            Console.WriteLine(anton.Age);
            ((IFlying)anton).Fly();

            Bird babochka = new Bird("Бабочка", new DateTime(2020, 11, 16));
            Console.WriteLine(babochka.Age);
            ((IFlying)babochka).Fly();

            Fish ptichka = new Fish("птичка", new DateTime(2010, 10, 25));
            Console.WriteLine(ptichka.Age);
            ((ISwimming)ptichka).Swimm();



        }
    }
}
