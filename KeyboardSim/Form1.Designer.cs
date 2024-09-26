namespace KeyboardSim
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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 103);
            button1.Name = "button1";
            button1.Size = new Size(315, 29);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Text to send";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(100, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(263, 70);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(64, 27);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Mask Text";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Send After:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 72);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Type Speed:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(114, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(111, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Stay On Top";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 138);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Text Typer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox2;
    }
}
