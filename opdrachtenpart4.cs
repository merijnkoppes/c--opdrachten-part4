using System;

public class Opdrachtenpart2
{
    public static void Main(string[] args)
    {
        Dog hond1 = new Dog("hond1", "ras", 5);
        Console.WriteLine(hond1.Name);
        Console.ReadKey();
    }

    public class Dog
    {
        private string name;
        private string breed;
        private int age;

        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}