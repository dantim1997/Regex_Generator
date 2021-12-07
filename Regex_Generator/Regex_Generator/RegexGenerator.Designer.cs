
namespace Regex_Generator
{
    partial class RegexGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxCreator = new System.Windows.Forms.Panel();
            this.Navigation = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxNumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.uxPhoneNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxCreator
            // 
            this.uxCreator.Dock = System.Windows.Forms.DockStyle.Right;
            this.uxCreator.Location = new System.Drawing.Point(183, 0);
            this.uxCreator.Name = "uxCreator";
            this.uxCreator.Size = new System.Drawing.Size(617, 450);
            this.uxCreator.TabIndex = 1;
            // 
            // Navigation
            // 
            this.Navigation.Controls.Add(this.menuStrip1);
            this.Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.Navigation.Location = new System.Drawing.Point(0, 0);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(177, 450);
            this.Navigation.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 50, 0, 5);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxString,
            this.uxNumbers,
            this.uxPhoneNumber});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // uxString
            // 
            this.uxString.Name = "uxString";
            this.uxString.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.uxString.Size = new System.Drawing.Size(113, 29);
            this.uxString.Text = "String";
            // 
            // uxNumbers
            // 
            this.uxNumbers.Name = "uxNumbers";
            this.uxNumbers.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.uxNumbers.Size = new System.Drawing.Size(113, 29);
            this.uxNumbers.Text = "Numbers";
            // 
            // uxPhoneNumber
            // 
            this.uxPhoneNumber.Name = "uxPhoneNumber";
            this.uxPhoneNumber.Size = new System.Drawing.Size(113, 19);
            this.uxPhoneNumber.Text = "PhoneNumber";
            // 
            // RegexGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.uxCreator);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegexGenerator";
            this.Text = "Regex Generator";
            this.Navigation.ResumeLayout(false);
            this.Navigation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxCreator;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxString;
        private System.Windows.Forms.ToolStripMenuItem uxNumbers;
        private System.Windows.Forms.ToolStripMenuItem uxPhoneNumber;
    }
}

