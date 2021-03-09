using System;

namespace BirdsSpace {
    public abstract class Birds {
        protected Birds(string name, int age, Food food, Type type) {
            Name = name;
            Age = age;
            this.food = food;
            this.type = type;
        }
        protected enum Food {
            Wheat, Fish, All
        }
        protected Food food;
        protected enum Type {
            Wild, Domestic
        }
        protected Type type;
        public string Name{
            get => _name;
            set => _name = value.Length == 0 ? "No name" : value;
        }
        private string _name;
        abstract public int Age{ get; set; }
        private int _age;
        public abstract string Print();
        public override string ToString() {
            return this.Print();
        }
    }
}