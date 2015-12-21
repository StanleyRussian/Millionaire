using System.Collections.Generic;

namespace Millionaire
{
    public class Question
    {
        public string QuestionText
        {
            get;
            private set;
        }
        public List<string> Answers
        {
            get;
            private set;
        }

        public Question (
            string argName,
            string ar, string a1, string a2, string a3)
        {
            QuestionText = argName;
            Answers = new List<string>();
            Answers.Add(ar);
            Answers.Add(a1);
            Answers.Add(a2);
            Answers.Add(a3);
        }
    }
}
