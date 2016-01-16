using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Millionaire
{
    class Model : iModel
    {
        public int CurrentQuestion
        {
            get;
            private set;
        }

        public List<Question> QuestionList
        {
            get;
            set;
        }

        public string[] Answers
        {
            get;
            private set;
        }

        public int[] SumList
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
            IndexChanged(SumList[CurrentQuestion]);
        }

        public void FiftyFifty()
        {
            Random rnd = new Random();
            Answers = new string[4];

            for (int i = 0; i < 2; i++)
            {
                int tick = rnd.Next(0, 4);
                while (Answers[tick] != null)
                    tick = rnd.Next(0, 4);
                Answers[tick] = QuestionList[CurrentQuestion].Answers[i];
            }

            AnswersChanged(Answers);
        }

        public void NewGame()
        {
            if (QuestionList.Count == 0)
            {
                QuestionList.Add(new Question(
                    "Вопросы с предыдущего запуска не найдены, пожалуйста импортируйет вопросы в настройках", "☻", "☺", "☻", "☺"));
                QuestionChanged(QuestionList[CurrentQuestion].QuestionText);
                AnswersChanged(QuestionList[CurrentQuestion].Answers);
                return;
            }

            CurrentQuestion = -1;
            SumList = new int[QuestionList.Count];
            int step = 1000000 / QuestionList.Count;
            for (int i = 0; i < QuestionList.Count - 1; i++)
            {
                SumList[i] = step * i;
            }
            SumList[QuestionList.Count - 1] = 1000000;
            Advance();

        }

        public void AddQuestion(Question q)
        {
            QuestionList.Add(q);
        }

        public void Die()
        {
            ExportTxt("LastQuestions");
        }

        public void Import(string path)
        { 
            string ext = Path.GetExtension(path);
            if (ext == ".txt")
            {
                QuestionList.Clear();
                string question = null;
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
                QuestionList.Clear();
                using (XmlTextReader Xreader = new XmlTextReader(path))
                {
                    Xreader.WhitespaceHandling = WhitespaceHandling.None;
                    while (Xreader.Read())
                    {
                        if (Xreader.Name == "Question")
                        {
                            string Qtext = Xreader.GetAttribute("QuestionText");
                            string RAnswer = null;
                            string[] Answers = new string[3];
                            Xreader.Read();
                            if (Xreader.Name == "RightAnswer")
                            {
                                Xreader.Read();
                                RAnswer = Xreader.Value;
                                Xreader.Read();
                            }
                            for (int i = 1; i <= 3; i++)
                            {
                                Xreader.Read();
                                if (Xreader.Name == string.Format("Answer{0}", i))
                                {
                                    Xreader.Read();
                                    Answers[i - 1] = Xreader.Value;
                                    Xreader.Read();
                                }
                            }
                            QuestionList.Add(new Question(Qtext, RAnswer, Answers[0], Answers[1], Answers[2]));
                            Xreader.Read();
                        }
                    }
                }
            }
        }

        public void ExportTxt(string name)
        {
            if (Path.GetExtension(name) != ".txt")
                name += ".txt";
            using (FileStream f = File.Create(name))
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

        public void EditQuestion(Question q, int index)
        {
            QuestionList[index] = q;
        }

        public void DeleteQuestion(int index)
        {
            QuestionList.RemoveAt(index);
        }

        public void ExportXml(string name)
        {
            using (XmlTextWriter Xwriter = new XmlTextWriter(name + ".xml", Encoding.Unicode)) 
            {
                Xwriter.Formatting = Formatting.Indented;
                Xwriter.WriteStartDocument();
                Xwriter.WriteStartElement("Questions");
                foreach (Question q in QuestionList)
                {
                    Xwriter.WriteStartElement("Question");
                    Xwriter.WriteAttributeString("QuestionText", q.QuestionText);
                    Xwriter.WriteElementString("RightAnswer", q.Answers[0]);
                    for (int i = 1; i <= 3; i++)
                    {
                        Xwriter.WriteElementString(string.Format("Answer{0}", i), q.Answers[i]);
                    }
                    Xwriter.WriteEndElement();
                }
                Xwriter.WriteEndElement();
            }
        }

        public event QuestionDlgt QuestionChanged;
        public event StringsDlgt AnswersChanged;
        public event IntDlgt IndexChanged;
    }
}
