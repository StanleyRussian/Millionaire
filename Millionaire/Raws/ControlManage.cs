using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void AddQuestion(string q, string ar, string a1, string a2, string a3)
        {
            Question NewQ = new Question(q, ar, a1, a2, a3);
            _model.AddQuestion(NewQ);
        }

        public void Import(string path)
        {
            string ext = Path.GetExtension(path);
            if (ext == ".txt")
            {
                string question = null;
                //Problem with encoding may be present
                StreamReader sr = new StreamReader(path, true);
                while ((question = sr.ReadLine()) != null) 
                {
                    string answerR = sr.ReadLine();
                    string answer1 = sr.ReadLine();
                    string answer2 = sr.ReadLine();
                    string answer3 = sr.ReadLine();
                    Question NewQ = new Question(question, answerR, answer1, answer2, answer3);
                    _model.AddQuestion(NewQ);
                }
            }
            else if (ext == ".xml")
            {
                
            }
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
