namespace GraphicsPackage
{
    partial class DDA
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
            this.Y1 = new System.Windows.Forms.MaskedTextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.WWW = new System.Windows.Forms.Label();
            this.Y1WDA = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.Label();
            this.WDAD = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bf1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bf1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "DDA Algorithm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bf1_MouseMove);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(55, 71);
            this.X1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(132, 22);
            this.X1.TabIndex = 1;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(207, 71);
            this.Y1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(132, 22);
            this.Y1.TabIndex = 2;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(207, 188);
            this.Y2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(132, 22);
            this.Y2.TabIndex = 3;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(55, 188);
            this.X2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(132, 22);
            this.X2.TabIndex = 4;
            // 
            // WWW
            // 
            this.WWW.AutoSize = true;
            this.WWW.Location = new System.Drawing.Point(99, 33);
            this.WWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WWW.Name = "WWW";
            this.WWW.Size = new System.Drawing.Size(25, 17);
            this.WWW.TabIndex = 5;
            this.WWW.Text = "X1";
            // 
            // Y1WDA
            // 
            this.Y1WDA.AutoSize = true;
            this.Y1WDA.Location = new System.Drawing.Point(248, 33);
            this.Y1WDA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y1WDA.Name = "Y1WDA";
            this.Y1WDA.Size = new System.Drawing.Size(25, 17);
            this.Y1WDA.TabIndex = 6;
            this.Y1WDA.Text = "Y1";
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.Location = new System.Drawing.Point(99, 156);
            this.AD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(25, 17);
            this.AD.TabIndex = 7;
            this.AD.Text = "X2";
            // 
            // WDAD
            // 
            this.WDAD.AutoSize = true;
            this.WDAD.Location = new System.Drawing.Point(248, 156);
            this.WDAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WDAD.Name = "WDAD";
            this.WDAD.Size = new System.Drawing.Size(25, 17);
            this.WDAD.TabIndex = 8;
            this.WDAD.Text = "Y2";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bf1
            // 
            this.bf1.Location = new System.Drawing.Point(372, 15);
            this.bf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bf1.Name = "bf1";
            this.bf1.Size = new System.Drawing.Size(623, 569);
            this.bf1.TabIndex = 9;
            this.bf1.TabStop = false;
            //this.bf1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bf1_MouseMove);
            // 
            // DDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 598);
            this.Controls.Add(this.bf1);
            this.Controls.Add(this.WDAD);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.Y1WDA);
            this.Controls.Add(this.WWW);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DDA";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bf1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.MaskedTextBox Y1;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label WWW;
        private System.Windows.Forms.Label Y1WDA;
        private System.Windows.Forms.Label AD;
        private System.Windows.Forms.Label WDAD;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox bf1;
    }
}

