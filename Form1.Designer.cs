namespace SRS
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
            this.richTextBoxMas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.massiv = new System.Windows.Forms.GroupBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.buttonNM = new System.Windows.Forms.Button();
            this.massiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxMas
            // 
            this.richTextBoxMas.Location = new System.Drawing.Point(9, 30);
            this.richTextBoxMas.Name = "richTextBoxMas";
            this.richTextBoxMas.Size = new System.Drawing.Size(241, 100);
            this.richTextBoxMas.TabIndex = 0;
            this.richTextBoxMas.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнение массива";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(174, 290);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(9, 352);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(241, 40);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Сгенерировать массив";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // massiv
            // 
            this.massiv.Controls.Add(this.richTextBoxInput);
            this.massiv.Controls.Add(this.buttonGenerate);
            this.massiv.Controls.Add(this.buttonOK);
            this.massiv.Controls.Add(this.label2);
            this.massiv.Controls.Add(this.richTextBoxMas);
            this.massiv.Location = new System.Drawing.Point(12, 12);
            this.massiv.Name = "massiv";
            this.massiv.Size = new System.Drawing.Size(275, 409);
            this.massiv.TabIndex = 6;
            this.massiv.TabStop = false;
            this.massiv.Text = "Массив";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 163);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(238, 121);
            this.richTextBoxInput.TabIndex = 6;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHelp.Location = new System.Drawing.Point(293, 42);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(156, 100);
            this.richTextBoxHelp.TabIndex = 3;
            this.richTextBoxHelp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбор задания";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(488, 415);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 9;
            this.buttonSolve.Text = "Решить";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(488, 28);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(75, 23);
            this.buttonTask1.TabIndex = 10;
            this.buttonTask1.Text = "Задание 1";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // buttonTask2
            // 
            this.buttonTask2.Location = new System.Drawing.Point(488, 57);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(75, 23);
            this.buttonTask2.TabIndex = 11;
            this.buttonTask2.Text = "Задание 2";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // buttonTask3
            // 
            this.buttonTask3.Location = new System.Drawing.Point(488, 86);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(75, 23);
            this.buttonTask3.TabIndex = 12;
            this.buttonTask3.Text = "Задание 3";
            this.buttonTask3.UseVisualStyleBackColor = true;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер столбца";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(488, 175);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(74, 20);
            this.textBoxK.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Размер массива";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "M";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(518, 233);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(44, 20);
            this.textBoxN.TabIndex = 18;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(518, 256);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(43, 20);
            this.textBoxM.TabIndex = 19;
            // 
            // buttonNM
            // 
            this.buttonNM.Location = new System.Drawing.Point(518, 282);
            this.buttonNM.Name = "buttonNM";
            this.buttonNM.Size = new System.Drawing.Size(45, 23);
            this.buttonNM.TabIndex = 20;
            this.buttonNM.Text = "OK";
            this.buttonNM.UseVisualStyleBackColor = true;
            this.buttonNM.Click += new System.EventHandler(this.buttonNM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.buttonNM);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTask3);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.buttonTask1);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxHelp);
            this.Controls.Add(this.massiv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.massiv.ResumeLayout(false);
            this.massiv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.GroupBox massiv;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.Button buttonTask3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button buttonNM;
    }
}

