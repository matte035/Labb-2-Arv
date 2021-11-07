using System;

namespace Labb_2___Arv
{
    public class Djur
    {
        public int Age;
        public string Height;
        public string Weight;
        public string Gender;
        public string Food;

        public void Walking()
        {
            Console.WriteLine();
        }
        public void Jump()
        {
            Console.WriteLine();
        }
        public void Eating()
        {
            Console.WriteLine();
        }

        public void PrintAnimal()
        {
            Console.WriteLine();
        }

        public void MakeSound()
        {
            Console.WriteLine();
        }

    }
   public class Program
    {
       
        static void Main(string[] args)
        {
            Cat C = new Cat();
            Dog D = new Dog();
            Rabbit R = new Rabbit();

            C.Age = 2;
            C.Height = "50 cm";
            C.Weight = "1 KG ";
            C.Gender = "Female";
            C.Food = "Fish";
            C.PrintAnimal();
            C.MakeSound();

            D.Age = 10;
            D.Height = "110 cm";
            D.Weight = "4 KG ";
            D.Gender = "Male";
            D.Food = "Bones";
            D.PrintAnimal();
            D.MakeSound();

            R.Age = 5;
            R.Height = "40 cm";
            R.Weight = "0.5 KG ";
            R.Gender = "Female";
            R.Food = "Carrot";
            R.PrintAnimal();
            R.MakeSound();

            Console.ReadKey();
        }
    }
}
