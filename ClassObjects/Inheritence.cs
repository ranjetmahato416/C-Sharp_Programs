using System;
namespace Name
{
    public class LivingThings
    {
        public int _publicVariable  = 10;
        // private int _privateVariable = 15;
        protected int _protectedVariable = 20;

        public LivingThings()
        {
            // Console.WriteLine("Parashar.");

        }
        public LivingThings(int i)
        {
            Console.WriteLine(i);
            
        }
        public virtual void Eat()
        {
            Console.WriteLine("Living things can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base()
        {
            // Console.WriteLine("Sandip.");
            

        }

        public Animal(int i) : base(i)
        {
            Console.WriteLine(i);

        }

        public void FunctionOne()
        {
            _publicVariable = 20;
            _protectedVariable = 25;
        }
        public override void Eat()
        {
            Console.WriteLine("Animal can eat.");
        }
    }

    public class Plants : LivingThings
    {
        public Plants() : base()
        {

        }
        public Plants(int i) : base(i)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("plants can eat.");
        }
    }

    public class Vertibrates : Animal{
        public Vertibrates() : base()
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Vertibrates can eat");
        }
    }

    public sealed class Human : Vertibrates
    {

    }
}