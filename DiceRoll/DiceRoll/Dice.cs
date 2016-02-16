using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    //Dice class provides attributes and methods of a literal dice

    class Dice
    {
        //sets dice image string locations
        private string diceImage1 = "..\\..\\Image\\Dice1.jpg";
        private string diceImage2 = "..\\..\\Image\\Dice2.jpg";
        private string diceImage3 = "..\\..\\Image\\Dice3.jpg";
        private string diceImage4 = "..\\..\\Image\\Dice4.jpg";
        private string diceImage5 = "..\\..\\Image\\Dice5.jpg";
        private string diceImage6 = "..\\..\\Image\\Dice6.jpg";


       static Random rnd = new Random();
        int[] diceRoll = new int[2];

        //Roll alows for a random number between 1-6 for two dice
        public int[] Roll()
        {
            int[] diceNumber = new int[2];

            for (int roll = 0; roll < diceNumber.Length; roll++)
            {
                diceNumber[roll] = rnd.Next(1, 7);
            }
            diceRoll = diceNumber;
            return diceNumber;
        }//end Roll

        // returns image location of the dice number jpg
        public string diceImage(int number)
        {
            string imageLocation = "";

            switch (number)
            {
                case 1:
                    imageLocation = diceImage1;
                    break;
                case 2:
                    imageLocation = diceImage2;
                    break;
                case 3:
                    imageLocation = diceImage3;
                    break;
                case 4:
                    imageLocation = diceImage4;
                    break;
                case 5:
                    imageLocation = diceImage5;
                    break;
                case 6:
                    imageLocation = diceImage6;
                    break;
            }//end switch
            return imageLocation;
        }//end diceImage

        //returns double formated roll
        public string FormatDouble(int count)
        {
            string txtFormat;
            txtFormat = (string.Format("Roll #{0}, Dice Number={1}, Total={2}",
                    count, diceRoll[0], diceRoll.Sum()));
            return txtFormat;
        }//end FormatDouble

        //returns standard formated roll
        public string Format()
        {
            string txtFormat;
            txtFormat = "Total " + diceRoll.Sum();
            return txtFormat;
        }//end Format
    }//end class
}//end namespace
