using System;
namespace Lab3App
{

    public class Diamond : Treasure
    {

        public Diamond(String descrip, int score)
        {
            this.description = descrip;
            this.score = score;
        }



        public override void Display()
            {
                Console.WriteLine("Diamond" + this.description + " is displayed");
            }
    }
}

