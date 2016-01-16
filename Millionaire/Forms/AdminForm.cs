using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class AdminForm : Form
    {
        iControlManage _control;

        public AdminForm(iModel model)
        {
            _control = new ControlManage(model);
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _control.AddQuestion(
                textboxNewQuestion.Text, textBoxNewAnswerRight.Text,
                textBoxNewAnswer1.Text, textBoxNewAnswer2.Text, textBoxNewAnswer3.Text
                );
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _control.DeleteQuestion(comboboxDeleteQuestion.SelectedIndex);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _control.EditQuestion(
                comboBoxEdit.SelectedIndex, comboBoxEdit.Text, textBoxEditAnswerRight.Text,
                textBoxEditAnswer1.Text, textBoxEditAnswer2.Text, textBoxEditAnswer3.Text
                );
        }

        private void buttonImportGo_Click(object sender, EventArgs e)
        {
            _control.Import(textBoxImport.Text);
        }

        private void buttonImportBrowse_Click(object sender, EventArgs e)
        {
            textBoxImport.Text = _control.OpenBrowseDialog();
        }

        private void buttonExportTXT_Click(object sender, EventArgs e)
        {
            _control.ExportTxt(textBoxExport.Text);
        }

        private void buttonExportXML_Click(object sender, EventArgs e)
        {
            _control.ExportXml(textBoxExport.Text);
        }

        private void comboBoxEdit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxEditAnswerRight.Text = _control.QuestionList[comboBoxEdit.SelectedIndex].Answers[0];
            textBoxEditAnswer1.Text = _control.QuestionList[comboBoxEdit.SelectedIndex].Answers[1];
            textBoxEditAnswer2.Text = _control.QuestionList[comboBoxEdit.SelectedIndex].Answers[2];
            textBoxEditAnswer3.Text = _control.QuestionList[comboBoxEdit.SelectedIndex].Answers[3];
        }

        //private void buttonDbAttachedMode_Click(object sender, EventArgs e)
        //{
        //    if (buttonDbAttachedMode.Text == "Включить")
        //    {
        //        _control.Attach();
        //        buttonDbPush.Enabled = false;
        //        buttonDbPull.Enabled = false;
        //        buttonDbAttachedMode.Text = "Отключить";
        //        buttonExportTXT.Enabled = false;
        //        buttonExportXML.Enabled = false;
        //        buttonImportBrowse.Enabled = false;
        //        buttonImportGo.Enabled = false;
        //    }
        //    else
        //    {
        //        _control.Detach();
        //        buttonDbPush.Enabled = true;
        //        buttonDbPull.Enabled = true;
        //        buttonDbAttachedMode.Text = "Включить";
        //        buttonExportTXT.Enabled = true;
        //        buttonExportXML.Enabled = true;
        //        buttonImportBrowse.Enabled = true;
        //        buttonImportGo.Enabled = true;
        //    }
        //}

        //private void buttonDbPush_Click(object sender, EventArgs e)
        //{
        //    _control.Push();
        //}

        //private void buttonDbPull_Click(object sender, EventArgs e)
        //{
        //    _control.Pull();
        //}

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _control.Close();
        }

        private void comboboxDeleteQuestion_DropDown(object sender, EventArgs e)
        {
            comboboxDeleteQuestion.Items.Clear();
            foreach (Question q in _control.QuestionList)
            {
                comboboxDeleteQuestion.Items.Add(q.QuestionText);
            }
        }

        private void comboBoxEdit_DropDown(object sender, EventArgs e)
        {
            comboBoxEdit.Items.Clear();
            foreach (Question q in _control.QuestionList)
            {
                comboBoxEdit.Items.Add(q.QuestionText);
            }
        }

        private void radioButtonDbOff_CheckedChanged(object sender, EventArgs e)
        {
            _control.OfflineMode();
        }

        private void radioButtonDbAttached_CheckedChanged(object sender, EventArgs e)
        {
            _control.AttachedMode();
        }

        private void radioButtonDbDetached_CheckedChanged(object sender, EventArgs e)
        {
            _control.DetachedMode();
        }

        private void buttonDbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tОтключённый режим\n"
                + "• В отключенном режиме все изменения вносятся сразу же в программу.\n\n"
                + "\tПрисоединённый режим\n"
                + "• При выборе присоединённого режима происходит подключение к базе данных и обновление её вопросами содержащимися в данный момент в программе\n"
                + "• При изменении вопросов в присоединённом режиме все изменения происходят в базе\n"
                + "• При закрытии формы программа предложит сохранить вопросы из базы в программу\n\n"
                + "\tОтсоединённый режим\n"
                + "• При выборе отсоединённого режима происходит подключение к базе данных и DataSet-а вопросами из базы данных\n"
                + "• При изменении вопросов в отсоединённом режиме все изменения происходят и в DataSet и в базе данных\n"
                + "• При закрытии формы программа предложит сохранить вопросы из DataSet в программу\n\n"
                );
        }
    }
}
