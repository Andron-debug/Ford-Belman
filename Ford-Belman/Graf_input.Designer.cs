
namespace Ford_Belman
{
    partial class Graf_input
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
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Graf = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.simetr_button = new System.Windows.Forms.Button();
            this.is_graf = new System.Windows.Forms.RadioButton();
            this.is_orgraf = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.start_vertex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.Location = new System.Drawing.Point(21, 212);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 38);
            this.Back.TabIndex = 0;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Location = new System.Drawing.Point(345, 183);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(148, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Анализировать";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Graf
            // 
            this.Graf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graf.ColumnCount = 2;
            this.Graf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Graf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Graf.Location = new System.Drawing.Point(12, 67);
            this.Graf.Name = "Graf";
            this.Graf.RowCount = 2;
            this.Graf.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Graf.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Graf.Size = new System.Drawing.Size(477, 97);
            this.Graf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Матрица весов";
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(345, 212);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(148, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "Чистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // simetr_button
            // 
            this.simetr_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simetr_button.Location = new System.Drawing.Point(345, 241);
            this.simetr_button.Name = "simetr_button";
            this.simetr_button.Size = new System.Drawing.Size(148, 23);
            this.simetr_button.TabIndex = 5;
            this.simetr_button.Text = "Симметризировать";
            this.simetr_button.UseVisualStyleBackColor = true;
            this.simetr_button.Click += new System.EventHandler(this.simetr_Click);
            // 
            // is_graf
            // 
            this.is_graf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.is_graf.AutoSize = true;
            this.is_graf.Checked = true;
            this.is_graf.Location = new System.Drawing.Point(259, 203);
            this.is_graf.Name = "is_graf";
            this.is_graf.Size = new System.Drawing.Size(64, 21);
            this.is_graf.TabIndex = 6;
            this.is_graf.TabStop = true;
            this.is_graf.Text = "Граф";
            this.is_graf.UseVisualStyleBackColor = true;
            // 
            // is_orgraf
            // 
            this.is_orgraf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.is_orgraf.AutoSize = true;
            this.is_orgraf.Location = new System.Drawing.Point(259, 230);
            this.is_orgraf.Name = "is_orgraf";
            this.is_orgraf.Size = new System.Drawing.Size(80, 21);
            this.is_orgraf.TabIndex = 7;
            this.is_orgraf.Text = "Орграф";
            this.is_orgraf.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Исходная вершина";
            
            // 
            // start_vertex
            // 
            this.start_vertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start_vertex.Location = new System.Drawing.Point(109, 203);
            this.start_vertex.Name = "start_vertex";
            this.start_vertex.Size = new System.Drawing.Size(100, 22);
            this.start_vertex.TabIndex = 9;
            // 
            // Graf_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 275);
            this.Controls.Add(this.start_vertex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.is_orgraf);
            this.Controls.Add(this.is_graf);
            this.Controls.Add(this.simetr_button);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graf);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Name = "Graf_input";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Graf_FormClosing);
            this.Load += new System.EventHandler(this.Cayley_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TableLayoutPanel Graf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button simetr_button;
        private System.Windows.Forms.RadioButton is_graf;
        private System.Windows.Forms.RadioButton is_orgraf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox start_vertex;
    }
}