using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Weapon
    {
        public WeaponMaterial Material { get; set; }
        public int Weight { get; set; }
        public WeaponType WeaponType { get; set; }
        public string Name { get; set; }
    }
}
