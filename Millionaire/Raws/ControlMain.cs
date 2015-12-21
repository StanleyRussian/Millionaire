using System;

namespace Millionaire
{
    class ControlMain : iControlMain
    {
        iModel _model = new Model();
        ControlManage ManageCtrl;

        public int[] SumList
        {
            get { return _model.SumList; }
        }

        public event QuestionDlgt QuestionChanged;
        public event StringsDlgt AnswersChanged;
        public event IntDlgt IndexChanged;

        public ControlMain()
        {
            ManageCtrl = new ControlManage(_model);

            _model.QuestionChanged += _model_QuestionChanged;
            _model.AnswersChanged += _model_AnswersChanged;
            _model.IndexChanged += _model_IndexChanged;
        }

        private void _model_IndexChanged(int CurrentIndex)
        {
            IndexChanged(CurrentIndex);
        }

        private void _model_AnswersChanged(string[] Answers)
        {
            AnswersChanged(Answers);
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

        public bool AnswerButton(string answer)
        {
            if (answer == _model.QuestionList[_model.CurrentQuestion].Answers[0])
            {
                return true;
            }
            else
                return false;
        }

        public void AudienceHelp()
        {
            Random rand = new Random();
            int a = rand.Next(0, 50);
            int b = rand.Next(0, 50);
            int c = rand.Next(0, 50);
            int d = 100 - (a + b + c);
            AudienceForm af = new AudienceForm(a, b, c, d, _model.Answers);
            af.Show();
        }

        public void FiftyFifty()
        {
            _model.FiftyFifty();
        }

        public string FriendCall()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 1)
                return "К сожалению, никто не ответил на звонок";
            else
                return string.Format("Я уверен, что это {0}", _model.Answers[rand.Next(0, 4)]);
           
        }

        public void CreateAdminForm()
        {
            AdminForm adform = new AdminForm(_model);
            adform.ShowDialog();
        }

        public void Die()
        {
            _model.Die();
        }

        public void NextQuestion()
        {
            _model.Advance();
        }
    }
}
