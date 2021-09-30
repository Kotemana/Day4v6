using Day4.Pets;
using System;
using System.Collections.Generic;

namespace Day4
{
    public class Tolchok
    {
        public int Height { get; set; }
        public string Name { get; set; }

        public int Money { get; set; }
        public Weapon FavouriteWeapon { get; set; }
        public List<Animal> Pets { get; set; }

        public Tolchok()
        {

        }

        public Tolchok(int height, string name)
        {
            Height = height;
            Name = name;
        }

        public void ShowHeight()
        {
            Console.WriteLine($"{Name} is {Height} cms");
        }

        public void ShowPets()
        {
            foreach (var pet in Pets)
            {
                Console.WriteLine($"I'm {pet.Name} the {pet.Type}");
            }
        }

        public void ShowPets(int maxNumber)
        {

            for (int i = 0; i < Math.Min(Pets.Count, maxNumber); i++)
            {
                Console.WriteLine($"I'm {Pets[i].Name} the {Pets[i].Type}");
            }
        }

        public void GiveMoney(int sum, Tolchok recipient)
        {
            recipient.Money += sum;
            Money -= sum;
        }
    }
}
