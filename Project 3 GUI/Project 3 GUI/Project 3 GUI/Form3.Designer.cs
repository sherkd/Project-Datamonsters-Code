namespace Project_3_GUI
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fietsdiefstal = new System.Windows.Forms.Button();
            this.straatroven = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.form1ToolStripMenuItem.Text = "Form 1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fietsdiefstal
            // 
            this.fietsdiefstal.Location = new System.Drawing.Point(266, 158);
            this.fietsdiefstal.Name = "fietsdiefstal";
            this.fietsdiefstal.Size = new System.Drawing.Size(338, 79);
            this.fietsdiefstal.TabIndex = 1;
            this.fietsdiefstal.Text = "fietsdiefstal";
            this.fietsdiefstal.UseVisualStyleBackColor = true;
            this.fietsdiefstal.Click += new System.EventHandler(this.button1_Click);
            // 
            // straatroven
            // 
            this.straatroven.Location = new System.Drawing.Point(266, 272);
            this.straatroven.Name = "straatroven";
            this.straatroven.Size = new System.Drawing.Size(338, 79);
            this.straatroven.TabIndex = 2;
            this.straatroven.Text = "straatroven";
            this.straatroven.UseVisualStyleBackColor = true;
            this.straatroven.Click += new System.EventHandler(this.straatroven_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 506);
            this.Controls.Add(this.straatroven);
            this.Controls.Add(this.fietsdiefstal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button fietsdiefstal;
        private System.Windows.Forms.Button straatroven;
    }
}