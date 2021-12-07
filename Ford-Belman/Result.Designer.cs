
namespace Ford_Belman
{
    partial class Result
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
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // result_textBox
            // 
            this.result_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.result_textBox.Location = new System.Drawing.Point(12, 12);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textBox.Size = new System.Drawing.Size(272, 483);
            this.result_textBox.TabIndex = 0;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 507);
            this.Controls.Add(this.result_textBox);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_textBox;
    }
}