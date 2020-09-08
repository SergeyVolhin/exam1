namespace Стоимость_телефонного_разговора
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(146, 198);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(127, 54);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Ввести";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(115, 105);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(186, 22);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(115, 77);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(186, 22);
            this.textBoxX.TabIndex = 2;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(13, 77);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(96, 17);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Кол-во минут";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(16, 109);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(94, 17);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "День недели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Стоимость разговора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblDay;
    }
}

