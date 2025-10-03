namespace EuclidesModern
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
            valueB = new TextBox();
            label2 = new Label();
            valueA = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            result = new TextBox();
            label3 = new Label();
            calculate = new Button();
            clear = new Button();
            Ostatnie = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(valueB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(valueA);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podane wartości";
            // 
            // valueB
            // 
            valueB.Location = new Point(6, 81);
            valueB.Name = "valueB";
            valueB.Size = new Size(130, 23);
            valueB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Liczba B";
            // 
            // valueA
            // 
            valueA.Location = new Point(6, 37);
            valueA.Name = "valueA";
            valueA.Size = new Size(130, 23);
            valueA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Liczba A";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(result);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(164, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(148, 68);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wynik";
            // 
            // result
            // 
            result.Location = new Point(6, 37);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(136, 23);
            result.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "NWD";
            // 
            // calculate
            // 
            calculate.Location = new Point(164, 78);
            calculate.Name = "calculate";
            calculate.Size = new Size(148, 23);
            calculate.TabIndex = 2;
            calculate.Text = "Oblicz NWD";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // clear
            // 
            clear.Location = new Point(164, 101);
            clear.Name = "clear";
            clear.Size = new Size(148, 23);
            clear.TabIndex = 3;
            clear.Text = "Wyczyść";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Ostatnie
            // 
            Ostatnie.ColumnWidth = 147;
            Ostatnie.FormattingEnabled = true;
            Ostatnie.Location = new Point(12, 130);
            Ostatnie.MultiColumn = true;
            Ostatnie.Name = "Ostatnie";
            Ostatnie.SelectionMode = SelectionMode.None;
            Ostatnie.Size = new Size(294, 109);
            Ostatnie.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 250);
            Controls.Add(Ostatnie);
            Controls.Add(clear);
            Controls.Add(calculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(339, 289);
            MinimumSize = new Size(339, 289);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox valueB;
        private Label label2;
        private TextBox valueA;
        private GroupBox groupBox2;
        private TextBox result;
        private Label label3;
        private Button calculate;
        private Button clear;
        private ListBox Ostatnie;
    }
}
