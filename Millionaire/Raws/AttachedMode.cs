using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;

namespace Millionaire
{
    class AttachedMode
    {
        OleDbConnection Connection;
        iModel _model;

        public void AddQuestion(Question q)
        {
            List<Question> qlist = GetQuestionList();
            int index = qlist.Count;
            OleDbCommand Command = new OleDbCommand(
                string.Format("insert into Questions (ID, Question, RightAnswer, Answer1, Answer2, Answer3) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                index, q.QuestionText, q.Answers[0], q.Answers[1], q.Answers[2], q.Answers[3]), Connection);
            Command.ExecuteNonQuery();
        }

        public void DeleteQuestion(int index)
        {
            OleDbCommand Command = new OleDbCommand(
                string.Format("delete from Questions where id = {0}", index), Connection);
            Command.ExecuteNonQuery();
            int i = 0;
            List<Question> qlist = GetQuestionList();
            foreach (Question q in qlist)
            {
                Command.CommandText = string.Format("update Questions set id = {0} where Question = '{1}'", i++, q.QuestionText);
                Command.ExecuteNonQuery();
            }
        }

        public void EditQuestion(Question q, int index)
        {
            OleDbCommand Command = new OleDbCommand(
                string.Format("update Questions set Question='{0}', RightAnswer='{1}', Answer1='{2}', Answer2='{3}', Answer3='{4}' where ID={5}",
                q.QuestionText, q.Answers[0], q.Answers[1], q.Answers[2], q.Answers[3], index), Connection);
            Command.ExecuteNonQuery();
        }

        public AttachedMode(iModel ModelLink)
        {
            _model = ModelLink;
            Connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            Connection.Open();
            OleDbCommand Command = new OleDbCommand("delete * from Questions", Connection);
            Command.ExecuteNonQuery();
            int index = 0;
            foreach (Question q in ModelLink.QuestionList)
            {
                Command.CommandText = string.Format("insert into Questions (ID, Question, RightAnswer, Answer1, Answer2, Answer3) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    index++, q.QuestionText, q.Answers[0], q.Answers[1], q.Answers[2], q.Answers[3]);
                Command.ExecuteNonQuery();
            }
        }

        public void Close()
        {
            Connection.Close();
        }

        // Method that return List of Question objects from attached Db.
        public List<Question> GetQuestionList()
        {
            List<Question> list = new List<Question>();

            OleDbCommand Command = new OleDbCommand("select * from Questions", Connection);
            OleDbDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(new Question((string)Reader.GetValue(1), (string)Reader.GetValue(2),
                    (string)Reader.GetValue(3), (string)Reader.GetValue(4), (string)Reader.GetValue(5)));
            }

                return list;
        }
    }
}
