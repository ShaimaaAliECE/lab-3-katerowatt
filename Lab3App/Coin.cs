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
            // Overridden to provide a specific display message for Coin
            Console.WriteLine($"Coin {Description} is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            // Overridden to add specific Coin logic
            base.AddMe(list); // Call the base class method to add to the list
        }
       
        private void UpdateTotalValue()
        {
            totalValue += Value; 
            // Coin-specific logic to update total value
            Console.WriteLine("Total Value is updated to: " + totalValue);
        }

    }
}

