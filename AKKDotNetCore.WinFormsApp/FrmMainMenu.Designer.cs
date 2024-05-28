﻿namespace AKKDotNetCore.WinFormsApp
{
    partial class FrmMainMenu
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
            menuStrip1 = new MenuStrip();
            blogToolStripMenuItem = new ToolStripMenuItem();
            newBlogToolStripMenuItem = new ToolStripMenuItem();
            blogsToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { blogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // blogToolStripMenuItem
            // 
            blogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBlogToolStripMenuItem, blogsToolStripMenuItem1 });
            blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            blogToolStripMenuItem.Size = new Size(54, 24);
            blogToolStripMenuItem.Text = "Blog";
            // 
            // newBlogToolStripMenuItem
            // 
            newBlogToolStripMenuItem.Name = "newBlogToolStripMenuItem";
            newBlogToolStripMenuItem.Size = new Size(224, 26);
            newBlogToolStripMenuItem.Text = "New Blog";
            newBlogToolStripMenuItem.Click += newBlogToolStripMenuItem_Click;
            // 
            // blogsToolStripMenuItem1
            // 
            blogsToolStripMenuItem1.Name = "blogsToolStripMenuItem1";
            blogsToolStripMenuItem1.Size = new Size(224, 26);
            blogsToolStripMenuItem1.Text = "Blogs";
            blogsToolStripMenuItem1.Click += blogsToolStripMenuItem1_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem blogToolStripMenuItem;
        private ToolStripMenuItem newBlogToolStripMenuItem;
        private ToolStripMenuItem blogsToolStripMenuItem1;
    }
}