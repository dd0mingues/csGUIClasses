using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMCQuiz
{
    class Question
    {

        string[] options;
        string prompt;
        string answer;

        public Question(string prompt, string[] options, string answer)
        {
            this.prompt = prompt;
            this.options = options;
            this.answer = answer;
        }

        public string[] Options { get => options; set => options = value; }
        public string Prompt { get => prompt; set => prompt = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
