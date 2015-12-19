using System;
using System.Collections.Generic;

namespace Millionaire
{
    interface iModel
    {
        List<Question> QuestionList
        { get; }

        //int CurrentQuestion
        //{ get; }

        List<string> Answers
        { get; }

        void NewGame();
        void Advance();
        void FiftyFifty();
        //Other cheats don't go into model methods since they don't change it.

        //Functions for managing form
        void AddQuestion(Question q);

        event QuestionDlgt QuestionChanged;
        event StringsDlgt AnswersChanged;
    }

    public delegate void QuestionDlgt(string question);
    public delegate void StringsDlgt(List<string> Answers);
}
