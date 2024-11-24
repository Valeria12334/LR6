namespace LR6
{
    partial class AddActivityForm
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
            this.components = new System.ComponentModel.Container();
            this.btBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddActivity = new System.Windows.Forms.Button();
            this.btAddJuri = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbEvent = new System.Windows.Forms.ComboBox();
            this.eventBindingSourse = new System.Windows.Forms.BindingSource(this.components);
            this.tbDay = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbModerator = new System.Windows.Forms.ComboBox();
            this.usersBindingSourse1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbJuri = new System.Windows.Forms.ComboBox();
            this.usersBindingSourse2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSourse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSourse2)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(13, 13);
            this.btBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(112, 32);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление новой активности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "План события:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "День:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Начало мероприятия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Модератор:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Жюри:";
            // 
            // btAddActivity
            // 
            this.btAddActivity.Location = new System.Drawing.Point(256, 392);
            this.btAddActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddActivity.Name = "btAddActivity";
            this.btAddActivity.Size = new System.Drawing.Size(237, 32);
            this.btAddActivity.TabIndex = 8;
            this.btAddActivity.Text = "Добавить новую активность";
            this.btAddActivity.UseVisualStyleBackColor = true;
            this.btAddActivity.Click += new System.EventHandler(this.btAddActivity_Click);
            // 
            // btAddJuri
            // 
            this.btAddJuri.Location = new System.Drawing.Point(558, 329);
            this.btAddJuri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddJuri.Name = "btAddJuri";
            this.btAddJuri.Size = new System.Drawing.Size(91, 26);
            this.btAddJuri.TabIndex = 9;
            this.btAddJuri.Text = "Добавить";
            this.btAddJuri.UseVisualStyleBackColor = true;
            this.btAddJuri.Click += new System.EventHandler(this.btAddJuri_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(226, 106);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(315, 26);
            this.tbTitle.TabIndex = 10;
            // 
            // tbEvent
            // 
            this.tbEvent.DataSource = this.eventBindingSourse;
            this.tbEvent.DisplayMember = "Title";
            this.tbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbEvent.FormattingEnabled = true;
            this.tbEvent.Location = new System.Drawing.Point(226, 155);
            this.tbEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(315, 26);
            this.tbEvent.TabIndex = 11;
            this.tbEvent.ValueMember = "ID";
            // 
            // eventBindingSourse
            // 
            this.eventBindingSourse.DataSource = typeof(LR6.DB.Event);
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(226, 198);
            this.tbDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(121, 26);
            this.tbDay.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 240);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cbModerator
            // 
            this.cbModerator.DataSource = this.usersBindingSourse1;
            this.cbModerator.DisplayMember = "Surname";
            this.cbModerator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModerator.FormattingEnabled = true;
            this.cbModerator.Location = new System.Drawing.Point(226, 282);
            this.cbModerator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbModerator.Name = "cbModerator";
            this.cbModerator.Size = new System.Drawing.Size(315, 26);
            this.cbModerator.TabIndex = 14;
            this.cbModerator.ValueMember = "ID";
            // 
            // usersBindingSourse1
            // 
            this.usersBindingSourse1.DataSource = typeof(LR6.DB.User);
            // 
            // cbJuri
            // 
            this.cbJuri.DataSource = this.usersBindingSourse2;
            this.cbJuri.DisplayMember = "Surname";
            this.cbJuri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJuri.FormattingEnabled = true;
            this.cbJuri.Location = new System.Drawing.Point(226, 329);
            this.cbJuri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbJuri.Name = "cbJuri";
            this.cbJuri.Size = new System.Drawing.Size(315, 26);
            this.cbJuri.TabIndex = 15;
            this.cbJuri.ValueMember = "ID";
            // 
            // usersBindingSourse2
            // 
            this.usersBindingSourse2.DataSource = typeof(LR6.DB.User);
            // 
            // AddActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(670, 447);
            this.Controls.Add(this.cbJuri);
            this.Controls.Add(this.cbModerator);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.tbEvent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btAddJuri);
            this.Controls.Add(this.btAddActivity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddActivityForm";
            this.Text = "AddActivityForm";
            this.Load += new System.EventHandler(this.AddActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSourse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSourse2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAddActivity;
        private System.Windows.Forms.Button btAddJuri;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ComboBox tbEvent;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbModerator;
        private System.Windows.Forms.ComboBox cbJuri;
        private System.Windows.Forms.BindingSource eventBindingSourse;
        private System.Windows.Forms.BindingSource usersBindingSourse1;
        private System.Windows.Forms.BindingSource usersBindingSourse2;
    }
}