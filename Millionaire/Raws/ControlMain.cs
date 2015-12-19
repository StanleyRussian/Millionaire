using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class ControlMain : iControlMain
    {
        iModel _model = new Model();
        ControlManage ManageCtrl;

        public event QuestionDlgt QuestionChanged;
        public event StringsDlgt AnswersChanged;

        public ControlMain()
        {
            ManageCtrl = new ControlManage(_model);

            _model.QuestionChanged += _model_QuestionChanged;
            _model.AnswersChanged += _model_AnswersChanged;
        }

        private void _model_AnswersChanged(List<string> Answers)
        {
            throw new NotImplementedException();
        }

        private void _model_QuestionChanged(string question)
        {
            QuestionChanged(question);
        }

        public void NewGame()
        {
            _model.NewGame();
        }

        public void PlayerExit()
        {
            throw new NotImplementedException();
        }

        public void AnswerButton(int index)
        {
            throw new NotImplementedException();
        }

        public void AudienceHelp()
        {
            throw new NotImplementedException();
        }

        public void FiftyFifty()
        {
            throw new NotImplementedException();
        }

        public void FriendCall()
        {
            throw new NotImplementedException();
        }

        public void CreateAdminForm()
        {
            AdminForm adform = new AdminForm(_model);
            adform.ShowDialog();
        }
    }
}
