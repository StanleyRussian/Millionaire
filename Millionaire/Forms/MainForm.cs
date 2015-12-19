using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MainForm : Form
    {
        iControlMain _control = new ControlMain();

        public MainForm()
        {
            InitializeComponent();
            _control.QuestionChanged += _control_QuestionChanged;
            _control.AnswersChanged += _control_AnswersChanged;
        }

        private void _control_AnswersChanged(string[] Answers)
        {
            //Yes, it definitely can see some improvement, i know
            buttonAnswer1.Text = Answers[0];
            buttonAnswer2.Text = Answers[1];
            buttonAnswer3.Text = Answers[2];
            buttonAnswer4.Text = Answers[3];
        }

        private void _control_QuestionChanged(string question)
        {
            textboxQuestion.Text = question;
        }

        private void buttonFiftyFifty_Click(object sender, EventArgs e)
        {
            _control.FiftyFifty();
        }

        private void buttonFriendCall_Click(object sender, EventArgs e)
        {
            _control.FriendCall();
        }

        private void buttonAudienceHelp_Click(object sender, EventArgs e)
        {
            _control.FriendCall();
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            _control.AnswerButton(1);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            _control.AnswerButton(2);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            _control.AnswerButton(3);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            _control.AnswerButton(4);
        }

        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            _control.CreateAdminForm();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            _control.NewGame();
        }

        private void buttonTakeMoney_Click(object sender, EventArgs e)
        {
            _control.PlayerExit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _control.Die();
        }
    }
}
