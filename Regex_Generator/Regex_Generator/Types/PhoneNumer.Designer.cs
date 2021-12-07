
namespace Regex_Generator.Types
{
    partial class PhoneNumer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxCountrynum = new System.Windows.Forms.TextBox();
            this.uxResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCounty = new System.Windows.Forms.RadioButton();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxCountrynum
            // 
            this.uxCountrynum.Location = new System.Drawing.Point(104, 81);
            this.uxCountrynum.Name = "uxCountrynum";
            this.uxCountrynum.Size = new System.Drawing.Size(100, 23);
            this.uxCountrynum.TabIndex = 1;
            // 
            // uxResult
            // 
            this.uxResult.AutoSize = true;
            this.uxResult.Location = new System.Drawing.Point(147, 332);
            this.uxResult.Name = "uxResult";
            this.uxResult.Size = new System.Drawing.Size(22, 15);
            this.uxResult.TabIndex = 11;
            this.uxResult.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result:";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(18, 328);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 9;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Country number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCounty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbMobile);
            this.panel1.Controls.Add(this.uxCountrynum);
            this.panel1.Location = new System.Drawing.Point(18, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 156);
            this.panel1.TabIndex = 16;
            // 
            // rbCounty
            // 
            this.rbCounty.AutoSize = true;
            this.rbCounty.Location = new System.Drawing.Point(3, 53);
            this.rbCounty.Name = "rbCounty";
            this.rbCounty.Size = new System.Drawing.Size(64, 19);
            this.rbCounty.TabIndex = 17;
            this.rbCounty.TabStop = true;
            this.rbCounty.Text = "County";
            this.rbCounty.UseVisualStyleBackColor = true;
            // 
            // rbMobile
            // 
            this.rbMobile.AutoSize = true;
            this.rbMobile.Location = new System.Drawing.Point(3, 28);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(62, 19);
            this.rbMobile.TabIndex = 16;
            this.rbMobile.TabStop = true;
            this.rbMobile.Text = "Mobile";
            this.rbMobile.UseVisualStyleBackColor = true;
            // 
            // PhoneNumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Generate);
            this.Name = "PhoneNumer";
            this.Size = new System.Drawing.Size(533, 365);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxCountrynum;
        private System.Windows.Forms.Label uxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbInternational;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCounty;
        private System.Windows.Forms.RadioButton rbMobile;
    }
}
