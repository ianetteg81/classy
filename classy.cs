using System;

namespace Classy_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
               
        }
    }

    class Animal
    {
        public string _name  { get; set; }
        public int breed { get; set; }
        public Animal(string name, int breed)
        {
            
        }

        class Dog
        {
            public string _name1{ get; set; }
            public int _breed { get; set; }

            public Dog(string name, int breed)
            {
                _name1 = name;
                _breed = breed;
            }

            public void Name()
            {
                Console.WriteLine("My name is Omega");
            }

            public void breed()
            {
                Console.WriteLine("I am a Lowchen");
            }
        }

        class superAnimal : Cat
        {
            public string superAnimal { get; set; }
            public superAnimal(string name, int breed, string powerName) : base(name, string)
        }
        
        public void superAnimal()
        {
            Console.WriteLine("Super power is: {0}", _powerName);
        }
    }
    


     
}
