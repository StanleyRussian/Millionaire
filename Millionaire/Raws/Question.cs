namespace Millionaire
{
    public class Question
    {
        public string QuestionText
        {
            get;
            private set;
        }
        public string[] Answers
        {
            get;
            private set;
        }

        public Question (
            string argName,
            string ar, string a1, string a2, string a3)
        {
            QuestionText = argName;
            Answers = new string[4];
            Answers[0] = ar;
            Answers[1] = a1;
            Answers[2] = a2;
            Answers[3] = a3;
            //Answers.Add(ar);
            //Answers.Add(a1);
            //Answers.Add(a2);
            //Answers.Add(a3);
        }
    }
}
