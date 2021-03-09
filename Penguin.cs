using System;

namespace BirdsSpace {
    public class Penguin : Birds, ISwimable {
        public Penguin(string name, int age, int slidingSpeed, SpeciesPenguin species) : base(name, age, Food.Fish,
            Type.Wild) {
            SlidingSpeed = slidingSpeed;
            Species = species;
        }
        public enum SpeciesPenguin {
            Small, Emperor
        }
        public int SlidingSpeed{
            get => _slidingSpeed;
            set {
                if (value < 0) {
                    throw new AggregateException("Wrong value of sliding speed");
                }

                _slidingSpeed = value;
            }
        }
        public SpeciesPenguin Species{ get; set; }
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
            string result = Convert.ToString((Species)) + " penguin" + "\n";
            result += "Penguin is " + Convert.ToString(type) + " animal" + "\n";
            result += "Penguin's name is " + Name + "\n";
            result += Name + " age is " + Convert.ToString(Age) + "\n";
            result += Name + " eats " + food + "\n";
            result += Name + " sliding speed is " + Convert.ToString((_slidingSpeed)) + "\n";
            return result;
        }
        public void Swim() {
            Console.WriteLine("Penguin swims in the Ocean");
        }
        private int _age;
        private int _slidingSpeed;
    }
}