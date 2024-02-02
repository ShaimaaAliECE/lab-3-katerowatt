using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public abstract class Collectable : CollectionBoard, Displayable 
	{
        public string Description { get; set; }

        private CollectionBoard board;

        public CollectionBoard Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
            }
        }

        public Collectable(string description)
        {
            Description = description;
        }

        // Abstract method Display from the Displayable interface
        public abstract void Display();

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
        }
    }
}

