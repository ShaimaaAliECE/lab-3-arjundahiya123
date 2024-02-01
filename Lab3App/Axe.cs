using System;
namespace Lab3App
{
	public class Axe:Tool
	{

        public Axe(String descrip)
        {
            this.description = descrip;
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + this.description + " is displayed");
        }

        public override String DoAction()
        {
            return ("Axe is used");
        }
    }
}

