using Day4.Pets;
using System;
using System.Collections.Generic;

namespace Day4
{
    static class Program
    {
        static void Main(string[] args)
        {
            Tolchok tolchok = new Tolchok(198, "Casper");
            tolchok.Money = 4000;
            var rnd = new Random();
            tolchok.FavouriteWeapon = new Weapon()
            {
                Material = WeaponMaterial.Larp,
                WeaponType = WeaponType.Sword,
                Weight = 300,
                Name = "Sword of trolling"
            };
            tolchok.ShowHeight();
            Console.WriteLine($"{tolchok.Name} is running to Hyena now, and {tolchok.FavouriteWeapon.Name} is looking out of his pocket");
            
            var presidentRd = new Tolchok();
            presidentRd.Name = "Dexter";
            presidentRd.Height = 178;
            presidentRd.ShowHeight();
            ShowTolchokOnHeels(presidentRd);
            presidentRd.ShowHeight();
            
            tolchok.ShowHeight();
            tolchok.GiveMoney(200, presidentRd);
            Console.WriteLine($"Now {presidentRd.Name} has {presidentRd.Money} and {tolchok.Name} has {tolchok.Money}");
            var number = 10;
            Console.WriteLine(number);
            ShowNumber(number);
            Console.WriteLine(number);


            var inga = new Tolchok()
            {
                Name = "Inga",
                Height = 200,
                Pets = new List<Animal>()
                {
                    new Animal(){ Name = "Semen", Type = AnimalType.Cat},
                    new Animal(){ Name = "Kuro", Type = AnimalType.Cat},
                    new Animal(){ Name = "Shiro", Type = AnimalType.Cat},
                    new Animal(){ Name = "Mara", Type = AnimalType.Cat},
                    new Animal(){ Name = "Benya", Type = AnimalType.Cat},
                    new Animal(){ Name = "Sid", Type = AnimalType.Dog},
                }
            };

            inga.ShowPets(100500);

            //inga.Pets.Add(new Animal() { Name = "Larisa", Type = AnimalType.Rat });
            //inga.ShowPets();

        }

        static void ShowNumber(int x)
        {
            x = x + 5;
            Console.WriteLine(x);
        }

        static void ShowTolchokOnHeels(Tolchok lalala)
        {
            var height = lalala.Height;
            height += 5;
            Console.WriteLine(height);
        }
    }
}
