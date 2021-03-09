using System;

namespace BirdsSpace {
    public class Kiwi : Birds {
        public Kiwi(string name, int age, SpeciesKiwi species, int similarity) : base(name, age, Food.All, Type.Wild) {
            SimilarityWithFruit = similarity;
            Species = species;
        }
        private int SimilarityWithFruit{
            get => _similarityWithFruit;
            set {
                if (value < 0 || value >= 100) {
                    throw new ArgumentException("Wrong similarity value");
                }
                _similarityWithFruit = value;
            }
        }
        public enum SpeciesKiwi {
            South, North, Big, Small
        }
        private SpeciesKiwi Species{ get; set; }
        public override int Age{
            get => _age;
            set {
                if (value < 0 || value > 60) {
                    throw new ArgumentException("Wrong age value");
                }
                _age = value;
            }
        }
        public override string Print() {
            string result = Convert.ToString((Species)) + " kiwi" + "\n"; 
            result += "Kiwi is " + Convert.ToString(type) + " animal" + "\n";
            result += "Kiwi's name is " + Name + "\n";
            result += Name + " age is " + Convert.ToString(Age) + "\n";
            result += Name + " eats " + food + "\n";
            result += (Name + " is similar with fruit in {0:p}", _similarityWithFruit) + "\n";
            return result;
        }
        private int _age;
        private int _similarityWithFruit;
    }
}