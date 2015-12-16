namespace Millionaire
{
    partial class AdminForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpageAdd = new System.Windows.Forms.TabPage();
            this.tabpageDelete = new System.Windows.Forms.TabPage();
            this.tabpageEdit = new System.Windows.Forms.TabPage();
            this.textboxNewQuestion = new System.Windows.Forms.TextBox();
            this.textboxAnswer_Right = new System.Windows.Forms.TextBox();
            this.textboxAnswer_1 = new System.Windows.Forms.TextBox();
            this.textboxAnswer_2 = new System.Windows.Forms.TextBox();
            this.textboxAnswer_3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxDeleteQuestion = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEditAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswerRight = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tabpageImportExport = new System.Windows.Forms.TabPage();
            this.textBoxImport = new System.Windows.Forms.TextBox();
            this.buttonImportBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImportGo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonExportBrowse = new System.Windows.Forms.Button();
            this.buttonExportTXT = new System.Windows.Forms.Button();
            this.buttonExportXML = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabpageAdd.SuspendLayout();
            this.tabpageDelete.SuspendLayout();
            this.tabpageEdit.SuspendLayout();
            this.tabpageImportExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageAdd);
            this.tabControl.Controls.Add(this.tabpageDelete);
            this.tabControl.Controls.Add(this.tabpageEdit);
            this.tabControl.Controls.Add(this.tabpageImportExport);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(381, 260);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabpageAdd
            // 
            this.tabpageAdd.Controls.Add(this.buttonAdd);
            this.tabpageAdd.Controls.Add(this.label3);
            this.tabpageAdd.Controls.Add(this.label2);
            this.tabpageAdd.Controls.Add(this.label1);
            this.tabpageAdd.Controls.Add(this.textboxAnswer_3);
            this.tabpageAdd.Controls.Add(this.textboxAnswer_2);
            this.tabpageAdd.Controls.Add(this.textboxAnswer_1);
            this.tabpageAdd.Controls.Add(this.textboxAnswer_Right);
            this.tabpageAdd.Controls.Add(this.textboxNewQuestion);
            this.tabpageAdd.Location = new System.Drawing.Point(4, 40);
            this.tabpageAdd.Name = "tabpageAdd";
            this.tabpageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAdd.Size = new System.Drawing.Size(373, 216);
            this.tabpageAdd.TabIndex = 0;
            this.tabpageAdd.Text = "Добавление вопроса";
            this.tabpageAdd.UseVisualStyleBackColor = true;
            // 
            // tabpageDelete
            // 
            this.tabpageDelete.Controls.Add(this.buttonDelete);
            this.tabpageDelete.Controls.Add(this.label4);
            this.tabpageDelete.Controls.Add(this.comboboxDeleteQuestion);
            this.tabpageDelete.Location = new System.Drawing.Point(4, 40);
            this.tabpageDelete.Name = "tabpageDelete";
            this.tabpageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDelete.Size = new System.Drawing.Size(373, 216);
            this.tabpageDelete.TabIndex = 1;
            this.tabpageDelete.Text = "Удаление вопроса";
            this.tabpageDelete.UseVisualStyleBackColor = true;
            // 
            // tabpageEdit
            // 
            this.tabpageEdit.Controls.Add(this.buttonEdit);
            this.tabpageEdit.Controls.Add(this.label6);
            this.tabpageEdit.Controls.Add(this.label7);
            this.tabpageEdit.Controls.Add(this.textBoxEditAnswer3);
            this.tabpageEdit.Controls.Add(this.textBoxEditAnswer2);
            this.tabpageEdit.Controls.Add(this.textBoxEditAnswer1);
            this.tabpageEdit.Controls.Add(this.textBoxEditAnswerRight);
            this.tabpageEdit.Controls.Add(this.label5);
            this.tabpageEdit.Controls.Add(this.comboBoxEdit);
            this.tabpageEdit.Location = new System.Drawing.Point(4, 40);
            this.tabpageEdit.Name = "tabpageEdit";
            this.tabpageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageEdit.Size = new System.Drawing.Size(373, 216);
            this.tabpageEdit.TabIndex = 2;
            this.tabpageEdit.Text = "Редактирование вопроса";
            this.tabpageEdit.UseVisualStyleBackColor = true;
            // 
            // textboxNewQuestion
            // 
            this.textboxNewQuestion.Location = new System.Drawing.Point(9, 19);
            this.textboxNewQuestion.Name = "textboxNewQuestion";
            this.textboxNewQuestion.Size = new System.Drawing.Size(355, 20);
            this.textboxNewQuestion.TabIndex = 0;
            // 
            // textboxAnswer_Right
            // 
            this.textboxAnswer_Right.Location = new System.Drawing.Point(9, 58);
            this.textboxAnswer_Right.Name = "textboxAnswer_Right";
            this.textboxAnswer_Right.Size = new System.Drawing.Size(355, 20);
            this.textboxAnswer_Right.TabIndex = 1;
            // 
            // textboxAnswer_1
            // 
            this.textboxAnswer_1.Location = new System.Drawing.Point(9, 97);
            this.textboxAnswer_1.Name = "textboxAnswer_1";
            this.textboxAnswer_1.Size = new System.Drawing.Size(355, 20);
            this.textboxAnswer_1.TabIndex = 2;
            // 
            // textboxAnswer_2
            // 
            this.textboxAnswer_2.Location = new System.Drawing.Point(9, 123);
            this.textboxAnswer_2.Name = "textboxAnswer_2";
            this.textboxAnswer_2.Size = new System.Drawing.Size(355, 20);
            this.textboxAnswer_2.TabIndex = 3;
            // 
            // textboxAnswer_3
            // 
            this.textboxAnswer_3.Location = new System.Drawing.Point(9, 149);
            this.textboxAnswer_3.Name = "textboxAnswer_3";
            this.textboxAnswer_3.Size = new System.Drawing.Size(355, 20);
            this.textboxAnswer_3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите новый вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите правильный ответ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите остальные варианты ответов";
            // 
            // comboboxDeleteQuestion
            // 
            this.comboboxDeleteQuestion.FormattingEnabled = true;
            this.comboboxDeleteQuestion.Location = new System.Drawing.Point(9, 19);
            this.comboboxDeleteQuestion.Name = "comboboxDeleteQuestion";
            this.comboboxDeleteQuestion.Size = new System.Drawing.Size(358, 21);
            this.comboboxDeleteQuestion.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(269, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выберите вопрос";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(269, 182);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выберите вопрос";
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(358, 21);
            this.comboBoxEdit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Остальные варианты ответов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Правильный ответ";
            // 
            // textBoxEditAnswer3
            // 
            this.textBoxEditAnswer3.Location = new System.Drawing.Point(10, 149);
            this.textBoxEditAnswer3.Name = "textBoxEditAnswer3";
            this.textBoxEditAnswer3.Size = new System.Drawing.Size(355, 20);
            this.textBoxEditAnswer3.TabIndex = 11;
            // 
            // textBoxEditAnswer2
            // 
            this.textBoxEditAnswer2.Location = new System.Drawing.Point(10, 123);
            this.textBoxEditAnswer2.Name = "textBoxEditAnswer2";
            this.textBoxEditAnswer2.Size = new System.Drawing.Size(355, 20);
            this.textBoxEditAnswer2.TabIndex = 10;
            // 
            // textBoxEditAnswer1
            // 
            this.textBoxEditAnswer1.Location = new System.Drawing.Point(10, 97);
            this.textBoxEditAnswer1.Name = "textBoxEditAnswer1";
            this.textBoxEditAnswer1.Size = new System.Drawing.Size(355, 20);
            this.textBoxEditAnswer1.TabIndex = 9;
            // 
            // textBoxEditAnswerRight
            // 
            this.textBoxEditAnswerRight.Location = new System.Drawing.Point(10, 58);
            this.textBoxEditAnswerRight.Name = "textBoxEditAnswerRight";
            this.textBoxEditAnswerRight.Size = new System.Drawing.Size(355, 20);
            this.textBoxEditAnswerRight.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(266, 182);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 23);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // tabpageImportExport
            // 
            this.tabpageImportExport.Controls.Add(this.groupBox2);
            this.tabpageImportExport.Controls.Add(this.groupBox1);
            this.tabpageImportExport.Location = new System.Drawing.Point(4, 40);
            this.tabpageImportExport.Name = "tabpageImportExport";
            this.tabpageImportExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageImportExport.Size = new System.Drawing.Size(373, 216);
            this.tabpageImportExport.TabIndex = 3;
            this.tabpageImportExport.Text = "Импорт/Экспорт";
            this.tabpageImportExport.UseVisualStyleBackColor = true;
            // 
            // textBoxImport
            // 
            this.textBoxImport.Location = new System.Drawing.Point(6, 19);
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(265, 20);
            this.textBoxImport.TabIndex = 1;
            // 
            // buttonImportBrowse
            // 
            this.buttonImportBrowse.Location = new System.Drawing.Point(277, 17);
            this.buttonImportBrowse.Name = "buttonImportBrowse";
            this.buttonImportBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonImportBrowse.TabIndex = 2;
            this.buttonImportBrowse.Text = "Обзор...";
            this.buttonImportBrowse.UseVisualStyleBackColor = true;
            this.buttonImportBrowse.Click += new System.EventHandler(this.buttonImportBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImportGo);
            this.groupBox1.Controls.Add(this.buttonImportBrowse);
            this.groupBox1.Controls.Add(this.textBoxImport);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Импорт";
            // 
            // buttonImportGo
            // 
            this.buttonImportGo.Location = new System.Drawing.Point(203, 67);
            this.buttonImportGo.Name = "buttonImportGo";
            this.buttonImportGo.Size = new System.Drawing.Size(149, 23);
            this.buttonImportGo.TabIndex = 3;
            this.buttonImportGo.Text = "Импортировать вопросы";
            this.buttonImportGo.UseVisualStyleBackColor = true;
            this.buttonImportGo.Click += new System.EventHandler(this.buttonImportGo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExportXML);
            this.groupBox2.Controls.Add(this.buttonExportTXT);
            this.groupBox2.Controls.Add(this.buttonExportBrowse);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Экспорт";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 20);
            this.textBox6.TabIndex = 1;
            // 
            // buttonExportBrowse
            // 
            this.buttonExportBrowse.Location = new System.Drawing.Point(277, 19);
            this.buttonExportBrowse.Name = "buttonExportBrowse";
            this.buttonExportBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonExportBrowse.TabIndex = 3;
            this.buttonExportBrowse.Text = "Обзор...";
            this.buttonExportBrowse.UseVisualStyleBackColor = true;
            this.buttonExportBrowse.Click += new System.EventHandler(this.buttonExportBrowse_Click);
            // 
            // buttonExportTXT
            // 
            this.buttonExportTXT.Location = new System.Drawing.Point(196, 73);
            this.buttonExportTXT.Name = "buttonExportTXT";
            this.buttonExportTXT.Size = new System.Drawing.Size(75, 23);
            this.buttonExportTXT.TabIndex = 4;
            this.buttonExportTXT.Text = ".txt";
            this.buttonExportTXT.UseVisualStyleBackColor = true;
            this.buttonExportTXT.Click += new System.EventHandler(this.buttonExportTXT_Click);
            // 
            // buttonExportXML
            // 
            this.buttonExportXML.Location = new System.Drawing.Point(277, 73);
            this.buttonExportXML.Name = "buttonExportXML";
            this.buttonExportXML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportXML.TabIndex = 5;
            this.buttonExportXML.Text = "XML";
            this.buttonExportXML.UseVisualStyleBackColor = true;
            this.buttonExportXML.Click += new System.EventHandler(this.buttonExportXML_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 284);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.Text = "AdminForm";
            this.tabControl.ResumeLayout(false);
            this.tabpageAdd.ResumeLayout(false);
            this.tabpageAdd.PerformLayout();
            this.tabpageDelete.ResumeLayout(false);
            this.tabpageDelete.PerformLayout();
            this.tabpageEdit.ResumeLayout(false);
            this.tabpageEdit.PerformLayout();
            this.tabpageImportExport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpageAdd;
        private System.Windows.Forms.TabPage tabpageDelete;
        private System.Windows.Forms.TabPage tabpageEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxAnswer_3;
        private System.Windows.Forms.TextBox textboxAnswer_2;
        private System.Windows.Forms.TextBox textboxAnswer_1;
        private System.Windows.Forms.TextBox textboxAnswer_Right;
        private System.Windows.Forms.TextBox textboxNewQuestion;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboboxDeleteQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEditAnswer3;
        private System.Windows.Forms.TextBox textBoxEditAnswer2;
        private System.Windows.Forms.TextBox textBoxEditAnswer1;
        private System.Windows.Forms.TextBox textBoxEditAnswerRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TabPage tabpageImportExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExportXML;
        private System.Windows.Forms.Button buttonExportTXT;
        private System.Windows.Forms.Button buttonExportBrowse;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImportGo;
        private System.Windows.Forms.Button buttonImportBrowse;
        private System.Windows.Forms.TextBox textBoxImport;
    }
}