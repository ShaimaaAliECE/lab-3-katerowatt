using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public abstract class Treasure : Collectable
	{
		public int Score { get; set; }

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

