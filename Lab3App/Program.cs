using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public class Program
	{
        static void Main(string[] args)
        {
            //collection board
            CollectionBoard board = new CollectionBoard();

            List<Collectable> possibleCollectiable = new List<Collectable>();
            //3 coins 
            possibleCollectiable.Add(new Coin("Nickel", score: 20, value: 5));
            possibleCollectiable.Add(new Coin("Dime", score: 40, value: 10));
            possibleCollectiable.Add(new Coin("Toony", score: 50, value: 100));

            //5 Diamonds with descriptions Diamond1, Diamond2, ... etc.
            for (int i = 1; i <= 5; i++)
            {
                possibleCollectiable.Add(new Diamond("Diamond" + i, score: 100));
            }

            //1 Axe
            possibleCollectiable.Add(new Axe("OnlyAxe"));

            //1 MagicWand
            possibleCollectiable.Add(new MagicWand("OnlyMagicWand"));

            // Associate the CollectionBoard object to all the possible Collectiable using a foreach loop
            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.Board = board;
            }

            // Create an empty list to start collecting 
            List<Collectable> collected = new List<Collectable>();

            //Collect the items one-by-one in a foreach loop
            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.AddMe(collected);
            }

            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");
            //Display all what was collected in a for each loop
            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.Display();
            }
        }
    }
}

