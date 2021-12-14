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
            this.searchFilm = new System.Windows.Forms.Button();
            this.addFilm = new System.Windows.Forms.Button();
            this.searchStudent = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // searchFilm
            // 
            this.searchFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFilm.Location = new System.Drawing.Point(108, 216);
            this.searchFilm.Name = "searchFilm";
            this.searchFilm.Size = new System.Drawing.Size(225, 57);
            this.searchFilm.TabIndex = 5;
            this.searchFilm.Text = "Узнать заполненность  зала";
            this.searchFilm.UseVisualStyleBackColor = true;
            this.searchFilm.Click += new System.EventHandler(this.searchFilm_Click);
            // 
            // addFilm
            // 
            this.addFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFilm.Location = new System.Drawing.Point(101, 126);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(232, 47);
            this.addFilm.TabIndex = 4;
            this.addFilm.Text = "Добавить фильм";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // searchStudent
            // 
            this.searchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStudent.Location = new System.Drawing.Point(595, 216);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(220, 57);
            this.searchStudent.TabIndex = 8;
            this.searchStudent.Text = " Информация о студенте";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // addStudent
            // 
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.Location = new System.Drawing.Point(595, 126);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(220, 47);
            this.addStudent.TabIndex = 7;
            this.addStudent.Text = "Добавить студента ";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(925, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.searchFilm);
            this.Controls.Add(this.addFilm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchFilm;
        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

