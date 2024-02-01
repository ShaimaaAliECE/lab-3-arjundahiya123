using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin:Treasure
	{

		public int value;

        public Coin(String descrip, int score, int value) {
            this.description = descrip;
            this.score = score;
            this.value = value;
        }

        public String UpdateTotalValue()
        {
            setValue(this.value);
            return ("Total Value is updated to: " + getValue());
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.description + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            //return (base.AddMe(list) + UpdateTotalValue());
            base.AddMe(list);
            Console.WriteLine(UpdateTotalValue());
        }
    }
}

