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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxNewAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxNewAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxNewAnswerRight = new System.Windows.Forms.TextBox();
            this.textboxNewQuestion = new System.Windows.Forms.TextBox();
            this.tabpageDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboboxDeleteQuestion = new System.Windows.Forms.ComboBox();
            this.tabpageEdit = new System.Windows.Forms.TabPage();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEditAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswerRight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.tabpageImportExport = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExportXML = new System.Windows.Forms.Button();
            this.buttonExportTXT = new System.Windows.Forms.Button();
            this.textBoxExport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImportGo = new System.Windows.Forms.Button();
            this.buttonImportBrowse = new System.Windows.Forms.Button();
            this.textBoxImport = new System.Windows.Forms.TextBox();
            this.tabpageDatabase = new System.Windows.Forms.TabPage();
            this.radioButtonDbDetached = new System.Windows.Forms.RadioButton();
            this.radioButtonDbAttached = new System.Windows.Forms.RadioButton();
            this.radioButtonDbOff = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabpageAdd.SuspendLayout();
            this.tabpageDelete.SuspendLayout();
            this.tabpageEdit.SuspendLayout();
            this.tabpageImportExport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpageDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageAdd);
            this.tabControl.Controls.Add(this.tabpageDelete);
            this.tabControl.Controls.Add(this.tabpageEdit);
            this.tabControl.Controls.Add(this.tabpageImportExport);
            this.tabControl.Controls.Add(this.tabpageDatabase);
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
            this.tabpageAdd.Controls.Add(this.textBoxNewAnswer3);
            this.tabpageAdd.Controls.Add(this.textBoxNewAnswer2);
            this.tabpageAdd.Controls.Add(this.textBoxNewAnswer1);
            this.tabpageAdd.Controls.Add(this.textBoxNewAnswerRight);
            this.tabpageAdd.Controls.Add(this.textboxNewQuestion);
            this.tabpageAdd.Location = new System.Drawing.Point(4, 40);
            this.tabpageAdd.Name = "tabpageAdd";
            this.tabpageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAdd.Size = new System.Drawing.Size(373, 216);
            this.tabpageAdd.TabIndex = 0;
            this.tabpageAdd.Text = "Добавление вопроса";
            this.tabpageAdd.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите остальные варианты ответов";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите новый вопрос";
            // 
            // textBoxNewAnswer3
            // 
            this.textBoxNewAnswer3.Location = new System.Drawing.Point(9, 149);
            this.textBoxNewAnswer3.Name = "textBoxNewAnswer3";
            this.textBoxNewAnswer3.Size = new System.Drawing.Size(355, 20);
            this.textBoxNewAnswer3.TabIndex = 4;
            // 
            // textBoxNewAnswer2
            // 
            this.textBoxNewAnswer2.Location = new System.Drawing.Point(9, 123);
            this.textBoxNewAnswer2.Name = "textBoxNewAnswer2";
            this.textBoxNewAnswer2.Size = new System.Drawing.Size(355, 20);
            this.textBoxNewAnswer2.TabIndex = 3;
            // 
            // textBoxNewAnswer1
            // 
            this.textBoxNewAnswer1.Location = new System.Drawing.Point(9, 97);
            this.textBoxNewAnswer1.Name = "textBoxNewAnswer1";
            this.textBoxNewAnswer1.Size = new System.Drawing.Size(355, 20);
            this.textBoxNewAnswer1.TabIndex = 2;
            // 
            // textBoxNewAnswerRight
            // 
            this.textBoxNewAnswerRight.Location = new System.Drawing.Point(9, 58);
            this.textBoxNewAnswerRight.Name = "textBoxNewAnswerRight";
            this.textBoxNewAnswerRight.Size = new System.Drawing.Size(355, 20);
            this.textBoxNewAnswerRight.TabIndex = 1;
            // 
            // textboxNewQuestion
            // 
            this.textboxNewQuestion.Location = new System.Drawing.Point(9, 19);
            this.textboxNewQuestion.Name = "textboxNewQuestion";
            this.textboxNewQuestion.Size = new System.Drawing.Size(355, 20);
            this.textboxNewQuestion.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выберите вопрос";
            // 
            // comboboxDeleteQuestion
            // 
            this.comboboxDeleteQuestion.FormattingEnabled = true;
            this.comboboxDeleteQuestion.Location = new System.Drawing.Point(9, 19);
            this.comboboxDeleteQuestion.Name = "comboboxDeleteQuestion";
            this.comboboxDeleteQuestion.Size = new System.Drawing.Size(358, 21);
            this.comboboxDeleteQuestion.TabIndex = 0;
            this.comboboxDeleteQuestion.DropDown += new System.EventHandler(this.comboboxDeleteQuestion_DropDown);
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
            this.comboBoxEdit.DropDown += new System.EventHandler(this.comboBoxEdit_DropDown);
            this.comboBoxEdit.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEdit_SelectionChangeCommitted);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonExportXML);
            this.groupBox2.Controls.Add(this.buttonExportTXT);
            this.groupBox2.Controls.Add(this.textBoxExport);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Экспорт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Имя файла:";
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
            // textBoxExport
            // 
            this.textBoxExport.Location = new System.Drawing.Point(87, 19);
            this.textBoxExport.Name = "textBoxExport";
            this.textBoxExport.Size = new System.Drawing.Size(265, 20);
            this.textBoxExport.TabIndex = 1;
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
            // textBoxImport
            // 
            this.textBoxImport.Location = new System.Drawing.Point(6, 19);
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(265, 20);
            this.textBoxImport.TabIndex = 1;
            // 
            // tabpageDatabase
            // 
            this.tabpageDatabase.Controls.Add(this.radioButtonDbDetached);
            this.tabpageDatabase.Controls.Add(this.radioButtonDbAttached);
            this.tabpageDatabase.Controls.Add(this.radioButtonDbOff);
            this.tabpageDatabase.Location = new System.Drawing.Point(4, 40);
            this.tabpageDatabase.Name = "tabpageDatabase";
            this.tabpageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDatabase.Size = new System.Drawing.Size(373, 216);
            this.tabpageDatabase.TabIndex = 4;
            this.tabpageDatabase.Text = "Работа с БД";
            this.tabpageDatabase.UseVisualStyleBackColor = true;
            // 
            // radioButtonDbDetached
            // 
            this.radioButtonDbDetached.AutoSize = true;
            this.radioButtonDbDetached.Location = new System.Drawing.Point(18, 63);
            this.radioButtonDbDetached.Name = "radioButtonDbDetached";
            this.radioButtonDbDetached.Size = new System.Drawing.Size(143, 17);
            this.radioButtonDbDetached.TabIndex = 2;
            this.radioButtonDbDetached.TabStop = true;
            this.radioButtonDbDetached.Text = "Отсоединенный режим";
            this.radioButtonDbDetached.UseVisualStyleBackColor = true;
            this.radioButtonDbDetached.CheckedChanged += new System.EventHandler(this.radioButtonDbDetached_CheckedChanged);
            // 
            // radioButtonDbAttached
            // 
            this.radioButtonDbAttached.AutoSize = true;
            this.radioButtonDbAttached.Location = new System.Drawing.Point(18, 40);
            this.radioButtonDbAttached.Name = "radioButtonDbAttached";
            this.radioButtonDbAttached.Size = new System.Drawing.Size(150, 17);
            this.radioButtonDbAttached.TabIndex = 1;
            this.radioButtonDbAttached.TabStop = true;
            this.radioButtonDbAttached.Text = "Присоединенный режим";
            this.radioButtonDbAttached.UseVisualStyleBackColor = true;
            this.radioButtonDbAttached.CheckedChanged += new System.EventHandler(this.radioButtonDbAttached_CheckedChanged);
            // 
            // radioButtonDbOff
            // 
            this.radioButtonDbOff.AutoSize = true;
            this.radioButtonDbOff.Checked = true;
            this.radioButtonDbOff.Location = new System.Drawing.Point(18, 17);
            this.radioButtonDbOff.Name = "radioButtonDbOff";
            this.radioButtonDbOff.Size = new System.Drawing.Size(98, 17);
            this.radioButtonDbOff.TabIndex = 0;
            this.radioButtonDbOff.TabStop = true;
            this.radioButtonDbOff.Text = "БД отключена";
            this.radioButtonDbOff.UseVisualStyleBackColor = true;
            this.radioButtonDbOff.CheckedChanged += new System.EventHandler(this.radioButtonDbOff_CheckedChanged);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabpageAdd.ResumeLayout(false);
            this.tabpageAdd.PerformLayout();
            this.tabpageDelete.ResumeLayout(false);
            this.tabpageDelete.PerformLayout();
            this.tabpageEdit.ResumeLayout(false);
            this.tabpageEdit.PerformLayout();
            this.tabpageImportExport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpageDatabase.ResumeLayout(false);
            this.tabpageDatabase.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxNewAnswer3;
        private System.Windows.Forms.TextBox textBoxNewAnswer2;
        private System.Windows.Forms.TextBox textBoxNewAnswer1;
        private System.Windows.Forms.TextBox textBoxNewAnswerRight;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImportGo;
        private System.Windows.Forms.Button buttonImportBrowse;
        private System.Windows.Forms.TextBox textBoxImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxExport;
        private System.Windows.Forms.TabPage tabpageDatabase;
        private System.Windows.Forms.RadioButton radioButtonDbOff;
        private System.Windows.Forms.RadioButton radioButtonDbAttached;
        private System.Windows.Forms.RadioButton radioButtonDbDetached;
    }
}