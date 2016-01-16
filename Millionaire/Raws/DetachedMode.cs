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
            //DataRow Dr = Ds.Tables[0].NewRow();
            //Dr["id"] = Ds.Tables[0].Rows.Count + 1;
            //Dr["Question"] = q.QuestionText;
            //Dr["RightAnswer"] = q.Answers[0];
            //Dr["Answer1"] = q.Answers[1];
            //Dr["Answer2"] = q.Answers[2];
            //Dr["Answer3"] = q.Answers[3];
            //Ds.Tables[0].Rows.RemoveAt(index);
            //Ds.Tables[0].Rows.InsertAt(Dr, index);

            //DataRow[] ar = Ds.Tables[0].Select("id = " + index);
            DataRow ar = Ds.Tables[0].Rows[index];
            ar["Question"] = q.QuestionText;
            ar["RightAnswer"] = q.Answers[0];
            ar["Answer1"] = q.Answers[1];
            ar["Answer2"] = q.Answers[2];
            ar["Answer3"] = q.Answers[3];
            Adapter.Update(Ds);
            Ds.Clear();
            Adapter.Fill(Ds);
        }

        public DetachedMode(iModel ModelLink)
        {
            _model = ModelLink;
            Connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            Ds = new DataSet();
            // Creating DataTable and adding it to DataSet
            //DataTable Dt = new DataTable("Questions");
            //Dt.Columns.Add("ID", Type.GetType("System.Int32"));
            //Dt.Columns.Add("Question", Type.GetType("System.String"));
            //Dt.Columns.Add("RightAnswer", Type.GetType("System.String"));
            //Dt.Columns.Add("Answer1", Type.GetType("System.String"));
            //Dt.Columns.Add("Answer2", Type.GetType("System.String"));
            //Dt.Columns.Add("Answer3", Type.GetType("System.String"));
            //Ds.Tables.Add(Dt);
            Adapter = new OleDbDataAdapter("select * from Questions", Connection);
            Builder = new OleDbCommandBuilder(Adapter);
            Adapter.Fill(Ds);

            // Adding questions from model to DataSet
            //foreach (Question q in ModelLink.QuestionList)
            //{
            //    AddQuestion(q);
            //}
        }

        //public void Push()
        //{
        //    //Connection.Open();
        //    OleDbDataAdapter Adapter = new OleDbDataAdapter("select * from Questions", Connection);
        //    OleDbCommandBuilder Builder = new OleDbCommandBuilder(Adapter);
        //    Adapter.Update(Ds);
        //    Ds.Clear();
        //    Adapter.Fill(Ds);
        //    //Connection.Close();
        //}

        //public void Pull()
        //{  
        //    //Connection.Open();
        //    OleDbDataAdapter Adapter = new OleDbDataAdapter("select * from Questions", Connection);
        //    Adapter.Fill(Ds);
        //    //Connection.Close();
        //}

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
