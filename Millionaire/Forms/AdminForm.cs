using System;
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
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonImportGo_Click(object sender, EventArgs e)
        {
            _control.Import(textBoxImport.Text);
        }

        private void buttonImportBrowse_Click(object sender, EventArgs e)
        {
            textBoxImport.Text = _control.OpenBrowseDialog();
        }

        private void buttonExportBrowse_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportTXT_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportXML_Click(object sender, EventArgs e)
        {

        }
    }
}
