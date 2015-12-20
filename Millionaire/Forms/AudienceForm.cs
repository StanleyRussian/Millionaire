using System.Windows.Forms;

namespace Millionaire
{
    public partial class AudienceForm : Form
    {
        Label[] labels = new Label[4];

        public AudienceForm(int a, int b, int c, int d, string[] answers)
        {
            InitializeComponent();
            progressBar1.Step = a;
            progressBar1.PerformStep();
            progressBar2.Step = b;
            progressBar2.PerformStep();
            progressBar3.Step = c;
            progressBar3.PerformStep();
            progressBar4.Step = d;
            progressBar4.PerformStep();

            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            for (int i = 0; i < 4; i++) 
                labels[i].Text = answers[i];
        }
    }
}
