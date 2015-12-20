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
