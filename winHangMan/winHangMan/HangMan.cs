using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winHangMan
{
    class HangMan
    {
        private List<string> listOfWord = new List<string>();
        private List<char> listOfEnteredLetters = new List<char>();

        private string strGeneratedWord;
        private StringBuilder sbGuessWord;
        private int RemainLives;
        private bool blnWordFound;
        private bool LifeLoss;

        // encapsulation
        public string getGeneratedWord() { return strGeneratedWord; }
        public StringBuilder getGuessWord() { return sbGuessWord; }
        public int getRemaininLives() { return RemainLives; }
        public bool getWordFound() { return blnWordFound; }
        public bool getLifeLoss() { return LifeLoss; }


        //====================================================================
        //Default Constructor
        public HangMan()
        {
            listOfWord.Add("MEMORY");
            listOfWord.Add("COMPUTER");
            listOfWord.Add("PRINTER");
            listOfWord.Add("TROUSERS");
            listOfWord.Add("BUTTERCUP");
            listOfWord.Add("PINEAPPLE");
            listOfWord.Add("PENGUIN");
            listOfWord.Add("VIOLIN");
            listOfWord.Add("TABLE");
            listOfWord.Add("GUITAR");
            listOfWord.Add("COFFEE");
            listOfWord.Add("FREEZER");
            listOfWord.Add("MONITOR");
            listOfWord.Add("BRUSH");
            listOfWord.Add("WOOD");
            listOfWord.Add("FAN");
            listOfWord.Add("RUG");
            listOfWord.Add("LAWN");
            listOfWord.Add("HEATER");
            listOfWord.Add("CALCULATOR");
            listOfWord.Add("COMBINATION");
            listOfWord.Add("BOTTLE");
            listOfWord.Add("KEYS");
            listOfWord.Add("CARDBOARD");
            listOfWord.Add("SHEET");
            listOfWord.Add("STICKER");
            listOfWord.Add("SOCKS");
            listOfWord.Add("BLOUSE");
            listOfWord.Add("CHARGER");
            listOfWord.Add("ELECTRIC");
            listOfWord.Add("FAIRY");
            listOfWord.Add("ROCK");
            listOfWord.Add("FIRE");
            listOfWord.Add("GRASS");
            listOfWord.Add("GREASE");

        }
        //====================================================================================
        public string generateNewWord()
        {
            listOfWord = listOfWord.OrderBy(x => Guid.NewGuid()).ToList(); //SHUFFLES ITEMS IN THE LIST
            strGeneratedWord = listOfWord[0];
            sbGuessWord = new StringBuilder(listOfWord[0]);
            RemainLives = 7;
            blnWordFound = false;
            listOfEnteredLetters.Clear();
            //masking the word
            for (int i = 0; i < sbGuessWord.Length; i++)
            {
                sbGuessWord.Replace(sbGuessWord[i], '*');
            }

            return sbGuessWord.ToString();
        }
        //========================================================================================
        //checking if new letter has already been checked and if not it checks the
        //new letter against the generated  word and unmasked the letter if it the generated word contains
        //the new letter
        public string checkNewLetter(char chrNewLtr)
        {
            LifeLoss = true;

            if (!listOfEnteredLetters.Contains(chrNewLtr))
            {
                listOfEnteredLetters.Add(chrNewLtr);

                for (int i = 0; i < strGeneratedWord.Length; i++)
                {
                    if (strGeneratedWord[i] == chrNewLtr)
                    {
                        sbGuessWord[i] = chrNewLtr;
                        LifeLoss = false;
                    }
                }
            }
            else
                LifeLoss = false;



            if (LifeLoss)
                RemainLives--;


            if (strGeneratedWord.Equals(sbGuessWord.ToString()))
                blnWordFound = true;

            return sbGuessWord.ToString();
        }
        //===============================================================================================





    }

}
