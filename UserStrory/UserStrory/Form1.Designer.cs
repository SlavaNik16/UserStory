
namespace UserStrory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Boys = new System.Windows.Forms.ToolStripStatusLabel();
            this.Girls = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dedust = new System.Windows.Forms.ToolStripStatusLabel();
            this.Debtor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Change = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Delite = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Progam = new System.Windows.Forms.ToolStripMenuItem();
            this.View1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add1tool = new System.Windows.Forms.ToolStripButton();
            this.Changetool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Delitetool = new System.Windows.Forms.ToolStripButton();
            this.FullNameColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvrRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebuctColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boys,
            this.Girls,
            this.Dedust,
            this.Debtor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Boys
            // 
            this.Boys.AutoSize = false;
            this.Boys.Name = "Boys";
            this.Boys.Size = new System.Drawing.Size(118, 17);
            this.Boys.Text = "Всего учащихся 0";
            // 
            // Girls
            // 
            this.Girls.AutoSize = false;
            this.Girls.Name = "Girls";
            this.Girls.Size = new System.Drawing.Size(118, 17);
            this.Girls.Text = "М: 0 Ж: 0";
            // 
            // Dedust
            // 
            this.Dedust.AutoSize = false;
            this.Dedust.Name = "Dedust";
            this.Dedust.Size = new System.Drawing.Size(118, 17);
            this.Dedust.Text = "Отчисленных 0";
            // 
            // Debtor
            // 
            this.Debtor.AutoSize = false;
            this.Debtor.Name = "Debtor";
            this.Debtor.Size = new System.Drawing.Size(118, 17);
            this.Debtor.Text = "Должников 0";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add1,
            this.Change,
            this.toolStripSeparator1,
            this.Delite});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // Add1
            // 
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(128, 22);
            this.Add1.Text = "Добавить";
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(128, 22);
            this.Change.Text = "Изменить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // Delite
            // 
            this.Delite.Enabled = false;
            this.Delite.Name = "Delite";
            this.Delite.Size = new System.Drawing.Size(128, 22);
            this.Delite.Text = "Удалить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progam});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Progam
            // 
            this.Progam.Name = "Progam";
            this.Progam.Size = new System.Drawing.Size(149, 22);
            this.Progam.Text = "О программе";
            this.Progam.Click += new System.EventHandler(this.Progam_Click);
            // 
            // View1
            // 
            this.View1.AllowUserToAddRows = false;
            this.View1.AllowUserToDeleteRows = false;
            this.View1.AllowUserToResizeColumns = false;
            this.View1.AllowUserToResizeRows = false;
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColum,
            this.SexColim,
            this.AgeColumn,
            this.BirthdayColum,
            this.AvrRateColumn,
            this.DebuctColumn,
            this.DebtorColumn});
            this.View1.Location = new System.Drawing.Point(0, 52);
            this.View1.Name = "View1";
            this.View1.ReadOnly = true;
            this.View1.Size = new System.Drawing.Size(800, 373);
            this.View1.TabIndex = 4;
            this.View1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.View1_CellFormatting);
            this.View1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.View1_CellPainting);
            this.View1.SelectionChanged += new System.EventHandler(this.View1_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add1tool,
            this.Changetool,
            this.toolStripSeparator2,
            this.Delitetool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Add1tool
            // 
            this.Add1tool.Image = ((System.Drawing.Image)(resources.GetObject("Add1tool.Image")));
            this.Add1tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add1tool.Name = "Add1tool";
            this.Add1tool.Size = new System.Drawing.Size(79, 22);
            this.Add1tool.Text = "Добавить";
            this.Add1tool.Click += new System.EventHandler(this.Add1tool_Click);
            // 
            // Changetool
            // 
            this.Changetool.Enabled = false;
            this.Changetool.Image = ((System.Drawing.Image)(resources.GetObject("Changetool.Image")));
            this.Changetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Changetool.Name = "Changetool";
            this.Changetool.Size = new System.Drawing.Size(81, 22);
            this.Changetool.Text = "Изменить";
            this.Changetool.Click += new System.EventHandler(this.Changetool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Delitetool
            // 
            this.Delitetool.Enabled = false;
            this.Delitetool.Image = ((System.Drawing.Image)(resources.GetObject("Delitetool.Image")));
            this.Delitetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delitetool.Name = "Delitetool";
            this.Delitetool.Size = new System.Drawing.Size(71, 22);
            this.Delitetool.Text = "Удалить";
            this.Delitetool.Click += new System.EventHandler(this.Delitetool_Click);
            // 
            // FullNameColum
            // 
            this.FullNameColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameColum.DataPropertyName = "FullName";
            this.FullNameColum.HeaderText = "ФИО";
            this.FullNameColum.Name = "FullNameColum";
            this.FullNameColum.ReadOnly = true;
            // 
            // SexColim
            // 
            this.SexColim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SexColim.DataPropertyName = "gender";
            this.SexColim.HeaderText = "Пол";
            this.SexColim.Name = "SexColim";
            this.SexColim.ReadOnly = true;
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "Возраст";
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            // 
            // BirthdayColum
            // 
            this.BirthdayColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthdayColum.DataPropertyName = "Birthday";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.BirthdayColum.DefaultCellStyle = dataGridViewCellStyle7;
            this.BirthdayColum.HeaderText = "День рождения";
            this.BirthdayColum.Name = "BirthdayColum";
            this.BirthdayColum.ReadOnly = true;
            // 
            // AvrRateColumn
            // 
            this.AvrRateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AvrRateColumn.DataPropertyName = "AvgRate";
            this.AvrRateColumn.HeaderText = "Средняя оценка";
            this.AvrRateColumn.Name = "AvrRateColumn";
            this.AvrRateColumn.ReadOnly = true;
            // 
            // DebuctColumn
            // 
            this.DebuctColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DebuctColumn.DataPropertyName = "Deduct";
            this.DebuctColumn.HeaderText = "Отчислен";
            this.DebuctColumn.Name = "DebuctColumn";
            this.DebuctColumn.ReadOnly = true;
            // 
            // DebtorColumn
            // 
            this.DebtorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DebtorColumn.DataPropertyName = "Debtor";
            this.DebtorColumn.HeaderText = "Задолжность";
            this.DebtorColumn.Name = "DebtorColumn";
            this.DebtorColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Школьный журнал";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add1;
        private System.Windows.Forms.ToolStripMenuItem Change;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Delite;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Progam;
        private System.Windows.Forms.ToolStripButton Add1tool;
        private System.Windows.Forms.ToolStripButton Changetool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Delitetool;
        private System.Windows.Forms.ToolStripStatusLabel Boys;
        private System.Windows.Forms.ToolStripStatusLabel Girls;
        private System.Windows.Forms.ToolStripStatusLabel Dedust;
        private System.Windows.Forms.ToolStripStatusLabel Debtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColim;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvrRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebuctColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtorColumn;
    }
}

