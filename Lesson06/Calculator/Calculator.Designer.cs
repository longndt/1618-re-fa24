namespace Calculator
{
    partial class CalculatorForm
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
            groupBox1 = new GroupBox();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblResult = new Label();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            rbSubtract = new RadioButton();
            rbAdd = new RadioButton();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber2);
            groupBox1.Controls.Add(txtNumber1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(40, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumber2.Location = new Point(165, 128);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(198, 50);
            txtNumber2.TabIndex = 3;
            txtNumber2.TextChanged += textBox2_TextChanged;
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumber1.Location = new Point(165, 58);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(198, 50);
            txtNumber1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(18, 139);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Number 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblResult);
            groupBox2.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(881, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.FromArgb(255, 255, 128);
            lblResult.Font = new Font("Bookman Old Style", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(101, 80);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(68, 61);
            lblResult.TabIndex = 0;
            lblResult.Text = "X";
            lblResult.Click += lblResult_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(rbSubtract);
            groupBox3.Controls.Add(rbAdd);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Roboto Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(481, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(325, 213);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Calculation";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.Green;
            radioButton3.Location = new Point(174, 139);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(109, 30);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Divide";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(25, 141);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(133, 30);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Multiply";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbSubtract
            // 
            rbSubtract.AutoSize = true;
            rbSubtract.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSubtract.ForeColor = Color.Green;
            rbSubtract.Location = new Point(174, 62);
            rbSubtract.Name = "rbSubtract";
            rbSubtract.Size = new Size(133, 30);
            rbSubtract.TabIndex = 2;
            rbSubtract.TabStop = true;
            rbSubtract.Text = "Subtract";
            rbSubtract.UseVisualStyleBackColor = true;
            rbSubtract.CheckedChanged += rbSubtract_CheckedChanged;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAdd.ForeColor = Color.Green;
            rbAdd.Location = new Point(25, 62);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(73, 30);
            rbAdd.TabIndex = 1;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(71, 80);
            label3.Name = "label3";
            label3.Size = new Size(0, 48);
            label3.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 282);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rbSubtract;
        private RadioButton rbAdd;
        private Label label3;
        private Label lblResult;
    }
}
