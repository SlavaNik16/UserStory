
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.Delitetool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Debtor = new System.Windows.Forms.ToolStripStatusLabel();
            this.Boys = new System.Windows.Forms.ToolStripStatusLabel();
            this.Girls = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dedust = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.Exit.Size = new System.Drawing.Size(180, 22);
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
            this.Add1.Size = new System.Drawing.Size(180, 22);
            this.Add1.Text = "Добавить";
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(180, 22);
            this.Change.Text = "Изменить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Delite
            // 
            this.Delite.Enabled = false;
            this.Delite.Name = "Delite";
            this.Delite.Size = new System.Drawing.Size(180, 22);
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
            this.Progam.Size = new System.Drawing.Size(180, 22);
            this.Progam.Text = "О программе";
            this.Progam.Click += new System.EventHandler(this.Progam_Click);
            // 
            // View1
            // 
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Location = new System.Drawing.Point(0, 52);
            this.View1.Name = "View1";
            this.View1.Size = new System.Drawing.Size(800, 373);
            this.View1.TabIndex = 4;
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
            // 
            // Delitetool
            // 
            this.Delitetool.Enabled = false;
            this.Delitetool.Image = ((System.Drawing.Image)(resources.GetObject("Delitetool.Image")));
            this.Delitetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delitetool.Name = "Delitetool";
            this.Delitetool.Size = new System.Drawing.Size(71, 22);
            this.Delitetool.Text = "Удалить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Debtor
            // 
            this.Debtor.AutoSize = false;
            this.Debtor.Name = "Debtor";
            this.Debtor.Size = new System.Drawing.Size(118, 17);
            this.Debtor.Text = "Должников 0";
            // 
            // Boys
            // 
            this.Boys.AutoSize = false;
            this.Boys.Name = "Boys";
            this.Boys.Size = new System.Drawing.Size(118, 17);
            this.Boys.Text = "Всего мальчиков 0";
            // 
            // Girls
            // 
            this.Girls.AutoSize = false;
            this.Girls.Name = "Girls";
            this.Girls.Size = new System.Drawing.Size(118, 17);
            this.Girls.Text = "Всего девочек 0";
            // 
            // Dedust
            // 
            this.Dedust.AutoSize = false;
            this.Dedust.Name = "Dedust";
            this.Dedust.Size = new System.Drawing.Size(118, 17);
            this.Dedust.Text = "Отчисленных 0";
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
    }
}

