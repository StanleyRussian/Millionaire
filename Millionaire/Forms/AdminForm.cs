using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class AdminForm : Form
    {
        iControlManage _control;
        List<Question> qList;

        public AdminForm(iModel model)
        {
            _control = new ControlManage(model);
            InitializeComponent();

            qList = new List<Question>();
            foreach (Question q in _control.QuestionList)
            {
                qList.Add(q);
                comboboxDeleteQuestion.Items.Add(q.QuestionText);
                comboBoxEdit.Items.Add(q.QuestionText);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _control.AddQuestion(
                textboxNewQuestion.Text, textBoxNewAnswerRight.Text,
                textBoxNewAnswer1.Text, textBoxNewAnswer2.Text, textBoxNewAnswer3.Text
                );
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _control.DeleteQuestion(comboboxDeleteQuestion.SelectedIndex);
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _control.EditQuestion(
                comboBoxEdit.SelectedIndex, comboBoxEdit.Text, textBoxEditAnswerRight.Text,
                textBoxEditAnswer1.Text, textBoxEditAnswer2.Text, textBoxEditAnswer3.Text
                );
            Close();
        }

        private void buttonImportGo_Click(object sender, EventArgs e)
        {
            _control.Import(textBoxImport.Text);
            Close();
        }

        private void buttonImportBrowse_Click(object sender, EventArgs e)
        {
            textBoxImport.Text = _control.OpenBrowseDialog();
        }

        private void buttonExportTXT_Click(object sender, EventArgs e)
        {
            _control.ExportTxt(textBoxExport.Text);
            Close();
        }

        private void buttonExportXML_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxEdit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxEditAnswerRight.Text = qList[comboBoxEdit.SelectedIndex].Answers[0];
            textBoxEditAnswer1.Text = qList[comboBoxEdit.SelectedIndex].Answers[1];
            textBoxEditAnswer2.Text = qList[comboBoxEdit.SelectedIndex].Answers[2];
            textBoxEditAnswer3.Text = qList[comboBoxEdit.SelectedIndex].Answers[3];
        }

        private void buttonExportBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}
