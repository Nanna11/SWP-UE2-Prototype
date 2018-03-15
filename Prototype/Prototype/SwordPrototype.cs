using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    class SwordPrototype : Prototype<SwordPrototype>
    {
        string _swordtype;
        int _hitpoints;
        double _lenght;
        double _weight;
        string _material;

        double _durability;
        Handle _handle;

        public SwordPrototype(string SwordType, int Hitpoints, double Lenght, double Weight, string Material, Handle Handle)
        {
            _swordtype = SwordType;
            _hitpoints = Hitpoints;
            _lenght = Lenght;
            _weight = Weight;
            _material = Material;

            _handle = Handle;
        }

        public int Hitpoints { get => _hitpoints;}
        public double Lenght { get => _lenght;}
        public double Weight { get => _weight;}
        public string Material { get => _material;}
        public string Swordtype { get => _swordtype;}
        internal Handle Handle { get => _handle; }

        //public SwordPrototype Clone()
        //{
        //    Console.WriteLine("Cloning Sword: {0} - Hitpoints: {1}", _swordtype, Hitpoints);
        //    return MemberwiseClone() as SwordPrototype;
        //}
    }
}
