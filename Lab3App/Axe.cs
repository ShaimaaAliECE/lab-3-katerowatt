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
            // Overridden to provide a specific display message for Treasure
            System.Console.WriteLine($"Axe {Description} is displayed");
        }

        public override void DoAction()
        {
            // Implementation of what happens when an Axe's action is performed
            System.Console.WriteLine("Axe is Used");
        }
    }
}