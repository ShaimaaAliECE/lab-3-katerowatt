using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public abstract class Treasure : Collectable
	{
		public int Score { get; set; }

        // Constructor for Treasure that takes a description, a score, and a collection board
        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public virtual void UpdateTotalScore()
        {
            totalScore += Score;
            Console.WriteLine($"Total Score is updated to: {totalScore}");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}

