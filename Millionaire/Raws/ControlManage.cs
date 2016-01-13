using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Millionaire
{
    class ControlManage : iControlManage
    {
        iModel _model;
        AttachedMode AM = null;
        DetachedMode DM = null;

        public ControlManage(iModel model)
        {
            _model = model;
        }

        public List<Question> QuestionList
        {
            get
            {
                if (AM != null)
                    return AM.GetQuestionList();
                else if (DM != null)
                    return DM.GetQuestionList();
                else
                    return _model.QuestionList;
            }
        }

        /* Add/Edit/Delete methods follow the same scheme:
         * If AttachedMode is active, then class is instantiated, then we work with it
         * If not, we work with DetachedMode since it being instantiated in constructor
         */
        public void AddQuestion(string q, string ar, string a1, string a2, string a3)
        {
            Question NewQ = new Question(q, ar, a1, a2, a3);
            //_model.AddQuestion(NewQ);
            if (AM != null)
                AM.AddQuestion(NewQ);
            else if (DM != null)
                DM.AddQuestion(NewQ);
        }

        public void DeleteQuestion(int index)
        {
            //_model.DeleteQuestion(index);
            if (AM != null)
                AM.DeleteQuestion(index);
            else if (DM != null)
                DM.DeleteQuestion(index);
        }

        public void EditQuestion(int index, string q, string ar, string a1, string a2, string a3)
        {
            Question EditedQ = new Question(q, ar, a1, a2, a3);
            //_model.EditQuestion(EditedQ, index);
            if (AM != null)
                AM.EditQuestion(EditedQ, index);
            else if (DM != null)
                DM.DeleteQuestion(index);
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

        public void Attach()
        {
            AM = new AttachedMode(_model);
        }

        public void Detach()
        {
            if (AM != null)
            {
                AM.Close();
                AM = null;
            }
        }

        public void Pull()
        {
            DM = new DetachedMode(_model);
        }

        public void Push()
        {
            if (DM != null)
                DM.Push();
        }

        public void Close()
        {
            PromptForm prompt = new PromptForm();
            DialogResult result = prompt.ShowDialog();

            // If user chooses to save changes we need toupdate model from one of Db classes
            if (result == DialogResult.Yes)
            {
                // If AttachedMode is active
                if (AM != null)
                {
                    _model.QuestionList = AM.GetQuestionList();
                    AM.Close();
                }
                // Else we take questions from DataSet of DetachedMode
                else if (DM != null)
                {
                    _model.QuestionList = DM.GetQuestionList();
                }
            }
            // If user chooses not to save any changes made we don't touch Model
            if (result == DialogResult.No)
            {
                if (AM != null)
                {
                    AM.Close();
                    AM = null;
                }
            }
        }
    }
}
