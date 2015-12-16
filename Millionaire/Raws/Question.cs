namespace Millionaire
{
    class Question
    {
        string QuestionText;
        string[] Answers;

        public Question (
            string argName,
            string[] argAnswers)
        {
            QuestionText = argName;
            Answers = argAnswers;
        }
    }
}
