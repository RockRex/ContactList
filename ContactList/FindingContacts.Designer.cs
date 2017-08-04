namespace ContactList
{
    partial class FindingContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingContacts));
            this.lbSearchInfo = new System.Windows.Forms.Label();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.groupBoxMatchInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonMobilephoneNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonQqNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxMatchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSearchInfo
            // 
            this.lbSearchInfo.AutoSize = true;
            this.lbSearchInfo.Location = new System.Drawing.Point(27, 30);
            this.lbSearchInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchInfo.Name = "lbSearchInfo";
            this.lbSearchInfo.Size = new System.Drawing.Size(157, 15);
            this.lbSearchInfo.TabIndex = 0;
            this.lbSearchInfo.Text = "请输入要搜索的信息：";
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Location = new System.Drawing.Point(241, 27);
            this.txtSearchInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(185, 25);
            this.txtSearchInfo.TabIndex = 1;
            // 
            // groupBoxMatchInfo
            // 
            this.groupBoxMatchInfo.Controls.Add(this.radioButtonMobilephoneNumber);
            this.groupBoxMatchInfo.Controls.Add(this.radioButtonQqNumber);
            this.groupBoxMatchInfo.Controls.Add(this.radioButtonName);
            this.groupBoxMatchInfo.Location = new System.Drawing.Point(31, 74);
            this.groupBoxMatchInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxMatchInfo.Name = "groupBoxMatchInfo";
            this.groupBoxMatchInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxMatchInfo.Size = new System.Drawing.Size(267, 55);
            this.groupBoxMatchInfo.TabIndex = 2;
            this.groupBoxMatchInfo.TabStop = false;
            this.groupBoxMatchInfo.Text = "搜索匹配";
            // 
            // radioButtonMobilephoneNumber
            // 
            this.radioButtonMobilephoneNumber.AutoSize = true;
            this.radioButtonMobilephoneNumber.Location = new System.Drawing.Point(163, 29);
            this.radioButtonMobilephoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonMobilephoneNumber.Name = "radioButtonMobilephoneNumber";
            this.radioButtonMobilephoneNumber.Size = new System.Drawing.Size(73, 19);
            this.radioButtonMobilephoneNumber.TabIndex = 1;
            this.radioButtonMobilephoneNumber.TabStop = true;
            this.radioButtonMobilephoneNumber.Text = "手机号";
            this.radioButtonMobilephoneNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonQqNumber
            // 
            this.radioButtonQqNumber.AutoSize = true;
            this.radioButtonQqNumber.Location = new System.Drawing.Point(83, 29);
            this.radioButtonQqNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonQqNumber.Name = "radioButtonQqNumber";
            this.radioButtonQqNumber.Size = new System.Drawing.Size(59, 19);
            this.radioButtonQqNumber.TabIndex = 0;
            this.radioButtonQqNumber.TabStop = true;
            this.radioButtonQqNumber.Text = "QQ号";
            this.radioButtonQqNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(9, 29);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(58, 19);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "名字";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(328, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 107);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FindingContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 143);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBoxMatchInfo);
            this.Controls.Add(this.txtSearchInfo);
            this.Controls.Add(this.lbSearchInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FindingContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找联系人";
            this.groupBoxMatchInfo.ResumeLayout(false);
            this.groupBoxMatchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.GroupBox groupBoxMatchInfo;
        private System.Windows.Forms.RadioButton radioButtonMobilephoneNumber;
        private System.Windows.Forms.RadioButton radioButtonQqNumber;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}