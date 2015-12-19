using System;
using System.Collections.Generic;

namespace Millionaire
{
    public interface iModel
    {
        List<Question> QuestionList
        { get; }

        //int CurrentQuestion
        //{ get; }

        string[] Answers
        { get; }

        void NewGame();
        void Advance();
        void FiftyFifty();
        void Die();

        //Functions for managing
        void AddQuestion(Question q);
        void Import(string path);
        void ExportTxt();

        event QuestionDlgt QuestionChanged;
        event StringsDlgt AnswersChanged;
    }

    public delegate void QuestionDlgt(string question);
    public delegate void StringsDlgt(string[] Answers);
}
