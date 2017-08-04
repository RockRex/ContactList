namespace ContactList
{
    partial class AllContacts
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("实验1");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("实验2");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("实验3");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllContacts));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mItemViewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemEditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemDeleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAllContactsInfo = new System.Windows.Forms.ListView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemViewContactToolStripMenuItem,
            this.mItemEditContactToolStripMenuItem,
            this.mItemDeleteContactToolStripMenuItem,
            this.mItemRefreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 100);
            // 
            // mItemViewContactToolStripMenuItem
            // 
            this.mItemViewContactToolStripMenuItem.Name = "mItemViewContactToolStripMenuItem";
            this.mItemViewContactToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mItemViewContactToolStripMenuItem.Text = "查看联系人信息";
            this.mItemViewContactToolStripMenuItem.Click += new System.EventHandler(this.mItemViewContactToolStripMenuItem_Click);
            // 
            // mItemEditContactToolStripMenuItem
            // 
            this.mItemEditContactToolStripMenuItem.Name = "mItemEditContactToolStripMenuItem";
            this.mItemEditContactToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mItemEditContactToolStripMenuItem.Text = "编辑联系人信息";
            this.mItemEditContactToolStripMenuItem.Click += new System.EventHandler(this.mItemEditContactToolStripMenuItem_Click);
            // 
            // mItemDeleteContactToolStripMenuItem
            // 
            this.mItemDeleteContactToolStripMenuItem.Name = "mItemDeleteContactToolStripMenuItem";
            this.mItemDeleteContactToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mItemDeleteContactToolStripMenuItem.Text = "删除联系人";
            this.mItemDeleteContactToolStripMenuItem.Click += new System.EventHandler(this.mItemDeleteContactToolStripMenuItem_Click);
            // 
            // mItemRefreshToolStripMenuItem
            // 
            this.mItemRefreshToolStripMenuItem.Name = "mItemRefreshToolStripMenuItem";
            this.mItemRefreshToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mItemRefreshToolStripMenuItem.Text = "刷新";
            this.mItemRefreshToolStripMenuItem.Click += new System.EventHandler(this.mItemRefreshToolStripMenuItem_Click);
            // 
            // listViewAllContactsInfo
            // 
            this.listViewAllContactsInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewAllContactsInfo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listViewAllContactsInfo.FullRowSelect = true;
            this.listViewAllContactsInfo.GridLines = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listViewAllContactsInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listViewAllContactsInfo.LabelEdit = true;
            this.listViewAllContactsInfo.Location = new System.Drawing.Point(16, 14);
            this.listViewAllContactsInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewAllContactsInfo.Name = "listViewAllContactsInfo";
            this.listViewAllContactsInfo.ShowItemToolTips = true;
            this.listViewAllContactsInfo.Size = new System.Drawing.Size(892, 274);
            this.listViewAllContactsInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAllContactsInfo.TabIndex = 1;
            this.listViewAllContactsInfo.UseCompatibleStateImageBehavior = false;
            this.listViewAllContactsInfo.View = System.Windows.Forms.View.Details;
            // 
            // AllContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 318);
            this.Controls.Add(this.listViewAllContactsInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AllContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "所有联系人信息";
            this.Load += new System.EventHandler(this.AllContacts_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mItemViewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemEditContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemDeleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemRefreshToolStripMenuItem;
        private System.Windows.Forms.ListView listViewAllContactsInfo;
    }
}