namespace PostmailProject
{
    partial class SenderForm
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
            this.SenderTabs = new System.Windows.Forms.TabControl();
            this.CreateDepartmentTab = new System.Windows.Forms.TabPage();
            this.SendParcelBox = new System.Windows.Forms.GroupBox();
            this.CreateDepartureBox = new System.Windows.Forms.GroupBox();
            this.AddParcelToDepartureButton = new System.Windows.Forms.Button();
            this.SendDepartureButton = new System.Windows.Forms.Button();
            this.ParcelBox = new System.Windows.Forms.GroupBox();
            this.ParcelWeightBox = new System.Windows.Forms.GroupBox();
            this.ParcelWeightTextBox = new System.Windows.Forms.TextBox();
            this.ParcelCapacityBox = new System.Windows.Forms.GroupBox();
            this.ParcelCapacityTextBox = new System.Windows.Forms.TextBox();
            this.ParcelNameBox = new System.Windows.Forms.GroupBox();
            this.ParcelNameTextBox = new System.Windows.Forms.TextBox();
            this.SenderBox = new System.Windows.Forms.GroupBox();
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
            this.ShowDepartmentLabel = new System.Windows.Forms.Label();
            this.WriteFileButton = new System.Windows.Forms.Button();
            this.SenderTabs.SuspendLayout();
            this.CreateDepartmentTab.SuspendLayout();
            this.SendParcelBox.SuspendLayout();
            this.CreateDepartureBox.SuspendLayout();
            this.ParcelBox.SuspendLayout();
            this.ParcelWeightBox.SuspendLayout();
            this.ParcelCapacityBox.SuspendLayout();
            this.ParcelNameBox.SuspendLayout();
            this.SenderBox.SuspendLayout();
            this.PhoneNumberBox.SuspendLayout();
            this.PostOfficeNumberBox.SuspendLayout();
            this.PatronymicBox.SuspendLayout();
            this.SurnameBox.SuspendLayout();
            this.NameBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 75);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(942, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 457);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // SenderTabs
            // 
            this.SenderTabs.Controls.Add(this.CreateDepartmentTab);
            this.SenderTabs.Controls.Add(this.tabPage2);
            this.SenderTabs.Location = new System.Drawing.Point(115, -2);
            this.SenderTabs.Name = "SenderTabs";
            this.SenderTabs.SelectedIndex = 0;
            this.SenderTabs.Size = new System.Drawing.Size(709, 483);
            this.SenderTabs.TabIndex = 8;
            // 
            // CreateDepartmentTab
            // 
            this.CreateDepartmentTab.Controls.Add(this.SendParcelBox);
            this.CreateDepartmentTab.Location = new System.Drawing.Point(4, 29);
            this.CreateDepartmentTab.Name = "CreateDepartmentTab";
            this.CreateDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateDepartmentTab.Size = new System.Drawing.Size(701, 450);
            this.CreateDepartmentTab.TabIndex = 0;
            this.CreateDepartmentTab.Text = "Відправлення посилки";
            this.CreateDepartmentTab.UseVisualStyleBackColor = true;
            this.CreateDepartmentTab.Click += new System.EventHandler(this.CreateDepartmentTab_Click);
            // 
            // SendParcelBox
            // 
            this.SendParcelBox.Controls.Add(this.CreateDepartureBox);
            this.SendParcelBox.Controls.Add(this.ParcelBox);
            this.SendParcelBox.Controls.Add(this.SenderBox);
            this.SendParcelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SendParcelBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendParcelBox.ForeColor = System.Drawing.Color.Black;
            this.SendParcelBox.Location = new System.Drawing.Point(11, 18);
            this.SendParcelBox.Name = "SendParcelBox";
            this.SendParcelBox.Size = new System.Drawing.Size(655, 370);
            this.SendParcelBox.TabIndex = 9;
            this.SendParcelBox.TabStop = false;
            this.SendParcelBox.Text = "Відправлення посилки";
            this.SendParcelBox.Enter += new System.EventHandler(this.SendParcelBox_Enter);
            // 
            // CreateDepartureBox
            // 
            this.CreateDepartureBox.BackColor = System.Drawing.Color.White;
            this.CreateDepartureBox.Controls.Add(this.AddParcelToDepartureButton);
            this.CreateDepartureBox.Controls.Add(this.SendDepartureButton);
            this.CreateDepartureBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDepartureBox.Location = new System.Drawing.Point(358, 260);
            this.CreateDepartureBox.Name = "CreateDepartureBox";
            this.CreateDepartureBox.Size = new System.Drawing.Size(291, 110);
            this.CreateDepartureBox.TabIndex = 8;
            this.CreateDepartureBox.TabStop = false;
            this.CreateDepartureBox.Text = "Створити відправлення";
            this.CreateDepartureBox.Enter += new System.EventHandler(this.CreateDepartureBox_Enter);
            // 
            // AddParcelToDepartureButton
            // 
            this.AddParcelToDepartureButton.Location = new System.Drawing.Point(3, 65);
            this.AddParcelToDepartureButton.Name = "AddParcelToDepartureButton";
            this.AddParcelToDepartureButton.Size = new System.Drawing.Size(278, 33);
            this.AddParcelToDepartureButton.TabIndex = 1;
            this.AddParcelToDepartureButton.Text = "Додати відправлення";
            this.AddParcelToDepartureButton.UseVisualStyleBackColor = true;
            this.AddParcelToDepartureButton.Click += new System.EventHandler(this.AddParcelToDepartureButton_Click);
            // 
            // SendDepartureButton
            // 
            this.SendDepartureButton.Location = new System.Drawing.Point(3, 29);
            this.SendDepartureButton.Name = "SendDepartureButton";
            this.SendDepartureButton.Size = new System.Drawing.Size(278, 33);
            this.SendDepartureButton.TabIndex = 0;
            this.SendDepartureButton.Text = "Відправити посилку";
            this.SendDepartureButton.UseVisualStyleBackColor = true;
            this.SendDepartureButton.Click += new System.EventHandler(this.SendDepartureButton_Click);
            // 
            // ParcelBox
            // 
            this.ParcelBox.BackColor = System.Drawing.Color.White;
            this.ParcelBox.Controls.Add(this.ParcelWeightBox);
            this.ParcelBox.Controls.Add(this.ParcelCapacityBox);
            this.ParcelBox.Controls.Add(this.ParcelNameBox);
            this.ParcelBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParcelBox.Location = new System.Drawing.Point(358, 28);
            this.ParcelBox.Name = "ParcelBox";
            this.ParcelBox.Size = new System.Drawing.Size(291, 224);
            this.ParcelBox.TabIndex = 7;
            this.ParcelBox.TabStop = false;
            this.ParcelBox.Text = "Створення відправлення";
            this.ParcelBox.Enter += new System.EventHandler(this.ParcelBox_Enter);
            // 
            // ParcelWeightBox
            // 
            this.ParcelWeightBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ParcelWeightBox.Controls.Add(this.ParcelWeightTextBox);
            this.ParcelWeightBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelWeightBox.Location = new System.Drawing.Point(12, 156);
            this.ParcelWeightBox.Name = "ParcelWeightBox";
            this.ParcelWeightBox.Size = new System.Drawing.Size(269, 56);
            this.ParcelWeightBox.TabIndex = 6;
            this.ParcelWeightBox.TabStop = false;
            this.ParcelWeightBox.Text = "Введіть масу";
            this.ParcelWeightBox.Enter += new System.EventHandler(this.ParcelWeightBox_Enter);
            // 
            // ParcelWeightTextBox
            // 
            this.ParcelWeightTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelWeightTextBox.Location = new System.Drawing.Point(6, 20);
            this.ParcelWeightTextBox.Name = "ParcelWeightTextBox";
            this.ParcelWeightTextBox.Size = new System.Drawing.Size(239, 31);
            this.ParcelWeightTextBox.TabIndex = 0;
            this.ParcelWeightTextBox.TextChanged += new System.EventHandler(this.ParcelWeightTextBox_TextChanged);
            // 
            // ParcelCapacityBox
            // 
            this.ParcelCapacityBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ParcelCapacityBox.Controls.Add(this.ParcelCapacityTextBox);
            this.ParcelCapacityBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelCapacityBox.Location = new System.Drawing.Point(12, 94);
            this.ParcelCapacityBox.Name = "ParcelCapacityBox";
            this.ParcelCapacityBox.Size = new System.Drawing.Size(269, 56);
            this.ParcelCapacityBox.TabIndex = 6;
            this.ParcelCapacityBox.TabStop = false;
            this.ParcelCapacityBox.Text = "Введіть об\'єм";
            this.ParcelCapacityBox.Enter += new System.EventHandler(this.ParcelCapacityBox_Enter);
            // 
            // ParcelCapacityTextBox
            // 
            this.ParcelCapacityTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelCapacityTextBox.Location = new System.Drawing.Point(6, 20);
            this.ParcelCapacityTextBox.Name = "ParcelCapacityTextBox";
            this.ParcelCapacityTextBox.Size = new System.Drawing.Size(239, 31);
            this.ParcelCapacityTextBox.TabIndex = 0;
            this.ParcelCapacityTextBox.TextChanged += new System.EventHandler(this.ParcelCapacityTextBox_TextChanged);
            // 
            // ParcelNameBox
            // 
            this.ParcelNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ParcelNameBox.Controls.Add(this.ParcelNameTextBox);
            this.ParcelNameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelNameBox.Location = new System.Drawing.Point(12, 32);
            this.ParcelNameBox.Name = "ParcelNameBox";
            this.ParcelNameBox.Size = new System.Drawing.Size(269, 56);
            this.ParcelNameBox.TabIndex = 5;
            this.ParcelNameBox.TabStop = false;
            this.ParcelNameBox.Text = "Введіть назву";
            this.ParcelNameBox.Enter += new System.EventHandler(this.ParcelNameBox_Enter);
            // 
            // ParcelNameTextBox
            // 
            this.ParcelNameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelNameTextBox.Location = new System.Drawing.Point(6, 20);
            this.ParcelNameTextBox.Name = "ParcelNameTextBox";
            this.ParcelNameTextBox.Size = new System.Drawing.Size(239, 31);
            this.ParcelNameTextBox.TabIndex = 0;
            this.ParcelNameTextBox.TextChanged += new System.EventHandler(this.ParcelNameTextBox_TextChanged);
            // 
            // SenderBox
            // 
            this.SenderBox.BackColor = System.Drawing.Color.White;
            this.SenderBox.Controls.Add(this.PhoneNumberBox);
            this.SenderBox.Controls.Add(this.PostOfficeNumberBox);
            this.SenderBox.Controls.Add(this.PatronymicBox);
            this.SenderBox.Controls.Add(this.SurnameBox);
            this.SenderBox.Controls.Add(this.NameBox);
            this.SenderBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SenderBox.Location = new System.Drawing.Point(6, 28);
            this.SenderBox.Name = "SenderBox";
            this.SenderBox.Size = new System.Drawing.Size(337, 342);
            this.SenderBox.TabIndex = 6;
            this.SenderBox.TabStop = false;
            this.SenderBox.Text = "Заповнення даних про відправника";
            this.SenderBox.Enter += new System.EventHandler(this.SenderBox_Enter);
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
            this.tabPage2.Controls.Add(this.ShowDepartmentLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Показ введених даних(натисніть в будь-яке місце)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowDepartmentLabel
            // 
            this.ShowDepartmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowDepartmentLabel.Location = new System.Drawing.Point(3, 3);
            this.ShowDepartmentLabel.Name = "ShowDepartmentLabel";
            this.ShowDepartmentLabel.Size = new System.Drawing.Size(695, 444);
            this.ShowDepartmentLabel.TabIndex = 0;
            this.ShowDepartmentLabel.Click += new System.EventHandler(this.ShowDepartmentLabel_Click);
            // 
            // WriteFileButton
            // 
            this.WriteFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WriteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteFileButton.ForeColor = System.Drawing.Color.Cyan;
            this.WriteFileButton.Location = new System.Drawing.Point(-7, 381);
            this.WriteFileButton.Name = "WriteFileButton";
            this.WriteFileButton.Size = new System.Drawing.Size(122, 75);
            this.WriteFileButton.TabIndex = 9;
            this.WriteFileButton.Text = "Записати всі данні у файл";
            this.WriteFileButton.UseVisualStyleBackColor = false;
            this.WriteFileButton.Click += new System.EventHandler(this.WriteFileButton_Click);
            // 
            // SenderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WriteFileButton);
            this.Controls.Add(this.SenderTabs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SenderForm";
            this.Text = "SenderForm";
            this.SenderTabs.ResumeLayout(false);
            this.CreateDepartmentTab.ResumeLayout(false);
            this.SendParcelBox.ResumeLayout(false);
            this.CreateDepartureBox.ResumeLayout(false);
            this.ParcelBox.ResumeLayout(false);
            this.ParcelWeightBox.ResumeLayout(false);
            this.ParcelWeightBox.PerformLayout();
            this.ParcelCapacityBox.ResumeLayout(false);
            this.ParcelCapacityBox.PerformLayout();
            this.ParcelNameBox.ResumeLayout(false);
            this.ParcelNameBox.PerformLayout();
            this.SenderBox.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl SenderTabs;
        private System.Windows.Forms.TabPage CreateDepartmentTab;
        private System.Windows.Forms.GroupBox SendParcelBox;
        private System.Windows.Forms.GroupBox CreateDepartureBox;
        private System.Windows.Forms.Button AddParcelToDepartureButton;
        private System.Windows.Forms.Button SendDepartureButton;
        private System.Windows.Forms.GroupBox ParcelBox;
        private System.Windows.Forms.GroupBox ParcelWeightBox;
        private System.Windows.Forms.TextBox ParcelWeightTextBox;
        private System.Windows.Forms.GroupBox ParcelCapacityBox;
        private System.Windows.Forms.TextBox ParcelCapacityTextBox;
        private System.Windows.Forms.GroupBox ParcelNameBox;
        private System.Windows.Forms.TextBox ParcelNameTextBox;
        private System.Windows.Forms.GroupBox SenderBox;
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
        private System.Windows.Forms.Label ShowDepartmentLabel;
        private System.Windows.Forms.Button WriteFileButton;
    }
}