using System.Collections.Generic;

namespace Millionaire
{
    interface iControlManage
    {
        void AddQuestion(string q, string ar, string a1, string a2, string a3);
        void EditQuestion(int index, string q, string ar, string a1, string a2, string a3);
        void DeleteQuestion(int index);
        void Import(string path);
        void ExportTxt(string name);
        void ExportXml(string name);
        string OpenBrowseDialog();

        void Attach();
        void Detach();
        void Pull();
        void Push();

        List<Question> QuestionList
        { get; }

        void Close();
    }
}
