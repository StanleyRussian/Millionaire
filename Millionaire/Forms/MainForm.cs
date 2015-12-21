using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MainForm : Form
    {
        iControlMain _control = new ControlMain();
        Button[] AnswerButtons = new Button[4];

        public MainForm()
        {
            InitializeComponent();
            _control.QuestionChanged += _control_QuestionChanged;
            _control.AnswersChanged += _control_AnswersChanged;
            _control.IndexChanged += _control_IndexChanged;

            AnswerButtons[0] = buttonAnswer1;
            AnswerButtons[1] = buttonAnswer2;
            AnswerButtons[2] = buttonAnswer3;
            AnswerButtons[3] = buttonAnswer4;
        }

        private void _control_IndexChanged(int arg)
        {
            labelCurrentSum.Text = string.Format("Ваш текущий выигрыш: {0}", arg);
            if (arg != 0)
                buttonTakeMoney.Enabled = true;
            else
                buttonTakeMoney.Enabled = false;
        }

        private void _control_AnswersChanged(string[] Answers)
        {
            buttonNextQuestion.Enabled = false;
            for (int i = 0; i < 4; i++) 
            {
                AnswerButtons[i].Text = Answers[i];
                AnswerButtons[i].BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void _control_QuestionChanged(string question)
        {
            textboxQuestion.Text = question;
        }

        private void buttonFiftyFifty_Click(object sender, EventArgs e)
        {
            _control.FiftyFifty();
            buttonFiftyFifty.Enabled = false;
        }

        private void buttonFriendCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_control.FriendCall());
            buttonFriendCall.Enabled = false;
        }

        private void buttonAudienceHelp_Click(object sender, EventArgs e)
        {
            _control.AudienceHelp();
            buttonAudienceHelp.Enabled = false;
        }

        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            _control.CreateAdminForm();
            buttonNew_Click(this, null);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            _control.NewGame();
            buttonFiftyFifty.Enabled = true;
            buttonFriendCall.Enabled = true;
            buttonAudienceHelp.Enabled = true;
            buttonNextQuestion.Enabled = false;
            foreach (Button b in AnswerButtons)
                b.Enabled = true;
        }

        private void buttonTakeMoney_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    this, string.Format("Поздравляем! {0}", labelCurrentSum.Text), "Поздравляем!",
                    MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Retry)
                buttonNew_Click(this, null);
            else
                Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _control.Die();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(_control.AnswerButton(b.Text))
            {
                b.BackColor = System.Drawing.Color.LawnGreen;
                buttonNextQuestion.Enabled = true;
            }
            else
            {
                b.BackColor = System.Drawing.Color.Orange;
                var result = MessageBox.Show(
                    this, "Вы проиграли! Удачи в следующий раз", "Вы - самое слабое звено", 
                    MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                    buttonNew_Click(this, null);
                else
                    Close();
            }
            
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            _control.NextQuestion();
        }
    }
}
