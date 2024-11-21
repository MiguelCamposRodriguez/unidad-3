namespace ES15
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
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(619, 25);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, el programa aplica un aumento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 68);
            label2.Name = "label2";
            label2.Size = new Size(331, 25);
            label2.TabIndex = 1;
            label2.Text = "del 15% si el sueldo es inferior a 400000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 149);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingresar sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 215);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 3;
            label4.Text = "Sueldo nuevo";
            // 
            // button1
            // 
            button1.Location = new Point(431, 158);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
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
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
