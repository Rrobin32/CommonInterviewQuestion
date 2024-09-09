using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
        Static Polymorphism: Achieved through method overloading and operator overloading. 
        It allows multiple methods or operators with the same name but different parameters to coexist, with the specific method or operator being invoked 
        determined at compile time based on the arguments passed.

        Dynamic Polymorphism: Achieved through method overriding. It allows a method in a derived class to have the same name and signature as a method 
        in its base class, but with different implementation details. The method that gets executed is determined at runtime, depending on the type of the object.
     */


    // Static Polymorphism (Method Overloading)
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    // Dynamic Polymorphism (Method Overriding)
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class StaticVSDynamicPolymorphism
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3)); // Calls the first Add method
            Console.WriteLine(calc.Add(2, 3, 4)); // Calls the second Add method

            Animal myAnimal = new Animal();
            myAnimal.Speak(); // Output: The animal speaks

            Dog myDog = new Dog();
            myDog.Speak(); // Output: Dog barks

            Animal mySecondAnimal = new Dog();
            mySecondAnimal.Speak(); // Output: Dog barks, demonstrating dynamic polymorphism
        }
    }

}
