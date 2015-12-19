using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        public string[] Answers
        {
            get;
            private set;
        }

        public Model()
        {
            QuestionList = new List<Question>();
            Answers = new string[4];

            if (File.Exists("LastQuestions.txt"))
                Import("LastQuestions.txt");
        }

        public void Advance()
        {
            CurrentQuestion++;
            Random rnd = new Random();
            Answers = new string[4];

            foreach (string a in QuestionList[CurrentQuestion].Answers)
            {
                int tick = rnd.Next(0, 4);
                while (Answers[tick] != null)
                    tick = rnd.Next(0, 4);
                Answers[tick] = a;
            }

            QuestionChanged(QuestionList[CurrentQuestion].QuestionText);
            AnswersChanged(Answers);
        }

        public void FiftyFifty()
        {

        }

        public void NewGame()
        {
            CurrentQuestion = -1;
            Advance();
        }

        public void AddQuestion(Question q)
        {
            QuestionList.Add(q);
        }

        public void Die()
        {
            ExportTxt();
        }

        public void Import(string path)
        {
            string ext = Path.GetExtension(path);
            if (ext == ".txt")
            {
                string question = null;
                //Problem with encoding may be present
                using (StreamReader sr = new StreamReader(path, Encoding.UTF8, true))
                {
                    while ((question = sr.ReadLine()) != null)
                    {
                        string answerR = sr.ReadLine();
                        string answer1 = sr.ReadLine();
                        string answer2 = sr.ReadLine();
                        string answer3 = sr.ReadLine();
                        Question NewQ = new Question(question, answerR, answer1, answer2, answer3);
                        AddQuestion(NewQ);
                    }
                }
            }
            else if (ext == ".xml")
            {

            }
        }

        public void ExportTxt()
        {
            //FileStream f = new FileStream("LastQuestions.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            using (FileStream f = File.Create("LastQuestions.txt"))
            {
                using (StreamWriter sw = new StreamWriter(f))
                {
                    foreach (Question q in QuestionList)
                    {
                        sw.WriteLine(q.QuestionText);
                        foreach (string s in q.Answers)
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
            }
        }

        public event QuestionDlgt QuestionChanged;
        public event StringsDlgt AnswersChanged;
    }
}
