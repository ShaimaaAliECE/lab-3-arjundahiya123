using System;
namespace Lab3App
{
	public class MagicWand:Tool
	{
        public MagicWand(String descrip) {
            this.description = descrip;
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.description + " is displayed");
        }

        public override String DoAction() {
            return ("MagicWand is used");
        }
    }
}

