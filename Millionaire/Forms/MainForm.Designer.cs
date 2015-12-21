namespace Millionaire
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonTakeMoney = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAudienceHelp = new System.Windows.Forms.Button();
            this.buttonFriendCall = new System.Windows.Forms.Button();
            this.buttonFiftyFifty = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.textboxQuestion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.labelCurrentSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(18, 416);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(96, 37);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Новая игра";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonTakeMoney
            // 
            this.buttonTakeMoney.Enabled = false;
            this.buttonTakeMoney.Location = new System.Drawing.Point(220, 416);
            this.buttonTakeMoney.Name = "buttonTakeMoney";
            this.buttonTakeMoney.Size = new System.Drawing.Size(96, 37);
            this.buttonTakeMoney.TabIndex = 1;
            this.buttonTakeMoney.Text = "Забрать деньги";
            this.buttonTakeMoney.UseVisualStyleBackColor = true;
            this.buttonTakeMoney.Click += new System.EventHandler(this.buttonTakeMoney_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAudienceHelp);
            this.groupBox1.Controls.Add(this.buttonFriendCall);
            this.groupBox1.Controls.Add(this.buttonFiftyFifty);
            this.groupBox1.Location = new System.Drawing.Point(18, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonAudienceHelp
            // 
            this.buttonAudienceHelp.Enabled = false;
            this.buttonAudienceHelp.Location = new System.Drawing.Point(206, 16);
            this.buttonAudienceHelp.Name = "buttonAudienceHelp";
            this.buttonAudienceHelp.Size = new System.Drawing.Size(86, 52);
            this.buttonAudienceHelp.TabIndex = 2;
            this.buttonAudienceHelp.Text = "Помощь зала";
            this.buttonAudienceHelp.UseVisualStyleBackColor = true;
            this.buttonAudienceHelp.Click += new System.EventHandler(this.buttonAudienceHelp_Click);
            // 
            // buttonFriendCall
            // 
            this.buttonFriendCall.Enabled = false;
            this.buttonFriendCall.Location = new System.Drawing.Point(107, 16);
            this.buttonFriendCall.Name = "buttonFriendCall";
            this.buttonFriendCall.Size = new System.Drawing.Size(86, 52);
            this.buttonFriendCall.TabIndex = 1;
            this.buttonFriendCall.Text = "Звонок другу";
            this.buttonFriendCall.UseVisualStyleBackColor = true;
            this.buttonFriendCall.Click += new System.EventHandler(this.buttonFriendCall_Click);
            // 
            // buttonFiftyFifty
            // 
            this.buttonFiftyFifty.Enabled = false;
            this.buttonFiftyFifty.Location = new System.Drawing.Point(6, 16);
            this.buttonFiftyFifty.Name = "buttonFiftyFifty";
            this.buttonFiftyFifty.Size = new System.Drawing.Size(86, 52);
            this.buttonFiftyFifty.TabIndex = 0;
            this.buttonFiftyFifty.Text = "50:50";
            this.buttonFiftyFifty.UseVisualStyleBackColor = true;
            this.buttonFiftyFifty.Click += new System.EventHandler(this.buttonFiftyFifty_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAnswer4);
            this.groupBox3.Controls.Add(this.buttonAnswer3);
            this.groupBox3.Controls.Add(this.buttonAnswer2);
            this.groupBox3.Controls.Add(this.buttonAnswer1);
            this.groupBox3.Controls.Add(this.textboxQuestion);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 267);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Enabled = false;
            this.buttonAnswer4.Location = new System.Drawing.Point(6, 217);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(292, 41);
            this.buttonAnswer4.TabIndex = 4;
            this.buttonAnswer4.Text = "buttonAnswer4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Enabled = false;
            this.buttonAnswer3.Location = new System.Drawing.Point(6, 170);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(292, 41);
            this.buttonAnswer3.TabIndex = 3;
            this.buttonAnswer3.Text = "buttonAnswer3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Enabled = false;
            this.buttonAnswer2.Location = new System.Drawing.Point(6, 123);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(292, 41);
            this.buttonAnswer2.TabIndex = 2;
            this.buttonAnswer2.Text = "buttonAnswer2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Enabled = false;
            this.buttonAnswer1.Location = new System.Drawing.Point(6, 76);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(292, 41);
            this.buttonAnswer1.TabIndex = 1;
            this.buttonAnswer1.Text = "buttonAnswer1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // textboxQuestion
            // 
            this.textboxQuestion.Location = new System.Drawing.Point(6, 19);
            this.textboxQuestion.Multiline = true;
            this.textboxQuestion.Name = "textboxQuestion";
            this.textboxQuestion.ReadOnly = true;
            this.textboxQuestion.Size = new System.Drawing.Size(292, 49);
            this.textboxQuestion.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAdmin
            // 
            this.ToolStripMenuItemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.ToolStripMenuItemAdmin.Name = "ToolStripMenuItemAdmin";
            this.ToolStripMenuItemAdmin.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItemAdmin.Text = "Настройки";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemSettings.Text = "Вопросы...";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Enabled = false;
            this.buttonNextQuestion.Location = new System.Drawing.Point(118, 416);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(96, 37);
            this.buttonNextQuestion.TabIndex = 7;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // labelCurrentSum
            // 
            this.labelCurrentSum.AutoSize = true;
            this.labelCurrentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentSum.Location = new System.Drawing.Point(20, 384);
            this.labelCurrentSum.Name = "labelCurrentSum";
            this.labelCurrentSum.Size = new System.Drawing.Size(192, 24);
            this.labelCurrentSum.TabIndex = 8;
            this.labelCurrentSum.Text = "Начните новую игру";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 535);
            this.Controls.Add(this.labelCurrentSum);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonTakeMoney);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Кто хочет стать миллионером?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonTakeMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAudienceHelp;
        private System.Windows.Forms.Button buttonFriendCall;
        private System.Windows.Forms.Button buttonFiftyFifty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.TextBox textboxQuestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelCurrentSum;
    }
}

