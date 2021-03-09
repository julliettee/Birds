using System;

namespace BirdsSpace {
    internal static class Program {
        public static void CheckFly(Birds bird) {
            if (bird is IFlyable flyable) {
                flyable.Fly();
            } else {
                Console.WriteLine("Can't fly!");
            }
        }
        public static void CheckSwim(Birds bird) {
            if (bird is ISwimable swimable) {
                swimable.Swim();
            } else {
                Console.WriteLine("Can't swim!");
            }
        }
        
        public static void Main() {
            try {
                var penguin = new Penguin("Po", 1, 14, Penguin.SpeciesPenguin.Emperor);
                Console.WriteLine(penguin.ToString());
                CheckFly(penguin);
                CheckSwim(penguin);

                var kiwi = new Kiwi("Lady", 2, Kiwi.SpeciesKiwi.South, 97);
                Console.WriteLine(kiwi.ToString());
                CheckFly(kiwi);
                CheckSwim(kiwi);

                var duck = new Duck("Goose", 5, Duck.HabitatDuck.Lake, Duck.SpeciesDuck.Mallard);
                Console.WriteLine(duck.ToString());
                CheckFly(duck);
                CheckSwim(duck);

                var parrot = new Parrot("Popug", 2, Parrot.NoiseLevel.DistanceLesson);
                Console.WriteLine(parrot.ToString());
                CheckFly(parrot);
                CheckSwim(parrot);
                Console.ReadKey();
            }
            catch (ArgumentException e) {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e);
            }
        }
    }
}