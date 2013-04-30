namespace CalendarMesh
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.InfoTabPage = new System.Windows.Forms.TabPage();
            this.AuthenticationTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.InfoTabPage);
            this.MainTabControl.Controls.Add(this.AuthenticationTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(513, 434);
            this.MainTabControl.TabIndex = 0;
            // 
            // InfoTabPage
            // 
            this.InfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.InfoTabPage.Name = "InfoTabPage";
            this.InfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTabPage.Size = new System.Drawing.Size(505, 408);
            this.InfoTabPage.TabIndex = 0;
            this.InfoTabPage.Text = "Info";
            this.InfoTabPage.UseVisualStyleBackColor = true;
            // 
            // AuthenticationTabPage
            // 
            this.AuthenticationTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuthenticationTabPage.Name = "AuthenticationTabPage";
            this.AuthenticationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthenticationTabPage.Size = new System.Drawing.Size(505, 408);
            this.AuthenticationTabPage.TabIndex = 1;
            this.AuthenticationTabPage.Text = "Authentication";
            this.AuthenticationTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 434);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Calendar Mesh";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage InfoTabPage;
        private System.Windows.Forms.TabPage AuthenticationTabPage;

    }
}