namespace PostmailProject
{
    partial class ReceiverForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiverTabs = new System.Windows.Forms.TabControl();
            this.ReceiveDepartmentTab = new System.Windows.Forms.TabPage();
            this.SendParcelBox = new System.Windows.Forms.GroupBox();
            this.ReceiverBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PostOfficeNumberBox = new System.Windows.Forms.GroupBox();
            this.PostOfficeNumberTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicBox = new System.Windows.Forms.GroupBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.GroupBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CheckReceivingLabel = new System.Windows.Forms.Label();
            this.ReceiveDepartureButton = new System.Windows.Forms.Button();
            this.ReceiveDepartureBox = new System.Windows.Forms.GroupBox();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.ReceiverTabs.SuspendLayout();
            this.ReceiveDepartmentTab.SuspendLayout();
            this.SendParcelBox.SuspendLayout();
            this.ReceiverBox.SuspendLayout();
            this.PhoneNumberBox.SuspendLayout();
            this.PostOfficeNumberBox.SuspendLayout();
            this.PatronymicBox.SuspendLayout();
            this.SurnameBox.SuspendLayout();
            this.NameBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ReceiveDepartureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-3, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 75);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(942, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 457);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ReceiverTabs
            // 
            this.ReceiverTabs.Controls.Add(this.ReceiveDepartmentTab);
            this.ReceiverTabs.Controls.Add(this.tabPage2);
            this.ReceiverTabs.Location = new System.Drawing.Point(115, -2);
            this.ReceiverTabs.Name = "ReceiverTabs";
            this.ReceiverTabs.SelectedIndex = 0;
            this.ReceiverTabs.Size = new System.Drawing.Size(709, 483);
            this.ReceiverTabs.TabIndex = 9;
            // 
            // ReceiveDepartmentTab
            // 
            this.ReceiveDepartmentTab.Controls.Add(this.SendParcelBox);
            this.ReceiveDepartmentTab.Location = new System.Drawing.Point(4, 29);
            this.ReceiveDepartmentTab.Name = "ReceiveDepartmentTab";
            this.ReceiveDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiveDepartmentTab.Size = new System.Drawing.Size(701, 450);
            this.ReceiveDepartmentTab.TabIndex = 0;
            this.ReceiveDepartmentTab.Text = "Відправлення посилки";
            this.ReceiveDepartmentTab.UseVisualStyleBackColor = true;
            this.ReceiveDepartmentTab.Click += new System.EventHandler(this.ReceiveDepartmentTab_Click);
            // 
            // SendParcelBox
            // 
            this.SendParcelBox.Controls.Add(this.ReceiveDepartureBox);
            this.SendParcelBox.Controls.Add(this.ReceiverBox);
            this.SendParcelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SendParcelBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendParcelBox.ForeColor = System.Drawing.Color.Black;
            this.SendParcelBox.Location = new System.Drawing.Point(11, 18);
            this.SendParcelBox.Name = "SendParcelBox";
            this.SendParcelBox.Size = new System.Drawing.Size(655, 370);
            this.SendParcelBox.TabIndex = 9;
            this.SendParcelBox.TabStop = false;
            this.SendParcelBox.Text = "Отримання посилки";
            this.SendParcelBox.Enter += new System.EventHandler(this.SendParcelBox_Enter);
            // 
            // ReceiverBox
            // 
            this.ReceiverBox.BackColor = System.Drawing.Color.White;
            this.ReceiverBox.Controls.Add(this.PhoneNumberBox);
            this.ReceiverBox.Controls.Add(this.PostOfficeNumberBox);
            this.ReceiverBox.Controls.Add(this.PatronymicBox);
            this.ReceiverBox.Controls.Add(this.SurnameBox);
            this.ReceiverBox.Controls.Add(this.NameBox);
            this.ReceiverBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiverBox.Location = new System.Drawing.Point(6, 28);
            this.ReceiverBox.Name = "ReceiverBox";
            this.ReceiverBox.Size = new System.Drawing.Size(337, 342);
            this.ReceiverBox.TabIndex = 6;
            this.ReceiverBox.TabStop = false;
            this.ReceiverBox.Text = "Заповнення про отримувача";
            this.ReceiverBox.Enter += new System.EventHandler(this.ReceiverBox_Enter);
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumberBox.Controls.Add(this.PhoneNumberTextBox);
            this.PhoneNumberBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberBox.Location = new System.Drawing.Point(12, 280);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(269, 56);
            this.PhoneNumberBox.TabIndex = 6;
            this.PhoneNumberBox.TabStop = false;
            this.PhoneNumberBox.Text = "Введіть номер телефону";
            this.PhoneNumberBox.Enter += new System.EventHandler(this.PhoneNumberBox_Enter);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(6, 19);
            this.PhoneNumberTextBox.Mask = "000-000-0000";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(239, 31);
            this.PhoneNumberTextBox.TabIndex = 0;
            this.PhoneNumberTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PhoneNumberTextBox_MaskInputRejected);
            // 
            // PostOfficeNumberBox
            // 
            this.PostOfficeNumberBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PostOfficeNumberBox.Controls.Add(this.PostOfficeNumberTextBox);
            this.PostOfficeNumberBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostOfficeNumberBox.Location = new System.Drawing.Point(12, 218);
            this.PostOfficeNumberBox.Name = "PostOfficeNumberBox";
            this.PostOfficeNumberBox.Size = new System.Drawing.Size(269, 56);
            this.PostOfficeNumberBox.TabIndex = 6;
            this.PostOfficeNumberBox.TabStop = false;
            this.PostOfficeNumberBox.Text = "Введіть номер відділення";
            this.PostOfficeNumberBox.Enter += new System.EventHandler(this.PostOfficeNumberBox_Enter);
            // 
            // PostOfficeNumberTextBox
            // 
            this.PostOfficeNumberTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostOfficeNumberTextBox.Location = new System.Drawing.Point(6, 19);
            this.PostOfficeNumberTextBox.Name = "PostOfficeNumberTextBox";
            this.PostOfficeNumberTextBox.Size = new System.Drawing.Size(239, 31);
            this.PostOfficeNumberTextBox.TabIndex = 0;
            this.PostOfficeNumberTextBox.TextChanged += new System.EventHandler(this.PostOfficeNumberTextBox_TextChanged);
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PatronymicBox.Controls.Add(this.PatronymicTextBox);
            this.PatronymicBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatronymicBox.Location = new System.Drawing.Point(12, 156);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(269, 56);
            this.PatronymicBox.TabIndex = 6;
            this.PatronymicBox.TabStop = false;
            this.PatronymicBox.Text = "Введіть по-батькові";
            this.PatronymicBox.Enter += new System.EventHandler(this.PatronymicBox_Enter);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(6, 20);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(239, 31);
            this.PatronymicTextBox.TabIndex = 0;
            this.PatronymicTextBox.TextChanged += new System.EventHandler(this.PatronymicTextBox_TextChanged);
            // 
            // SurnameBox
            // 
            this.SurnameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SurnameBox.Controls.Add(this.SurnameTextBox);
            this.SurnameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameBox.Location = new System.Drawing.Point(12, 94);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(269, 56);
            this.SurnameBox.TabIndex = 6;
            this.SurnameBox.TabStop = false;
            this.SurnameBox.Text = "Введіть прізвище";
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.Location = new System.Drawing.Point(6, 20);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(239, 31);
            this.SurnameTextBox.TabIndex = 0;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameBox.Controls.Add(this.NameTextBox);
            this.NameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(12, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(269, 56);
            this.NameBox.TabIndex = 5;
            this.NameBox.TabStop = false;
            this.NameBox.Text = "Введіть ім\'я";
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(239, 31);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CheckReceivingLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Показ введених даних(натисніть в будь-яке місце)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CheckReceivingLabel
            // 
            this.CheckReceivingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckReceivingLabel.Location = new System.Drawing.Point(3, 3);
            this.CheckReceivingLabel.Name = "CheckReceivingLabel";
            this.CheckReceivingLabel.Size = new System.Drawing.Size(695, 444);
            this.CheckReceivingLabel.TabIndex = 0;
            this.CheckReceivingLabel.Click += new System.EventHandler(this.CheckReceivingLabel_Click);
            // 
            // ReceiveDepartureButton
            // 
            this.ReceiveDepartureButton.Location = new System.Drawing.Point(3, 29);
            this.ReceiveDepartureButton.Name = "ReceiveDepartureButton";
            this.ReceiveDepartureButton.Size = new System.Drawing.Size(278, 33);
            this.ReceiveDepartureButton.TabIndex = 0;
            this.ReceiveDepartureButton.Text = "Отримати всі посилки";
            this.ReceiveDepartureButton.UseVisualStyleBackColor = true;
            this.ReceiveDepartureButton.Click += new System.EventHandler(this.ReceiveDepartureButton_Click);
            // 
            // ReceiveDepartureBox
            // 
            this.ReceiveDepartureBox.BackColor = System.Drawing.Color.White;
            this.ReceiveDepartureBox.Controls.Add(this.ReceiveDepartureButton);
            this.ReceiveDepartureBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiveDepartureBox.Location = new System.Drawing.Point(358, 47);
            this.ReceiveDepartureBox.Name = "ReceiveDepartureBox";
            this.ReceiveDepartureBox.Size = new System.Drawing.Size(291, 69);
            this.ReceiveDepartureBox.TabIndex = 8;
            this.ReceiveDepartureBox.TabStop = false;
            this.ReceiveDepartureBox.Text = "Отримати відправлення";
            this.ReceiveDepartureBox.Enter += new System.EventHandler(this.ReceiveDepartureBox_Enter);
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadFileButton.ForeColor = System.Drawing.Color.Lime;
            this.ReadFileButton.Location = new System.Drawing.Point(-7, 381);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(122, 75);
            this.ReadFileButton.TabIndex = 10;
            this.ReadFileButton.Text = "Зчитати дані з файлу";
            this.ReadFileButton.UseVisualStyleBackColor = false;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.ReceiverTabs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceiverForm";
            this.Text = "ReceiverFrom";
            this.ReceiverTabs.ResumeLayout(false);
            this.ReceiveDepartmentTab.ResumeLayout(false);
            this.SendParcelBox.ResumeLayout(false);
            this.ReceiverBox.ResumeLayout(false);
            this.PhoneNumberBox.ResumeLayout(false);
            this.PhoneNumberBox.PerformLayout();
            this.PostOfficeNumberBox.ResumeLayout(false);
            this.PostOfficeNumberBox.PerformLayout();
            this.PatronymicBox.ResumeLayout(false);
            this.PatronymicBox.PerformLayout();
            this.SurnameBox.ResumeLayout(false);
            this.SurnameBox.PerformLayout();
            this.NameBox.ResumeLayout(false);
            this.NameBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ReceiveDepartureBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl ReceiverTabs;
        private System.Windows.Forms.TabPage ReceiveDepartmentTab;
        private System.Windows.Forms.GroupBox SendParcelBox;
        private System.Windows.Forms.GroupBox ReceiverBox;
        private System.Windows.Forms.GroupBox PhoneNumberBox;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
        private System.Windows.Forms.GroupBox PostOfficeNumberBox;
        private System.Windows.Forms.TextBox PostOfficeNumberTextBox;
        private System.Windows.Forms.GroupBox PatronymicBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.GroupBox SurnameBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.GroupBox NameBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label CheckReceivingLabel;
        private System.Windows.Forms.GroupBox ReceiveDepartureBox;
        private System.Windows.Forms.Button ReceiveDepartureButton;
        private System.Windows.Forms.Button ReadFileButton;
    }
}