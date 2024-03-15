namespace WinForms
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
            runButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numberOfItemsBox = new TextBox();
            seedBox = new TextBox();
            capacityBox = new TextBox();
            resultBox = new TextBox();
            problemBox = new TextBox();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.Location = new Point(39, 200);
            runButton.Name = "runButton";
            runButton.Size = new Size(75, 23);
            runButton.TabIndex = 0;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Capacity";
            // 
            // numberOfItemsBox
            // 
            numberOfItemsBox.Location = new Point(39, 33);
            numberOfItemsBox.Name = "numberOfItemsBox";
            numberOfItemsBox.Size = new Size(100, 23);
            numberOfItemsBox.TabIndex = 4;
            numberOfItemsBox.TextAlign = HorizontalAlignment.Right;
            // 
            // seedBox
            // 
            seedBox.Location = new Point(39, 89);
            seedBox.Name = "seedBox";
            seedBox.Size = new Size(100, 23);
            seedBox.TabIndex = 5;
            seedBox.TextAlign = HorizontalAlignment.Right;
            // 
            // capacityBox
            // 
            capacityBox.Location = new Point(39, 148);
            capacityBox.Name = "capacityBox";
            capacityBox.Size = new Size(100, 23);
            capacityBox.TabIndex = 6;
            capacityBox.TextAlign = HorizontalAlignment.Right;
            // 
            // resultBox
            // 
            resultBox.AcceptsReturn = true;
            resultBox.Location = new Point(39, 260);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(140, 150);
            resultBox.TabIndex = 7;
            // 
            // problemBox
            // 
            problemBox.AcceptsReturn = true;
            problemBox.Location = new Point(383, 15);
            problemBox.Multiline = true;
            problemBox.Name = "problemBox";
            problemBox.ReadOnly = true;
            problemBox.Size = new Size(357, 395);
            problemBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(problemBox);
            Controls.Add(resultBox);
            Controls.Add(capacityBox);
            Controls.Add(seedBox);
            Controls.Add(numberOfItemsBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button runButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numberOfItemsBox;
        private TextBox seedBox;
        private TextBox capacityBox;
        private TextBox resultBox;
        private TextBox problemBox;
    }
}
