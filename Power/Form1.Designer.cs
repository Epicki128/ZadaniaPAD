namespace Power
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
            groupBox1 = new GroupBox();
            input = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            CTAloop = new Button();
            CTArecurention = new Button();
            label2 = new Label();
            label3 = new Label();
            resultOutput = new TextBox();
            resetBtn = new Button();
            stepsCount = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane";
            // 
            // input
            // 
            input.Location = new Point(6, 37);
            input.Name = "input";
            input.Size = new Size(133, 23);
            input.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Liczba";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CTAloop);
            groupBox2.Controls.Add(CTArecurention);
            groupBox2.Location = new Point(163, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oblicz silnię liczby metodą:";
            // 
            // CTAloop
            // 
            CTAloop.Location = new Point(6, 51);
            CTAloop.Name = "CTAloop";
            CTAloop.Size = new Size(158, 22);
            CTAloop.TabIndex = 1;
            CTAloop.Text = "Pętli";
            CTAloop.UseVisualStyleBackColor = true;
            CTAloop.Click += CTAloop_Click;
            // 
            // CTArecurention
            // 
            CTArecurention.Location = new Point(6, 22);
            CTArecurention.Name = "CTArecurention";
            CTArecurention.Size = new Size(158, 23);
            CTArecurention.TabIndex = 0;
            CTArecurention.Text = "Rekurencji";
            CTArecurention.UseVisualStyleBackColor = true;
            CTArecurention.Click += CTArecurention_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Liczba kroków";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Wynik";
            // 
            // resultOutput
            // 
            resultOutput.Location = new Point(12, 112);
            resultOutput.Name = "resultOutput";
            resultOutput.Size = new Size(145, 23);
            resultOutput.TabIndex = 5;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(12, 141);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(321, 23);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Wyczyść";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // stepsCount
            // 
            stepsCount.Location = new Point(163, 112);
            stepsCount.Name = "stepsCount";
            stepsCount.Size = new Size(171, 23);
            stepsCount.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 173);
            Controls.Add(stepsCount);
            Controls.Add(resetBtn);
            Controls.Add(resultOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(362, 212);
            MinimumSize = new Size(362, 212);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox input;
        private GroupBox groupBox2;
        private Button CTAloop;
        private Button CTArecurention;
        private Label label2;
        private Label label3;
        private TextBox resultOutput;
        private Button resetBtn;
        private TextBox stepsCount;
    }
}
