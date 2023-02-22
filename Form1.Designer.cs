namespace Supercomplex_Calculator__rem_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExponentiationBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RootBtn = new System.Windows.Forms.Button();
            this.FactorialBtn = new System.Windows.Forms.Button();
            this.DivisionByModuleBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.SubtractionBtn = new System.Windows.Forms.Button();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.XorBtn = new System.Windows.Forms.Button();
            this.OrBtn = new System.Windows.Forms.Button();
            this.AndBtn = new System.Windows.Forms.Button();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.OperationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(301, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 95);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // ExponentiationBtn
            // 
            this.ExponentiationBtn.Location = new System.Drawing.Point(425, 15);
            this.ExponentiationBtn.Name = "ExponentiationBtn";
            this.ExponentiationBtn.Size = new System.Drawing.Size(75, 50);
            this.ExponentiationBtn.TabIndex = 8;
            this.ExponentiationBtn.Text = "n^m";
            this.ExponentiationBtn.UseVisualStyleBackColor = true;
            this.ExponentiationBtn.Click += new System.EventHandler(this.ExponentiationBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Location = new System.Drawing.Point(344, 15);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(75, 50);
            this.SquareBtn.TabIndex = 7;
            this.SquareBtn.Text = "n²";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RootBtn
            // 
            this.RootBtn.Location = new System.Drawing.Point(263, 15);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(75, 50);
            this.RootBtn.TabIndex = 6;
            this.RootBtn.Text = "√";
            this.RootBtn.UseVisualStyleBackColor = true;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // FactorialBtn
            // 
            this.FactorialBtn.Location = new System.Drawing.Point(182, 71);
            this.FactorialBtn.Name = "FactorialBtn";
            this.FactorialBtn.Size = new System.Drawing.Size(75, 50);
            this.FactorialBtn.TabIndex = 5;
            this.FactorialBtn.Text = "n!";
            this.FactorialBtn.UseVisualStyleBackColor = true;
            this.FactorialBtn.Click += new System.EventHandler(this.FactorialBtn_Click);
            // 
            // DivisionByModuleBtn
            // 
            this.DivisionByModuleBtn.Location = new System.Drawing.Point(101, 71);
            this.DivisionByModuleBtn.Name = "DivisionByModuleBtn";
            this.DivisionByModuleBtn.Size = new System.Drawing.Size(75, 50);
            this.DivisionByModuleBtn.TabIndex = 4;
            this.DivisionByModuleBtn.Text = "%";
            this.DivisionByModuleBtn.UseVisualStyleBackColor = true;
            this.DivisionByModuleBtn.Click += new System.EventHandler(this.DivisionByModuleBtn_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Location = new System.Drawing.Point(20, 71);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(75, 50);
            this.DivisionBtn.TabIndex = 3;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.Location = new System.Drawing.Point(182, 15);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(75, 50);
            this.MultiplicationBtn.TabIndex = 2;
            this.MultiplicationBtn.Text = "*";
            this.MultiplicationBtn.UseVisualStyleBackColor = true;
            this.MultiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.Location = new System.Drawing.Point(101, 15);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(75, 50);
            this.SubtractionBtn.TabIndex = 1;
            this.SubtractionBtn.Text = "-";
            this.SubtractionBtn.UseVisualStyleBackColor = true;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Location = new System.Drawing.Point(20, 15);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(75, 50);
            this.AdditionBtn.TabIndex = 0;
            this.AdditionBtn.Text = "+";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // XorBtn
            // 
            this.XorBtn.Location = new System.Drawing.Point(425, 71);
            this.XorBtn.Name = "XorBtn";
            this.XorBtn.Size = new System.Drawing.Size(75, 50);
            this.XorBtn.TabIndex = 11;
            this.XorBtn.Text = "XOR";
            this.XorBtn.UseVisualStyleBackColor = true;
            // 
            // OrBtn
            // 
            this.OrBtn.Location = new System.Drawing.Point(344, 71);
            this.OrBtn.Name = "OrBtn";
            this.OrBtn.Size = new System.Drawing.Size(75, 50);
            this.OrBtn.TabIndex = 10;
            this.OrBtn.Text = "OR";
            this.OrBtn.UseVisualStyleBackColor = true;
            // 
            // AndBtn
            // 
            this.AndBtn.Location = new System.Drawing.Point(263, 71);
            this.AndBtn.Name = "AndBtn";
            this.AndBtn.Size = new System.Drawing.Size(75, 50);
            this.AndBtn.TabIndex = 9;
            this.AndBtn.Text = "AND";
            this.AndBtn.UseVisualStyleBackColor = true;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.DivisionBtn);
            this.OperationsPanel.Controls.Add(this.ExponentiationBtn);
            this.OperationsPanel.Controls.Add(this.AdditionBtn);
            this.OperationsPanel.Controls.Add(this.XorBtn);
            this.OperationsPanel.Controls.Add(this.SubtractionBtn);
            this.OperationsPanel.Controls.Add(this.SquareBtn);
            this.OperationsPanel.Controls.Add(this.MultiplicationBtn);
            this.OperationsPanel.Controls.Add(this.RootBtn);
            this.OperationsPanel.Controls.Add(this.AndBtn);
            this.OperationsPanel.Controls.Add(this.OrBtn);
            this.OperationsPanel.Controls.Add(this.DivisionByModuleBtn);
            this.OperationsPanel.Controls.Add(this.FactorialBtn);
            this.OperationsPanel.Location = new System.Drawing.Point(37, 131);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(519, 132);
            this.OperationsPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 272);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Supercomplex calculator (rem)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OperationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ExponentiationBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RootBtn;
        private System.Windows.Forms.Button FactorialBtn;
        private System.Windows.Forms.Button DivisionByModuleBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button SubtractionBtn;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button XorBtn;
        private System.Windows.Forms.Button OrBtn;
        private System.Windows.Forms.Button AndBtn;
        private System.Windows.Forms.Panel OperationsPanel;
    }
}

