using System;

namespace BirdsSpace {
    public class Duck : Birds, ISwimable, IFlyable {
        public enum SpeciesDuck {
            Cuban, Mallard
        }
        public enum HabitatDuck {
            River, Swamp, Lake
        }
        public Duck(string name, int age, HabitatDuck habitat, SpeciesDuck species) : base(name, age, Food.Wheat,
            Type.Domestic) {
            Habitat = habitat;
            Species = species;
        }
        private SpeciesDuck Species{ get; set; }
        private HabitatDuck Habitat{ get; set; }
        public override int Age{
            get => _age;
            set {
                if (value < 0 || value > 10) {
                    throw new ArgumentException("Wrong age value");
                }
                _age = value;
            }
        }
        public override string Print() {
            string result = Convert.ToString((Species)) + " duck \n";
            result += "Duck is " + Convert.ToString(type) + " animal \n";
            result += "Duck's name is " + Name + "\n";
            result += Name + " age is " + Convert.ToString(Age) + "\n";
            result += Name + " eats " + food + "\n";
            result += Name + " home is " + Habitat + "\n";
            return result;
        }
        public void Swim() {
            Console.WriteLine("Duck swims in " + Habitat);
        }
        public void Fly() {
            Console.WriteLine("Duck flies in the sky");
        }
        private int _age;
    }
}