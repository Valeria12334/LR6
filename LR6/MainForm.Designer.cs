namespace LR6
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventPlanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moderatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsJuryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btShowJuri = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.eventPlanIDDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.startedAtDataGridViewTextBoxColumn,
            this.moderatorIDDataGridViewTextBoxColumn,
            this.groupsJuryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // eventPlanIDDataGridViewTextBoxColumn
            // 
            this.eventPlanIDDataGridViewTextBoxColumn.DataPropertyName = "EventPlanID";
            this.eventPlanIDDataGridViewTextBoxColumn.HeaderText = "EventPlanID";
            this.eventPlanIDDataGridViewTextBoxColumn.Name = "eventPlanIDDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // startedAtDataGridViewTextBoxColumn
            // 
            this.startedAtDataGridViewTextBoxColumn.DataPropertyName = "StartedAt";
            this.startedAtDataGridViewTextBoxColumn.HeaderText = "StartedAt";
            this.startedAtDataGridViewTextBoxColumn.Name = "startedAtDataGridViewTextBoxColumn";
            // 
            // moderatorIDDataGridViewTextBoxColumn
            // 
            this.moderatorIDDataGridViewTextBoxColumn.DataPropertyName = "ModeratorID";
            this.moderatorIDDataGridViewTextBoxColumn.HeaderText = "ModeratorID";
            this.moderatorIDDataGridViewTextBoxColumn.Name = "moderatorIDDataGridViewTextBoxColumn";
            // 
            // groupsJuryDataGridViewTextBoxColumn
            // 
            this.groupsJuryDataGridViewTextBoxColumn.DataPropertyName = "GroupsJury";
            this.groupsJuryDataGridViewTextBoxColumn.HeaderText = "GroupsJury";
            this.groupsJuryDataGridViewTextBoxColumn.Name = "groupsJuryDataGridViewTextBoxColumn";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(LR6.DB.Activity);
            // 
            // btShowJuri
            // 
            this.btShowJuri.Location = new System.Drawing.Point(13, 451);
            this.btShowJuri.Margin = new System.Windows.Forms.Padding(4);
            this.btShowJuri.Name = "btShowJuri";
            this.btShowJuri.Size = new System.Drawing.Size(183, 28);
            this.btShowJuri.TabIndex = 1;
            this.btShowJuri.Text = "Просмотреть жюри";
            this.btShowJuri.UseVisualStyleBackColor = true;
            this.btShowJuri.Click += new System.EventHandler(this.btShowJuri_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(770, 451);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(183, 28);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить активность";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(414, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица активностей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(970, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btShowJuri);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventPlanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moderatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsJuryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.Button btShowJuri;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
    }
}

