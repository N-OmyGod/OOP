namespace WindowsFormsLaba5_6
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
            this.searchFilmButton = new System.Windows.Forms.Button();
            this.addFilmButton = new System.Windows.Forms.Button();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите класс для работы и соответствующую операцию";
            // 
            // searchFilmButton
            // 
            this.searchFilmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFilmButton.Location = new System.Drawing.Point(108, 216);
            this.searchFilmButton.Name = "searchFilmButton";
            this.searchFilmButton.Size = new System.Drawing.Size(225, 57);
            this.searchFilmButton.TabIndex = 5;
            this.searchFilmButton.Text = "Узнать заполненность  зала";
            this.searchFilmButton.UseVisualStyleBackColor = true;
            this.searchFilmButton.Click += new System.EventHandler(this.searchFilm_Click);
            // 
            // addFilmButton
            // 
            this.addFilmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFilmButton.Location = new System.Drawing.Point(101, 126);
            this.addFilmButton.Name = "addFilmButton";
            this.addFilmButton.Size = new System.Drawing.Size(232, 47);
            this.addFilmButton.TabIndex = 4;
            this.addFilmButton.Text = "Добавить фильм";
            this.addFilmButton.UseVisualStyleBackColor = true;
            this.addFilmButton.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStudentButton.Location = new System.Drawing.Point(595, 216);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(220, 57);
            this.searchStudentButton.TabIndex = 8;
            this.searchStudentButton.Text = " Информация о студенте";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.Location = new System.Drawing.Point(595, 126);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(220, 47);
            this.addStudentButton.TabIndex = 7;
            this.addStudentButton.Text = "Добавить студента ";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(180, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кинотеатр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(630, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Общежитие";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(406, 361);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 33);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(925, 428);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.searchFilmButton);
            this.Controls.Add(this.addFilmButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchFilmButton;
        private System.Windows.Forms.Button addFilmButton;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
    }
}

