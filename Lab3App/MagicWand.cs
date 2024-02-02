using System;
namespace Lab3App.Properties
{
	public class MagicWand : Tool {

        public MagicWand(string descrpiton) : base(descrpiton)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction(); 
        }
  
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
	}
}

