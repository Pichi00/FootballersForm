using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers
{
    internal class Footballer
    {
        // Longer version
        private string name;
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Shprter version
        public string Surname { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Position Position { get; set; }
        public Footballer(string name, string surname, int height, int weight, Position position)
        {
            Name = name;
            Surname = surname;
            Height = height;
            Weight = weight;
            Position = position;
        }

        public Footballer(Footballer f1)
        {
            Name = f1.Name;
            Surname = f1.Surname;
            Height = f1.Height;
            Weight = f1.Weight;
            Position = f1.Position;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, position: {Position}, height: {Height} cm, weight: {Weight} kg.";
        }
    }
}
