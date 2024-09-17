namespace TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            labelKoniecGry = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(93, 118);
            button1.Name = "button1";
            button1.Size = new Size(110, 110);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(209, 118);
            button2.Name = "button2";
            button2.Size = new Size(110, 110);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(325, 118);
            button3.Name = "button3";
            button3.Size = new Size(110, 110);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(93, 234);
            button4.Name = "button4";
            button4.Size = new Size(110, 110);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.Location = new Point(209, 234);
            button5.Name = "button5";
            button5.Size = new Size(110, 110);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button6.Location = new Point(325, 234);
            button6.Name = "button6";
            button6.Size = new Size(110, 110);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button7.Location = new Point(93, 350);
            button7.Name = "button7";
            button7.Size = new Size(110, 110);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button8.Location = new Point(209, 350);
            button8.Name = "button8";
            button8.Size = new Size(110, 110);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button9.Location = new Point(325, 350);
            button9.Name = "button9";
            button9.Size = new Size(110, 110);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // labelKoniecGry
            // 
            labelKoniecGry.AutoSize = true;
            labelKoniecGry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelKoniecGry.Location = new Point(181, 39);
            labelKoniecGry.Name = "labelKoniecGry";
            labelKoniecGry.Size = new Size(169, 45);
            labelKoniecGry.TabIndex = 9;
            labelKoniecGry.Text = "Koniec gry";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 494);
            Controls.Add(labelKoniecGry);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(550, 550);
            MinimumSize = new Size(550, 550);
            Name = "Form1";
            Text = "Kółko i Krzyżyk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label labelKoniecGry;
    }
}
