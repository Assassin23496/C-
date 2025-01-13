namespace Objektuwka
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(12, 310);
            button1.Name = "button1";
            button1.Size = new Size(108, 48);
            button1.TabIndex = 0;
            button1.Text = "AddFirst";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(143, 358);
            button2.Name = "button2";
            button2.Size = new Size(108, 48);
            button2.TabIndex = 1;
            button2.Text = "AddLast";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Location = new Point(273, 376);
            button3.Name = "button3";
            button3.Size = new Size(108, 48);
            button3.TabIndex = 2;
            button3.Text = "RemoveFirst";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Location = new Point(387, 376);
            button4.Name = "button4";
            button4.Size = new Size(108, 48);
            button4.TabIndex = 3;
            button4.Text = "RemoveLast";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ScrollBar;
            button5.Location = new Point(511, 358);
            button5.Name = "button5";
            button5.Size = new Size(108, 48);
            button5.TabIndex = 4;
            button5.Text = "ToString";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Location = new Point(636, 310);
            button6.Name = "button6";
            button6.Size = new Size(108, 48);
            button6.TabIndex = 5;
            button6.Text = "Get";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(46, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 138);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientActiveCaption;
            textBox2.Location = new Point(468, 66);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 124);
            textBox2.TabIndex = 7;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(224, 224, 224);
            button7.Location = new Point(343, 238);
            button7.Name = "button7";
            button7.Size = new Size(94, 48);
            button7.TabIndex = 8;
            button7.Text = "PrintList";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button7;
    }
}
