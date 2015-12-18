using System;
using System.Collections.Generic;

namespace Millionaire
{
    class Model : iModel
    {
        int CurrentQuestion = 0;

        public List<Question> QuestionList
        {
            get;
            private set;
        }

        public List<string> Answers
        {
            get;
            private set;
        }

        public void Advance()
        {
            CurrentQuestion++;
            Random rnd = new Random();
            Answers.Clear();
            
            foreach (string a in QuestionList[CurrentQuestion].Answers)
            {
                while (Answers.Count != 4)
                {
                    int tick = rnd.Next(0, 4);
                    if (Answers[tick] == null)
                        Answers[tick] = a;
                }
            }

            QuestionChanged(QuestionList[CurrentQuestion].QuestionText);
            AnswersChanged(Answers);
        }

        public void FiftyFifty()
        {
            Random rnd = new Random();
            Answers.Clear();

            foreach (string a in QuestionList[CurrentQuestion].Answers)
            {
                //Only thing changed here from Advance() code is number in Answers.Count check
                //Idea: you clear answers, add two first again (with first being the right one) and push it.
                while (Answers.Count != 2)
                {
                    int tick = rnd.Next(0, 4);
                    if (Answers[tick] == null)
                        Answers[tick] = a;
                }
            }
            Answers.Add(" ");
            Answers.Add(" ");

            AnswersChanged(Answers);
        }

        public void NewGame()
        {
            CurrentQuestion = 0;
        }

        public void AddQuestion(Question q)
        {
            QuestionList.Add(q);
        }

        public event QuestionDlgt QuestionChanged;
        public event StringsDlgt AnswersChanged;
    }
}
