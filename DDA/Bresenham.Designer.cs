namespace GraphicsPackage
{
    partial class Bresenham
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
            this.button1 = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.linePanel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bresenham Algorithm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(45, 92);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 20);
            this.X1.TabIndex = 1;
            this.X1.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(190, 92);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 20);
            this.Y1.TabIndex = 2;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(45, 223);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 20);
            this.X2.TabIndex = 3;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(190, 223);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 20);
            this.Y2.TabIndex = 4;
            this.Y2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // linePanel
            // 
            this.linePanel.Location = new System.Drawing.Point(336, 69);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(411, 332);
            this.linePanel.TabIndex = 5;
            this.linePanel.TabStop = false;
            this.linePanel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y2";
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.button1);
            this.Name = "Bresenham";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Bresenham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.PictureBox linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}