namespace MyLittleVault
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьНовыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проект1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.парольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vPNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логинToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.парольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.проект2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логинToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.парольToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.чтотоЕщёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ссылкаНаГуглToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьНовыйФайлToolStripMenuItem,
            this.зашифроватьToolStripMenuItem,
            this.выйтиToolStripMenuItem,
            this.toolStripSeparator1,
            this.работаToolStripMenuItem,
            this.чтотоЕщёToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 120);
            // 
            // открытьНовыйФайлToolStripMenuItem
            // 
            this.открытьНовыйФайлToolStripMenuItem.Name = "открытьНовыйФайлToolStripMenuItem";
            this.открытьНовыйФайлToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.открытьНовыйФайлToolStripMenuItem.Text = "открыть новый файл";
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.зашифроватьToolStripMenuItem.Text = "зашифровать";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.выйтиToolStripMenuItem.Text = "выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проект1ToolStripMenuItem,
            this.проект2ToolStripMenuItem});
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.работаToolStripMenuItem.Text = "Работа";
            // 
            // проект1ToolStripMenuItem
            // 
            this.проект1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логинToolStripMenuItem,
            this.парольToolStripMenuItem,
            this.vPNToolStripMenuItem});
            this.проект1ToolStripMenuItem.Name = "проект1ToolStripMenuItem";
            this.проект1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проект1ToolStripMenuItem.Text = "Проект 1";
            // 
            // логинToolStripMenuItem
            // 
            this.логинToolStripMenuItem.Name = "логинToolStripMenuItem";
            this.логинToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.логинToolStripMenuItem.Text = "Логин: Login123";
            this.логинToolStripMenuItem.Click += new System.EventHandler(this.логинToolStripMenuItem_Click);
            // 
            // парольToolStripMenuItem
            // 
            this.парольToolStripMenuItem.Name = "парольToolStripMenuItem";
            this.парольToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.парольToolStripMenuItem.Text = "Пароль";
            this.парольToolStripMenuItem.Click += new System.EventHandler(this.парольToolStripMenuItem_Click);
            // 
            // vPNToolStripMenuItem
            // 
            this.vPNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логинToolStripMenuItem1,
            this.парольToolStripMenuItem1});
            this.vPNToolStripMenuItem.Name = "vPNToolStripMenuItem";
            this.vPNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vPNToolStripMenuItem.Text = "VPN";
            // 
            // логинToolStripMenuItem1
            // 
            this.логинToolStripMenuItem1.Name = "логинToolStripMenuItem1";
            this.логинToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.логинToolStripMenuItem1.Text = "Логин: LoginVPN123";
            this.логинToolStripMenuItem1.Click += new System.EventHandler(this.логинToolStripMenuItem1_Click);
            // 
            // парольToolStripMenuItem1
            // 
            this.парольToolStripMenuItem1.Name = "парольToolStripMenuItem1";
            this.парольToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.парольToolStripMenuItem1.Text = "Пароль";
            this.парольToolStripMenuItem1.Click += new System.EventHandler(this.парольToolStripMenuItem1_Click);
            // 
            // проект2ToolStripMenuItem
            // 
            this.проект2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логинToolStripMenuItem2,
            this.парольToolStripMenuItem2});
            this.проект2ToolStripMenuItem.Name = "проект2ToolStripMenuItem";
            this.проект2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проект2ToolStripMenuItem.Text = "Проект 2";
            // 
            // логинToolStripMenuItem2
            // 
            this.логинToolStripMenuItem2.Name = "логинToolStripMenuItem2";
            this.логинToolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.логинToolStripMenuItem2.Text = "Логин: Proj2Login123";
            this.логинToolStripMenuItem2.Click += new System.EventHandler(this.логинToolStripMenuItem2_Click);
            // 
            // парольToolStripMenuItem2
            // 
            this.парольToolStripMenuItem2.Name = "парольToolStripMenuItem2";
            this.парольToolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.парольToolStripMenuItem2.Text = "Пароль";
            this.парольToolStripMenuItem2.Click += new System.EventHandler(this.парольToolStripMenuItem2_Click);
            // 
            // чтотоЕщёToolStripMenuItem
            // 
            this.чтотоЕщёToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ссылкаНаГуглToolStripMenuItem});
            this.чтотоЕщёToolStripMenuItem.Name = "чтотоЕщёToolStripMenuItem";
            this.чтотоЕщёToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.чтотоЕщёToolStripMenuItem.Text = "Что-то ещё";
            // 
            // ссылкаНаГуглToolStripMenuItem
            // 
            this.ссылкаНаГуглToolStripMenuItem.Name = "ссылкаНаГуглToolStripMenuItem";
            this.ссылкаНаГуглToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ссылкаНаГуглToolStripMenuItem.Text = "Ссылка на гугл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтотоЕщёToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem открытьНовыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проект1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem парольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vPNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логинToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem парольToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem проект2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логинToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem парольToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ссылкаНаГуглToolStripMenuItem;
    }
}

