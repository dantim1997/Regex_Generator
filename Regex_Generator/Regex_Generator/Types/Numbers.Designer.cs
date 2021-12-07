
namespace Regex_Generator.Types
{
    partial class Numbers
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
            this.components = new System.ComponentModel.Container();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.uxMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uxResult = new System.Windows.Forms.Label();
            this.uxExceptions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxException = new System.Windows.Forms.NumericUpDown();
            this.uxAddException = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxException)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(14, 268);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // uxMax
            // 
            this.uxMax.Location = new System.Drawing.Point(95, 12);
            this.uxMax.Name = "uxMax";
            this.uxMax.Size = new System.Drawing.Size(120, 23);
            this.uxMax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min amount";
            // 
            // uxMin
            // 
            this.uxMin.Location = new System.Drawing.Point(95, 41);
            this.uxMin.Name = "uxMin";
            this.uxMin.Size = new System.Drawing.Size(120, 23);
            this.uxMin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // uxResult
            // 
            this.uxResult.AutoSize = true;
            this.uxResult.Location = new System.Drawing.Point(143, 272);
            this.uxResult.Name = "uxResult";
            this.uxResult.Size = new System.Drawing.Size(22, 15);
            this.uxResult.TabIndex = 8;
            this.uxResult.Text = ".....";
            this.toolTip1.SetToolTip(this.uxResult, "Double click to copy");
            // 
            // uxExceptions
            // 
            this.uxExceptions.FormattingEnabled = true;
            this.uxExceptions.ItemHeight = 15;
            this.uxExceptions.Location = new System.Drawing.Point(95, 105);
            this.uxExceptions.Name = "uxExceptions";
            this.uxExceptions.Size = new System.Drawing.Size(120, 94);
            this.uxExceptions.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exceptions";
            // 
            // uxException
            // 
            this.uxException.Location = new System.Drawing.Point(95, 76);
            this.uxException.Name = "uxException";
            this.uxException.Size = new System.Drawing.Size(70, 23);
            this.uxException.TabIndex = 11;
            // 
            // uxAddException
            // 
            this.uxAddException.Location = new System.Drawing.Point(171, 76);
            this.uxAddException.Name = "uxAddException";
            this.uxAddException.Size = new System.Drawing.Size(43, 23);
            this.uxAddException.TabIndex = 12;
            this.uxAddException.Text = "Add";
            this.uxAddException.UseVisualStyleBackColor = true;
            this.uxAddException.Click += new System.EventHandler(this.uxAddException_Click);
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxAddException);
            this.Controls.Add(this.uxException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxExceptions);
            this.Controls.Add(this.uxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMax);
            this.Controls.Add(this.btn_Generate);
            this.Name = "Numbers";
            this.Size = new System.Drawing.Size(293, 308);
            ((System.ComponentModel.ISupportInitialize)(this.uxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxException)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.NumericUpDown uxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uxMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxResult;
        private System.Windows.Forms.ListBox uxExceptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown uxException;
        private System.Windows.Forms.Button uxAddException;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
