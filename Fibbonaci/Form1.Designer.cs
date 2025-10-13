namespace Fibbonaci
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
            Number = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            time = new TextBox();
            label4 = new Label();
            Steps = new TextBox();
            label3 = new Label();
            resultFib = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            Loop = new Button();
            Recurention = new Button();
            Clear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Number);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane";
            // 
            // Number
            // 
            Number.Location = new Point(6, 37);
            Number.Name = "Number";
            Number.Size = new Size(188, 23);
            Number.TabIndex = 1;
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
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Steps);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(resultFib);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(218, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wynik";
            // 
            // time
            // 
            time.Location = new Point(6, 125);
            time.Name = "time";
            time.ReadOnly = true;
            time.Size = new Size(188, 23);
            time.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Czas";
            // 
            // Steps
            // 
            Steps.Location = new Point(6, 81);
            Steps.Name = "Steps";
            Steps.ReadOnly = true;
            Steps.Size = new Size(188, 23);
            Steps.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Liczba kroków";
            // 
            // resultFib
            // 
            resultFib.Location = new Point(6, 37);
            resultFib.Name = "resultFib";
            resultFib.ReadOnly = true;
            resultFib.Size = new Size(188, 23);
            resultFib.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Fibbonaci";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Loop);
            groupBox3.Controls.Add(Recurention);
            groupBox3.Location = new Point(12, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 47);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Oblicz";
            // 
            // Loop
            // 
            Loop.Location = new Point(103, 16);
            Loop.Name = "Loop";
            Loop.Size = new Size(91, 23);
            Loop.TabIndex = 1;
            Loop.Text = "Pętlą";
            Loop.UseVisualStyleBackColor = true;
            Loop.Click += Btn;
            // 
            // Recurention
            // 
            Recurention.Location = new Point(6, 16);
            Recurention.Name = "Recurention";
            Recurention.Size = new Size(91, 23);
            Recurention.TabIndex = 0;
            Recurention.Text = "Rekurencją";
            Recurention.UseVisualStyleBackColor = true;
            Recurention.Click += Btn;
            // 
            // Clear
            // 
            Clear.Location = new Point(12, 140);
            Clear.Name = "Clear";
            Clear.Size = new Size(200, 23);
            Clear.TabIndex = 3;
            Clear.Text = "Wyczyść";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 176);
            Controls.Add(Clear);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(443, 215);
            MinimumSize = new Size(443, 215);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Number;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox resultFib;
        private Label label2;
        private TextBox Steps;
        private GroupBox groupBox3;
        private Button Loop;
        private Button Recurention;
        private Button Clear;
        private TextBox time;
        private Label label4;
    }
}
