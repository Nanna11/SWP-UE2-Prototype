using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class SwordPrototype
    {
        string _swordtype;
        int _hitpoints;
        double _lenght;
        double _weight;
        string _material;

        public SwordPrototype(string SwordType, int Hitpoints, double Lenght, double Weight, string Matrtial)
        {
            _swordtype = SwordType;
            _hitpoints = Hitpoints;
            _lenght = Lenght;
            _weight = Weight;
            _material = Matrtial;
        }

        public int Hitpoints { get => _hitpoints;}
        public double Lenght { get => _lenght;}
        public double Weight { get => _weight;}
        public string Material { get => _material;}
        public string Swordtype { get => _swordtype;}

        public SwordPrototype Clone()
        {
            Console.WriteLine("Cloning Sword: {0} - Hitpoints: {1}", _swordtype, Hitpoints);
            return this.MemberwiseClone() as SwordPrototype;
        }
    }
}
