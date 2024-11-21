namespace E.R._3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 34);
            label1.Name = "label1";
            label1.Size = new Size(410, 23);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 99);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 1;
            label2.Text = "Introduce un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 278);
            label3.Name = "label3";
            label3.Size = new Size(226, 25);
            label3.TabIndex = 2;
            label3.Text = "La suma de todos son";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(614, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 254);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(381, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 33);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(381, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 33);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(408, 154);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(289, 349);
            button2.Name = "button2";
            button2.Size = new Size(191, 34);
            button2.TabIndex = 7;
            button2.Text = "Sumar numeros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
