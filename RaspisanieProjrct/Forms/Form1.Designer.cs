
namespace RaspisanieProjrct
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbPair = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.bAddSubject = new System.Windows.Forms.Button();
            this.cbTypePair = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bEditSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод строки расписания";
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGroup.Location = new System.Drawing.Point(25, 66);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(121, 21);
            this.cbGroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Преподаватель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "День недели";
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDay.Location = new System.Drawing.Point(25, 124);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 21);
            this.cbDay.TabIndex = 3;
            // 
            // cbPair
            // 
            this.cbPair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPair.FormattingEnabled = true;
            this.cbPair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPair.Location = new System.Drawing.Point(25, 181);
            this.cbPair.Name = "cbPair";
            this.cbPair.Size = new System.Drawing.Size(121, 21);
            this.cbPair.TabIndex = 4;
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSubject.Location = new System.Drawing.Point(25, 240);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(292, 21);
            this.cbSubject.TabIndex = 6;
            // 
            // cbProfessor
            // 
            this.cbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProfessor.Location = new System.Drawing.Point(25, 296);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(292, 21);
            this.cbProfessor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Номер недели";
            // 
            // cbWeek
            // 
            this.cbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbWeek.Location = new System.Drawing.Point(285, 35);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(121, 21);
            this.cbWeek.TabIndex = 1;
            // 
            // bAddSubject
            // 
            this.bAddSubject.Location = new System.Drawing.Point(316, 336);
            this.bAddSubject.Name = "bAddSubject";
            this.bAddSubject.Size = new System.Drawing.Size(150, 29);
            this.bAddSubject.TabIndex = 12;
            this.bAddSubject.Text = "Добавть занятие";
            this.bAddSubject.UseVisualStyleBackColor = true;
            this.bAddSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTypePair
            // 
            this.cbTypePair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypePair.FormattingEnabled = true;
            this.cbTypePair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTypePair.Location = new System.Drawing.Point(196, 181);
            this.cbTypePair.Name = "cbTypePair";
            this.cbTypePair.Size = new System.Drawing.Size(121, 21);
            this.cbTypePair.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Тип занятия";
            // 
            // bEditSubject
            // 
            this.bEditSubject.Location = new System.Drawing.Point(316, 336);
            this.bEditSubject.Name = "bEditSubject";
            this.bEditSubject.Size = new System.Drawing.Size(150, 29);
            this.bEditSubject.TabIndex = 15;
            this.bEditSubject.Text = "Изменить занятие";
            this.bEditSubject.UseVisualStyleBackColor = true;
            this.bEditSubject.Click += new System.EventHandler(this.bEditSubject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 377);
            this.Controls.Add(this.bEditSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTypePair);
            this.Controls.Add(this.bAddSubject);
            this.Controls.Add(this.cbWeek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProfessor);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbPair);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Добавление занянтия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbPair;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWeek;
        private System.Windows.Forms.Button bAddSubject;
        private System.Windows.Forms.ComboBox cbTypePair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bEditSubject;
    }
}

