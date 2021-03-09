using System;

namespace BirdsSpace {
    public class Parrot : Birds, IFlyable {
        public Parrot(string name, int age, NoiseLevel noise) : base(name, age, Food.Wheat, Type.Domestic) {
            Noise = noise;
        }
        public enum NoiseLevel {
            Silent, Normal, DistanceLesson
        }
        private NoiseLevel Noise{ get; set; }
        public override int Age{
            get => _age;
            set {
                if (value < 0 || value > 20) {
                    throw new ArgumentException("Wrong age value");
                }
                _age = value;
            }
        }
        public override string Print() {
            string result = "Parrot" + "\n";
            result += "Parrot is " + Convert.ToString(Type) + " animal" + "\n";
            result += "Parrot's name is " + Name + "\n";
            result += Name + " age is " + Convert.ToString(Age) + "\n";
            result += Name + " eats " + Food + "\n";
            result += Name + " is " + Convert.ToString(Noise) + " parrot" + "\n";
            return result;
        }
        public void Fly() {
            Console.WriteLine("Parrot flies in the sky");
        }

        private int _age;
        private const Food Food = Birds.Food.Wheat;
        private const Type Type = Birds.Type.Domestic;
    }
}