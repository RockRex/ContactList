namespace ContactList
{
    partial class ResultsFound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsFound));
            this.listViewContactsFound = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewContactsFound
            // 
            this.listViewContactsFound.Location = new System.Drawing.Point(16, 14);
            this.listViewContactsFound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewContactsFound.Name = "listViewContactsFound";
            this.listViewContactsFound.Size = new System.Drawing.Size(788, 274);
            this.listViewContactsFound.TabIndex = 0;
            this.listViewContactsFound.UseCompatibleStateImageBehavior = false;
            this.listViewContactsFound.View = System.Windows.Forms.View.Details;
            // 
            // ResultsFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 320);
            this.Controls.Add(this.listViewContactsFound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResultsFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找结果";
            this.Load += new System.EventHandler(this.ResultsFound_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewContactsFound;
    }
}