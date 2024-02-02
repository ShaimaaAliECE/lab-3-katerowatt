using System;
namespace Lab3App.Properties
{
    public class Axe : Tool
    {
        public Axe(string description) : base(description)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction(); 
        }

        public override void Display()
        {
            System.Console.WriteLine($"Axe {Description} is displayed");
        }

        public override void DoAction()
        {
            System.Console.WriteLine("Axe is Used");
        }
    }
}