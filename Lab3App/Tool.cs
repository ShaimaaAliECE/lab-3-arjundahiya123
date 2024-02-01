using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Tool:Collectable
	{
		public abstract String DoAction();

        public override void AddMe(List<Collectable> list)
        {
            //return (base.AddMe(list) + DoAction());
            base.AddMe(list);
            Console.WriteLine(DoAction());
        }
    }
}

