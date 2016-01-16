using System.Collections.Generic;

namespace Millionaire
{
    public interface iModel
    {
        List<Question> QuestionList
        { get; set; }

        int CurrentQuestion
        { get; }

        string[] Answers
        { get; }

        int[] SumList
        { get; }

        void NewGame();
        void Advance();
        void FiftyFifty();
        void Die();

        //Functions for managing
        void AddQuestion(Question q);
        void EditQuestion(Question q, int index);
        void DeleteQuestion(int index);
        void Import(string path);
        void ExportTxt(string name);
        void ExportXml(string name);

        event QuestionDlgt QuestionChanged;
        event StringsDlgt AnswersChanged;
        event IntDlgt IndexChanged;
    }

    public delegate void QuestionDlgt(string question);
    public delegate void StringsDlgt(string[] Answers);
    public delegate void IntDlgt(int CurrentIndex);
}
