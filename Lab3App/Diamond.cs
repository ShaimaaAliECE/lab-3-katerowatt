using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public class Diamond : Treasure
	{
        public Diamond(string description, int score) : base(description, score)
        {
            Console.WriteLine($"{Description} Colleceted, Congrats!!!");
            UpdateTotalScore();
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond {Description} is displayed");
        }
    }
}

