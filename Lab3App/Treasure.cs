using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure: Collectable
	{
		public int score;

		public String UpdateTotalScore(){
            setScore(this.score);
            return ("Total Score is updated to: " + getScore());
        }

        public override void AddMe(List<Collectable> list)
        {
            //return (base.AddMe(list) + UpdateTotalScore());
            base.AddMe(list);
            Console.WriteLine(UpdateTotalScore());
        }
    }
}

