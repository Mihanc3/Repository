namespace Проект_Шифрование
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
            this.lbUser1 = new System.Windows.Forms.Label();
            this.lbUser2 = new System.Windows.Forms.Label();
            this.textUser1 = new System.Windows.Forms.TextBox();
            this.textUser2 = new System.Windows.Forms.TextBox();
            this.bSendUser1 = new System.Windows.Forms.Button();
            this.bSendUser2 = new System.Windows.Forms.Button();
            this.textMessages = new System.Windows.Forms.TextBox();
            this.lbMessagesU2 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUser1
            // 
            this.lbUser1.AutoSize = true;
            this.lbUser1.Location = new System.Drawing.Point(12, 18);
            this.lbUser1.Name = "lbUser1";
            this.lbUser1.Size = new System.Drawing.Size(86, 13);
            this.lbUser1.TabIndex = 0;
            this.lbUser1.Text = "Пользователь1";
            // 
            // lbUser2
            // 
            this.lbUser2.AutoSize = true;
            this.lbUser2.Location = new System.Drawing.Point(320, 18);
            this.lbUser2.Name = "lbUser2";
            this.lbUser2.Size = new System.Drawing.Size(86, 13);
            this.lbUser2.TabIndex = 1;
            this.lbUser2.Text = "Пользователь2";
            // 
            // textUser1
            // 
            this.textUser1.Location = new System.Drawing.Point(15, 35);
            this.textUser1.Multiline = true;
            this.textUser1.Name = "textUser1";
            this.textUser1.Size = new System.Drawing.Size(264, 83);
            this.textUser1.TabIndex = 2;
            // 
            // textUser2
            // 
            this.textUser2.Location = new System.Drawing.Point(323, 35);
            this.textUser2.Multiline = true;
            this.textUser2.Name = "textUser2";
            this.textUser2.Size = new System.Drawing.Size(264, 83);
            this.textUser2.TabIndex = 3;
            // 
            // bSendUser1
            // 
            this.bSendUser1.Location = new System.Drawing.Point(12, 124);
            this.bSendUser1.Name = "bSendUser1";
            this.bSendUser1.Size = new System.Drawing.Size(75, 23);
            this.bSendUser1.TabIndex = 4;
            this.bSendUser1.Text = "Отправить";
            this.bSendUser1.UseVisualStyleBackColor = true;
            this.bSendUser1.Click += new System.EventHandler(this.bSendUser1_Click);
            // 
            // bSendUser2
            // 
            this.bSendUser2.Location = new System.Drawing.Point(512, 124);
            this.bSendUser2.Name = "bSendUser2";
            this.bSendUser2.Size = new System.Drawing.Size(75, 23);
            this.bSendUser2.TabIndex = 7;
            this.bSendUser2.Text = "Отправить";
            this.bSendUser2.UseVisualStyleBackColor = true;
            this.bSendUser2.Click += new System.EventHandler(this.bSendUser2_Click);
            // 
            // textMessages
            // 
            this.textMessages.Location = new System.Drawing.Point(15, 184);
            this.textMessages.Multiline = true;
            this.textMessages.Name = "textMessages";
            this.textMessages.ReadOnly = true;
            this.textMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessages.Size = new System.Drawing.Size(572, 223);
            this.textMessages.TabIndex = 8;
            // 
            // lbMessagesU2
            // 
            this.lbMessagesU2.AutoSize = true;
            this.lbMessagesU2.Location = new System.Drawing.Point(12, 168);
            this.lbMessagesU2.Name = "lbMessagesU2";
            this.lbMessagesU2.Size = new System.Drawing.Size(29, 13);
            this.lbMessagesU2.TabIndex = 9;
            this.lbMessagesU2.Text = "Чат ";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(263, 155);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 10;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 419);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lbMessagesU2);
            this.Controls.Add(this.textMessages);
            this.Controls.Add(this.bSendUser2);
            this.Controls.Add(this.bSendUser1);
            this.Controls.Add(this.textUser2);
            this.Controls.Add(this.textUser1);
            this.Controls.Add(this.lbUser2);
            this.Controls.Add(this.lbUser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser1;
        private System.Windows.Forms.Label lbUser2;
        private System.Windows.Forms.TextBox textUser1;
        private System.Windows.Forms.TextBox textUser2;
        private System.Windows.Forms.Button bSendUser1;
        private System.Windows.Forms.Button bSendUser2;
        private System.Windows.Forms.TextBox textMessages;
        private System.Windows.Forms.Label lbMessagesU2;
        private System.Windows.Forms.Button bClear;
    }
}

