using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public class Coin : Treasure
	{
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            UpdateTotalScore(); 
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
       
        private void UpdateTotalValue()
        {
            totalValue += Value; 
            Console.WriteLine("Total Value is updated to: " + totalValue);
        }

    }
}

