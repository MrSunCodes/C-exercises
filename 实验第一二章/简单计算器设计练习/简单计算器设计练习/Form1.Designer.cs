namespace 简单计算器设计练习
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qumo = new System.Windows.Forms.RadioButton();
            this.divide = new System.Windows.Forms.RadioButton();
            this.mutplait = new System.Windows.Forms.RadioButton();
            this.substraction = new System.Windows.Forms.RadioButton();
            this.plus = new System.Windows.Forms.RadioButton();
            this.Method = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symbol = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Method.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择运算类型";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.qumo);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.mutplait);
            this.panel1.Controls.Add(this.substraction);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Location = new System.Drawing.Point(29, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // qumo
            // 
            this.qumo.AutoSize = true;
            this.qumo.Location = new System.Drawing.Point(569, 25);
            this.qumo.Name = "qumo";
            this.qumo.Size = new System.Drawing.Size(58, 19);
            this.qumo.TabIndex = 2;
            this.qumo.TabStop = true;
            this.qumo.Text = "取模";
            this.qumo.UseVisualStyleBackColor = true;
            this.qumo.CheckedChanged += new System.EventHandler(this.Yu_CheckedChanged);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(446, 25);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 19);
            this.divide.TabIndex = 3;
            this.divide.TabStop = true;
            this.divide.Text = "除法";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.CheckedChanged += new System.EventHandler(this.Chu_CheckedChanged);
            // 
            // mutplait
            // 
            this.mutplait.AutoSize = true;
            this.mutplait.Location = new System.Drawing.Point(307, 25);
            this.mutplait.Name = "mutplait";
            this.mutplait.Size = new System.Drawing.Size(58, 19);
            this.mutplait.TabIndex = 2;
            this.mutplait.TabStop = true;
            this.mutplait.Text = "乘法";
            this.mutplait.UseVisualStyleBackColor = true;
            this.mutplait.CheckedChanged += new System.EventHandler(this.Cheng_CheckedChanged);
            // 
            // substraction
            // 
            this.substraction.AutoSize = true;
            this.substraction.Location = new System.Drawing.Point(160, 25);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(58, 19);
            this.substraction.TabIndex = 1;
            this.substraction.TabStop = true;
            this.substraction.Text = "减法";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.CheckedChanged += new System.EventHandler(this.Jian_CheckedChanged);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(34, 25);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 19);
            this.plus.TabIndex = 0;
            this.plus.TabStop = true;
            this.plus.Text = "加法";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.CheckedChanged += new System.EventHandler(this.Jia_CheckedChanged);
            // 
            // Method
            // 
            this.Method.Controls.Add(this.label1);
            this.Method.Controls.Add(this.symbol);
            this.Method.Controls.Add(this.calculate);
            this.Method.Controls.Add(this.sum);
            this.Method.Controls.Add(this.input2);
            this.Method.Controls.Add(this.input1);
            this.Method.Location = new System.Drawing.Point(28, 220);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(731, 194);
            this.Method.TabIndex = 2;
            this.Method.TabStop = false;
            this.Method.Text = "Method";
            this.Method.Enter += new System.EventHandler(this.Method_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(369, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.symbol.Location = new System.Drawing.Point(184, 86);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(90, 25);
            this.symbol.TabIndex = 4;
            this.symbol.Text = "sysbol";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(589, 83);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(113, 36);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.jisuan_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(433, 86);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(100, 25);
            this.sum.TabIndex = 2;
            this.sum.TextChanged += new System.EventHandler(this.jieguo_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(237, 86);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 25);
            this.input2.TabIndex = 1;
            this.input2.TextChanged += new System.EventHandler(this.dier_TextChanged);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(51, 86);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 25);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.diyi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Method.ResumeLayout(false);
            this.Method.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton qumo;
        private System.Windows.Forms.RadioButton divide;
        private System.Windows.Forms.RadioButton mutplait;
        private System.Windows.Forms.RadioButton substraction;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.GroupBox Method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
    }
}

