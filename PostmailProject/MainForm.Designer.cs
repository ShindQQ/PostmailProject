namespace PostmailProject
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendParcelButton = new System.Windows.Forms.Button();
            this.ReceiveParcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 457);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(942, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // SendParcelButton
            // 
            this.SendParcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendParcelButton.FlatAppearance.BorderSize = 0;
            this.SendParcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendParcelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SendParcelButton.Location = new System.Drawing.Point(-4, 133);
            this.SendParcelButton.Name = "SendParcelButton";
            this.SendParcelButton.Size = new System.Drawing.Size(122, 73);
            this.SendParcelButton.TabIndex = 3;
            this.SendParcelButton.Text = "Створити відправлення";
            this.SendParcelButton.UseVisualStyleBackColor = false;
            this.SendParcelButton.Click += new System.EventHandler(this.SendParcelButton_Click);
            // 
            // ReceiveParcelButton
            // 
            this.ReceiveParcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReceiveParcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReceiveParcelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReceiveParcelButton.Location = new System.Drawing.Point(-4, 212);
            this.ReceiveParcelButton.Name = "ReceiveParcelButton";
            this.ReceiveParcelButton.Size = new System.Drawing.Size(122, 73);
            this.ReceiveParcelButton.TabIndex = 4;
            this.ReceiveParcelButton.Text = "Отримати відправлення";
            this.ReceiveParcelButton.UseVisualStyleBackColor = false;
            this.ReceiveParcelButton.Click += new System.EventHandler(this.ReceiveParcelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::PostmailProject.Properties.Resources.Пошта2__3_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiveParcelButton);
            this.Controls.Add(this.SendParcelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendParcelButton;
        private System.Windows.Forms.Button ReceiveParcelButton;
    }
}