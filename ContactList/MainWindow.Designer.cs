namespace ContactList
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wenjianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemViewAllContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemCreateNewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemSearchItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-1, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "海内存知己，";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wenjianToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(379, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wenjianToolStripMenuItem
            // 
            this.wenjianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemViewAllContactsToolStripMenuItem,
            this.mItemCreateNewContactToolStripMenuItem,
            this.mItemExitToolStripMenuItem});
            this.wenjianToolStripMenuItem.Name = "wenjianToolStripMenuItem";
            this.wenjianToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.wenjianToolStripMenuItem.Text = "文件";
            // 
            // mItemViewAllContactsToolStripMenuItem
            // 
            this.mItemViewAllContactsToolStripMenuItem.Name = "mItemViewAllContactsToolStripMenuItem";
            this.mItemViewAllContactsToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.mItemViewAllContactsToolStripMenuItem.Text = "所有联系人";
            this.mItemViewAllContactsToolStripMenuItem.Click += new System.EventHandler(this.mItemViewAllContactsToolStripMenuItem_Click);
            // 
            // mItemCreateNewContactToolStripMenuItem
            // 
            this.mItemCreateNewContactToolStripMenuItem.Name = "mItemCreateNewContactToolStripMenuItem";
            this.mItemCreateNewContactToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.mItemCreateNewContactToolStripMenuItem.Text = " 新建联系人";
            this.mItemCreateNewContactToolStripMenuItem.Click += new System.EventHandler(this.mItemCreateNewContactToolStripMenuItem_Click);
            // 
            // mItemExitToolStripMenuItem
            // 
            this.mItemExitToolStripMenuItem.Name = "mItemExitToolStripMenuItem";
            this.mItemExitToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.mItemExitToolStripMenuItem.Text = "退出";
            this.mItemExitToolStripMenuItem.Click += new System.EventHandler(this.mItemExitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemSearchItemToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.searchToolStripMenuItem.Text = "查找";
            // 
            // mItemSearchItemToolStripMenuItem
            // 
            this.mItemSearchItemToolStripMenuItem.Name = "mItemSearchItemToolStripMenuItem";
            this.mItemSearchItemToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.mItemSearchItemToolStripMenuItem.Text = "查找联系人";
            this.mItemSearchItemToolStripMenuItem.Click += new System.EventHandler(this.mItemSearchItemToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.helpToolStripMenuItem.Text = "关于";
            // 
            // mItemHelpToolStripMenuItem
            // 
            this.mItemHelpToolStripMenuItem.Name = "mItemHelpToolStripMenuItem";
            this.mItemHelpToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.mItemHelpToolStripMenuItem.Text = "帮助";
            this.mItemHelpToolStripMenuItem.Click += new System.EventHandler(this.mItemHelpToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "天涯若比邻。";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wenjianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemViewAllContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemCreateNewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemSearchItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemHelpToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}