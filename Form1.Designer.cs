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
            this.TwoValuePanel = new System.Windows.Forms.Panel();
            this.OneValuePanel = new System.Windows.Forms.Panel();
            this.LogicalPanel = new System.Windows.Forms.Panel();
            this.OperationsPanel.SuspendLayout();
            this.TwoValuePanel.SuspendLayout();
            this.OneValuePanel.SuspendLayout();
            this.LogicalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(201, 14);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 63);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // ExponentiationBtn
            // 
            this.ExponentiationBtn.Location = new System.Drawing.Point(55, 71);
            this.ExponentiationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExponentiationBtn.Name = "ExponentiationBtn";
            this.ExponentiationBtn.Size = new System.Drawing.Size(50, 32);
            this.ExponentiationBtn.TabIndex = 8;
            this.ExponentiationBtn.Text = "n^m";
            this.ExponentiationBtn.UseVisualStyleBackColor = true;
            this.ExponentiationBtn.Click += new System.EventHandler(this.ExponentiationBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Location = new System.Drawing.Point(2, 74);
            this.SquareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(50, 32);
            this.SquareBtn.TabIndex = 7;
            this.SquareBtn.Text = "n²";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RootBtn
            // 
            this.RootBtn.Location = new System.Drawing.Point(2, 3);
            this.RootBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(50, 32);
            this.RootBtn.TabIndex = 6;
            this.RootBtn.Text = "√";
            this.RootBtn.UseVisualStyleBackColor = true;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // FactorialBtn
            // 
            this.FactorialBtn.Location = new System.Drawing.Point(2, 39);
            this.FactorialBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FactorialBtn.Name = "FactorialBtn";
            this.FactorialBtn.Size = new System.Drawing.Size(50, 32);
            this.FactorialBtn.TabIndex = 5;
            this.FactorialBtn.Text = "n!";
            this.FactorialBtn.UseVisualStyleBackColor = true;
            this.FactorialBtn.Click += new System.EventHandler(this.FactorialBtn_Click);
            // 
            // DivisionByModuleBtn
            // 
            this.DivisionByModuleBtn.Location = new System.Drawing.Point(55, 36);
            this.DivisionByModuleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionByModuleBtn.Name = "DivisionByModuleBtn";
            this.DivisionByModuleBtn.Size = new System.Drawing.Size(50, 32);
            this.DivisionByModuleBtn.TabIndex = 4;
            this.DivisionByModuleBtn.Text = "%";
            this.DivisionByModuleBtn.UseVisualStyleBackColor = true;
            this.DivisionByModuleBtn.Click += new System.EventHandler(this.DivisionByModuleBtn_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Location = new System.Drawing.Point(1, 36);
            this.DivisionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(50, 32);
            this.DivisionBtn.TabIndex = 3;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.Location = new System.Drawing.Point(1, 71);
            this.MultiplicationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(50, 32);
            this.MultiplicationBtn.TabIndex = 2;
            this.MultiplicationBtn.Text = "*";
            this.MultiplicationBtn.UseVisualStyleBackColor = true;
            this.MultiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.Location = new System.Drawing.Point(55, 0);
            this.SubtractionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(50, 32);
            this.SubtractionBtn.TabIndex = 1;
            this.SubtractionBtn.Text = "-";
            this.SubtractionBtn.UseVisualStyleBackColor = true;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Location = new System.Drawing.Point(1, 0);
            this.AdditionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(50, 32);
            this.AdditionBtn.TabIndex = 0;
            this.AdditionBtn.Text = "+";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // XorBtn
            // 
            this.XorBtn.Location = new System.Drawing.Point(0, 71);
            this.XorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XorBtn.Name = "XorBtn";
            this.XorBtn.Size = new System.Drawing.Size(50, 32);
            this.XorBtn.TabIndex = 11;
            this.XorBtn.Text = "XOR";
            this.XorBtn.UseVisualStyleBackColor = true;
            this.XorBtn.Click += new System.EventHandler(this.XorBtn_Click);
            // 
            // OrBtn
            // 
            this.OrBtn.Location = new System.Drawing.Point(0, 36);
            this.OrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OrBtn.Name = "OrBtn";
            this.OrBtn.Size = new System.Drawing.Size(50, 32);
            this.OrBtn.TabIndex = 10;
            this.OrBtn.Text = "OR";
            this.OrBtn.UseVisualStyleBackColor = true;
            this.OrBtn.Click += new System.EventHandler(this.OrBtn_Click);
            // 
            // AndBtn
            // 
            this.AndBtn.Location = new System.Drawing.Point(0, 0);
            this.AndBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AndBtn.Name = "AndBtn";
            this.AndBtn.Size = new System.Drawing.Size(50, 32);
            this.AndBtn.TabIndex = 9;
            this.AndBtn.Text = "AND";
            this.AndBtn.UseVisualStyleBackColor = true;
            this.AndBtn.Click += new System.EventHandler(this.AndBtn_Click);
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.TwoValuePanel);
            this.OperationsPanel.Controls.Add(this.OneValuePanel);
            this.OperationsPanel.Location = new System.Drawing.Point(73, 82);
            this.OperationsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(227, 115);
            this.OperationsPanel.TabIndex = 12;
            // 
            // TwoValuePanel
            // 
            this.TwoValuePanel.Controls.Add(this.LogicalPanel);
            this.TwoValuePanel.Controls.Add(this.DivisionBtn);
            this.TwoValuePanel.Controls.Add(this.ExponentiationBtn);
            this.TwoValuePanel.Controls.Add(this.DivisionByModuleBtn);
            this.TwoValuePanel.Controls.Add(this.AdditionBtn);
            this.TwoValuePanel.Controls.Add(this.MultiplicationBtn);
            this.TwoValuePanel.Controls.Add(this.SubtractionBtn);
            this.TwoValuePanel.Location = new System.Drawing.Point(60, 6);
            this.TwoValuePanel.Name = "TwoValuePanel";
            this.TwoValuePanel.Size = new System.Drawing.Size(161, 103);
            this.TwoValuePanel.TabIndex = 14;
            // 
            // OneValuePanel
            // 
            this.OneValuePanel.Controls.Add(this.RootBtn);
            this.OneValuePanel.Controls.Add(this.FactorialBtn);
            this.OneValuePanel.Controls.Add(this.SquareBtn);
            this.OneValuePanel.Location = new System.Drawing.Point(3, 3);
            this.OneValuePanel.Name = "OneValuePanel";
            this.OneValuePanel.Size = new System.Drawing.Size(55, 107);
            this.OneValuePanel.TabIndex = 13;
            // 
            // LogicalPanel
            // 
            this.LogicalPanel.Controls.Add(this.XorBtn);
            this.LogicalPanel.Controls.Add(this.AndBtn);
            this.LogicalPanel.Controls.Add(this.OrBtn);
            this.LogicalPanel.Location = new System.Drawing.Point(108, 0);
            this.LogicalPanel.Name = "LogicalPanel";
            this.LogicalPanel.Size = new System.Drawing.Size(53, 106);
            this.LogicalPanel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 216);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Supercomplex calculator (rem)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OperationsPanel.ResumeLayout(false);
            this.TwoValuePanel.ResumeLayout(false);
            this.OneValuePanel.ResumeLayout(false);
            this.LogicalPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel OneValuePanel;
        private System.Windows.Forms.Panel TwoValuePanel;
        private System.Windows.Forms.Panel LogicalPanel;
    }
}

