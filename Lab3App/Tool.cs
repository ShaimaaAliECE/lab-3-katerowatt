using System;
using System.Collections.Generic;

namespace Lab3App.Properties
{
	public abstract class Tool : Collectable
    {
        public Tool(string Description) : base(Description) { }

        public abstract void DoAction(); 

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list); 
        }
    }
}

