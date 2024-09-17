namespace TicTacToe
{
    partial class FormApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, oProgramieToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(528, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(115, 29);
            menuToolStripMenuItem.Text = "Zasady gry";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(130, 29);
            oProgramieToolStripMenuItem.Text = "O programie";
            oProgramieToolStripMenuItem.Click += oProgramieToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(140, 205);
            button1.Name = "button1";
            button1.Size = new Size(250, 100);
            button1.TabIndex = 1;
            button1.Text = "Nowa gra dla dwóch graczy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(140, 335);
            button2.Name = "button2";
            button2.Size = new Size(250, 100);
            button2.TabIndex = 2;
            button2.Text = "Nowa gra z komputerem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(109, 76);
            label1.Name = "label1";
            label1.Size = new Size(319, 32);
            label1.TabIndex = 3;
            label1.Text = "Witaj w grze Kółko i Krzyżyk!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(17, 118);
            label2.Name = "label2";
            label2.Size = new Size(494, 32);
            label2.TabIndex = 4;
            label2.Text = "Aby zagrać, wybierz jedną z poniższych opcji:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(109, 108);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 5;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 494);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(550, 550);
            MinimumSize = new Size(550, 550);
            Name = "FormApp";
            Text = "Kółko i Krzyżyk";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}