namespace SYS_AutoUpdater
{
    partial class SYS_AutoUpdater
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 6);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Atmosphere Version:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 40);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Hekate Version:";
            // 
            // button1
            // 
            button1.Location = new Point(24, 76);
            button1.Name = "button1";
            button1.Size = new Size(226, 36);
            button1.TabIndex = 4;
            button1.Text = "Grab Latest Releases";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 118);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(226, 18);
            progressBar1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(175, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // SYS_AutoUpdater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 144);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "SYS_AutoUpdater";
            Text = "SYS-AutoUpdater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button button2;
    }
}