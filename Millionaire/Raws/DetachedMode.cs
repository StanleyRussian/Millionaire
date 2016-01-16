using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Millionaire
{
    class DetachedMode
    {
        OleDbConnection Connection;
        DataSet Ds;
        OleDbDataAdapter Adapter;
        OleDbCommandBuilder Builder;
        iModel _model;

        public void AddQuestion(Question q)
        {
            DataRow Dr = Ds.Tables[0].NewRow();
            Dr["id"] = Ds.Tables[0].Rows.Count;
            Dr["Question"] = q.QuestionText;
            Dr["RightAnswer"] = q.Answers[0];
            Dr["Answer1"] = q.Answers[1];
            Dr["Answer2"] = q.Answers[2];
            Dr["Answer3"] = q.Answers[3];
            Ds.Tables[0].Rows.Add(Dr);
            Adapter.Update(Ds);
            Ds.Clear();
            Adapter.Fill(Ds);
        }

        public void DeleteQuestion(int index)
        {
            Ds.Tables[0].Rows[index].Delete();
            Adapter.Update(Ds);
            Ds.Clear();
            Adapter.Fill(Ds);
        }

        public void EditQuestion(Question q, int index)
        {
            Ds.Tables[0].Rows[index]["Question"] = q.QuestionText;
            Ds.Tables[0].Rows[index]["RightAnswer"] = q.Answers[0];
            Ds.Tables[0].Rows[index]["Answer1"] = q.Answers[1];
            Ds.Tables[0].Rows[index]["Answer2"] = q.Answers[2];
            Ds.Tables[0].Rows[index]["Answer3"] = q.Answers[3];

            Adapter.Update(Ds);
            Ds.Clear();
            Adapter.Fill(Ds);
        }

        public DetachedMode(iModel ModelLink)
        {
            _model = ModelLink;
            Connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            Ds = new DataSet();
            Adapter = new OleDbDataAdapter("select * from Questions", Connection);
            Builder = new OleDbCommandBuilder(Adapter);
            Adapter.Fill(Ds);
        }

        // Method that repacks DataSet to List of Question objects.
        public List<Question> GetQuestionList()
        {
            List<Question> list = new List<Question>();

            foreach (DataRow Dr in Ds.Tables[0].Rows)
            {
                list.Add(new Question((string)Dr["Question"], (string)Dr["RightAnswer"], 
                    (string)Dr["Answer1"], (string)Dr["Answer2"], (string)Dr["Answer3"]));
            }

            return list;
        }
    }
}
