using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Collectable: Displayable
	{
		public String description;
		public abstract void Display();

		public CollectionBoard Board;

        public Collectable() { }

        //public Collectable(String description){
        //    this.description = description;
        //}

		public int getScore(){
			return CollectionBoard.TotalScore;
		}

        public void setScore(int newScore)
        {
            CollectionBoard.TotalScore += newScore;
        }

        public int getValue()
        {
            return CollectionBoard.TotalValue;
        }

        public void setValue(int newValue)
        {
            CollectionBoard.TotalValue += newValue;
        }   

        public virtual void AddMe(List<Collectable> list){
			list.Add(this);
            //return (this.description + " Collected, Congrats!!!!");
            Console.WriteLine(this.description + " Collected, Congrats!!!!");
		}
	}
}

