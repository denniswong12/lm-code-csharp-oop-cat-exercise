using System;
namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            Setting = "domestic";
            AverageHeight = 23;
        }

        public override string Eat()
        {
            Random rnd = new Random();
            var randomNum = rnd.Next(0, 2);
            if (randomNum == 0)
                return ("Purrrrrrr");
            else
                return ("It will do I suppose");
        }
    }
}

