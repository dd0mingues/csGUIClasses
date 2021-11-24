using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMCQuiz
{
    class loadQuestions
    {
        static string loadedQ = System.IO.File.ReadAllText(@"questions.txt");

        static string[] separatedQ = loadedQ.Split('\n');

        public static ArrayList questionArray = new ArrayList();

        static string prompt;
        static string[] options = new string[4];
        static string answer;
        
        public static void loadQ()
        {
            for (int i = 0; i < separatedQ.Length; i++)
            {
                string[] options = new string[4]; //bcs arrayList holds referecenes, I have to create a new array every time
                i++; //Skips Question#
                prompt = separatedQ[i];
                i++;
                for (int j = 0; j < 4; j++,i++)
                {
                    options[j] = separatedQ[i];
                }
                answer = separatedQ[i];
                i++;

                questionArray.Add(new Question(prompt, options, answer));


            }
        }
    }
}
