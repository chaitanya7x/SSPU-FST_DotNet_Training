using System;

namespace ConsoleApp2.Interfaces
{
    public class Elephant : ISpecies, IBodyCharacteristics, IDiet, IReproduction, IDomestication
    {
        public void African()
        {
            Console.WriteLine("African elephants are found in 38 countries of Africa, stand up to 4m tall, and weigh around 7000kg.");
        }

        public void Asian()
        {
            Console.WriteLine("Asian elephants are found in Asia, stand up to 3.4m tall, and weigh around 5400kg.");
        }

        public void Trunk()
        {
            Console.WriteLine("The trunk is used to tear up food and place it in the mouth.");
        }

        public void Tusk()
        {
            Console.WriteLine("Tusks are used to dig for water, salt, and roots; debark trees; dig into baobab trees to get pulp inside; and move trees and branches.");
        }

        public void Teeth()
        {
            Console.WriteLine("Elephants usually have 28 teeth.");
        }

        public void Skin()
        {
            Console.WriteLine("Elephant skin is extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick.");
        }

        public void LegsAndFeet()
        {
            Console.WriteLine("Elephants have great straight pillars for legs and feet, necessary to support their bulk weight.");
        }

        public void Ears()
        {
            Console.WriteLine("Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels.");
        }

        public void Herbivores()
        {
            Console.WriteLine("Elephants are herbivores, and their diet includes grasses, leaves, fruits, and bark.");
        }

        public void Interval()
        {
            Console.WriteLine("Elephants have a long reproductive interval, with females giving birth every 4-5 years.");
        }
        public void Weight()
        {
            Console.WriteLine("A newborn elephant calf can weigh around 200-250 pounds.");
        }

        public void Use()
        {
            Console.WriteLine("Elephants have been used for various purposes like transportation, labor, and in cultural ceremonies.");
        }
    }
}
