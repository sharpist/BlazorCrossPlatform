using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlazorWinForms
{
    partial class Form
    {
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components is not null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.resources      = new(typeof(Form));
            this.blazorWebView  = new();
            this.menuStrip      = new();
            this.file           = new();
            this.showCounter    = new();
            this.exit           = new();
            this.help           = new();
            this.description    = new();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // blazorWebView
            // 
            this.blazorWebView.Anchor   = (AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
            this.blazorWebView.Location = new Point(0, 30);
            this.blazorWebView.Name     = "blazorWebView";
            this.blazorWebView.Size     = new Size(720, 450);
            this.blazorWebView.TabIndex = 20;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new ToolStripItem[] { this.file, this.help });
            this.menuStrip.Location    = new Point(0, 0);
            this.menuStrip.Name        = "menuStrip";
            this.menuStrip.Text        = "";
            this.menuStrip.Font        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.menuStrip.Size        = new Size(720, 30);
            this.menuStrip.MinimumSize = new Size(0, 30);
            this.menuStrip.TabIndex    = 21;
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new ToolStripItem[] { this.showCounter, this.exit });
            this.file.Name = "file";
            this.file.Text = "File";
            this.file.Size = new Size(60, 24);
            // 
            // showCounter
            // 
            this.showCounter.Name = "showCounter";
            this.showCounter.Text = "Show counter";
            this.showCounter.Size = new Size(60, 24);
            this.showCounter.Click += new EventHandler(this.showCounter_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Text = "Exit";
            this.exit.Size = new Size(60, 24);
            this.exit.Click += new EventHandler(this.exit_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new ToolStripItem[] { this.description });
            this.help.Name = "help";
            this.help.Text = "Help";
            this.help.Size = new Size(60, 24);
            // 
            // description
            // 
            this.description.Name = "description";
            this.description.Text = "Description";
            this.description.Size = new Size(60, 24);
            this.description.Click += new EventHandler(this.description_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode       = AutoScaleMode.Font;
            this.ClientSize          = new Size(720, 480);
            this.Controls.Add(this.blazorWebView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip       = this.menuStrip;
            this.Name                = "form";
            this.Text                = "Blazor WinForms";
            this.Icon                = (Icon)(resources.GetObject("$this.Icon"));
            this.Load += new EventHandler(this.Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private ComponentResourceManager resources;
        private BlazorWebView            blazorWebView;
        private MenuStrip                menuStrip;
        private ToolStripMenuItem        file;
        private ToolStripMenuItem        showCounter;
        private ToolStripMenuItem        exit;
        private ToolStripMenuItem        help;
        private ToolStripMenuItem        description;
    }
}

