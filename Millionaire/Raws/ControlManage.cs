using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Millionaire
{
    class ControlManage : iControlManage
    {
        iModel _model;

        public ControlManage(iModel model)
        {
            _model = model;
        }

        public List<Question> QuestionList
        {
            get { return _model.QuestionList; }
        }

        public void AddQuestion(string q, string ar, string a1, string a2, string a3)
        {
            Question NewQ = new Question(q, ar, a1, a2, a3);
            _model.AddQuestion(NewQ);
        }

        public void DeleteQuestion(int index)
        {
            _model.DeleteQuestion(index);
        }

        public void EditQuestion(int index, string q, string ar, string a1, string a2, string a3)
        {
            Question EditedQ = new Question(q, ar, a1, a2, a3);
            _model.EditQuestion(EditedQ, index);
        }

        public void ExportTxt(string name)
        {
            _model.ExportTxt(name);
        }

        public void ExportXml(string name)
        {
            _model.ExportXml(name);
        }

        public void Import(string path)
        {
            _model.Import(path);
        }

        public string OpenBrowseDialog()
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
                return opendlg.FileName;

            return null;
        }
    }
}
