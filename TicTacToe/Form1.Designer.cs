﻿namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ai_win_label = new System.Windows.Forms.Label();
            this.player_win_label = new System.Windows.Forms.Label();
            this.draw_label = new System.Windows.Forms.Label();
            this.ai_win_num = new System.Windows.Forms.Label();
            this.player_win_num = new System.Windows.Forms.Label();
            this.draw_num = new System.Windows.Forms.Label();
            this.Algorithm_label = new System.Windows.Forms.Label();
            this.Algorithm_Val = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.algorithmToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(155, 32);
            this.newGameToolStripMenuItem.Text = "Start New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniMaxToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // miniMaxToolStripMenuItem
            // 
            this.miniMaxToolStripMenuItem.Name = "miniMaxToolStripMenuItem";
            this.miniMaxToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.miniMaxToolStripMenuItem.Text = "MiniMax (default)";
            this.miniMaxToolStripMenuItem.Click += new System.EventHandler(this.ChangeAlgorithm);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.ChangeAlgorithm);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Control;
            this.button0.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(12, 39);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(144, 144);
            this.button0.TabIndex = 1;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 144);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(312, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 144);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 144);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(162, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 144);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(312, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 144);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 144);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(162, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 144);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Player_Turn);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(312, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 144);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Player_Turn);
            // 
            // ai_win_label
            // 
            this.ai_win_label.AutoSize = true;
            this.ai_win_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ai_win_label.Location = new System.Drawing.Point(462, 177);
            this.ai_win_label.Name = "ai_win_label";
            this.ai_win_label.Size = new System.Drawing.Size(102, 26);
            this.ai_win_label.TabIndex = 12;
            this.ai_win_label.Text = "AI  Wins";
            // 
            // player_win_label
            // 
            this.player_win_label.AutoSize = true;
            this.player_win_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_win_label.Location = new System.Drawing.Point(462, 302);
            this.player_win_label.Name = "player_win_label";
            this.player_win_label.Size = new System.Drawing.Size(140, 26);
            this.player_win_label.TabIndex = 13;
            this.player_win_label.Text = "Player Wins";
            // 
            // draw_label
            // 
            this.draw_label.AutoSize = true;
            this.draw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_label.Location = new System.Drawing.Point(462, 419);
            this.draw_label.Name = "draw_label";
            this.draw_label.Size = new System.Drawing.Size(79, 26);
            this.draw_label.TabIndex = 14;
            this.draw_label.Text = "Draws";
            // 
            // ai_win_num
            // 
            this.ai_win_num.AutoSize = true;
            this.ai_win_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ai_win_num.Location = new System.Drawing.Point(462, 206);
            this.ai_win_num.Name = "ai_win_num";
            this.ai_win_num.Size = new System.Drawing.Size(25, 26);
            this.ai_win_num.TabIndex = 15;
            this.ai_win_num.Text = "0";
            this.ai_win_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_win_num
            // 
            this.player_win_num.AutoSize = true;
            this.player_win_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_win_num.Location = new System.Drawing.Point(462, 333);
            this.player_win_num.Name = "player_win_num";
            this.player_win_num.Size = new System.Drawing.Size(25, 26);
            this.player_win_num.TabIndex = 16;
            this.player_win_num.Text = "0";
            this.player_win_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draw_num
            // 
            this.draw_num.AutoSize = true;
            this.draw_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_num.Location = new System.Drawing.Point(462, 449);
            this.draw_num.Name = "draw_num";
            this.draw_num.Size = new System.Drawing.Size(25, 26);
            this.draw_num.TabIndex = 17;
            this.draw_num.Text = "0";
            this.draw_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Algorithm_label
            // 
            this.Algorithm_label.AutoSize = true;
            this.Algorithm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm_label.Location = new System.Drawing.Point(462, 39);
            this.Algorithm_label.Name = "Algorithm_label";
            this.Algorithm_label.Size = new System.Drawing.Size(114, 52);
            this.Algorithm_label.TabIndex = 18;
            this.Algorithm_label.Text = "Current\r\nAlgorithm\r\n";
            // 
            // Algorithm_Val
            // 
            this.Algorithm_Val.AutoSize = true;
            this.Algorithm_Val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm_Val.Location = new System.Drawing.Point(467, 97);
            this.Algorithm_Val.Name = "Algorithm_Val";
            this.Algorithm_Val.Size = new System.Drawing.Size(0, 26);
            this.Algorithm_Val.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 497);
            this.Controls.Add(this.Algorithm_Val);
            this.Controls.Add(this.Algorithm_label);
            this.Controls.Add(this.draw_num);
            this.Controls.Add(this.player_win_num);
            this.Controls.Add(this.ai_win_num);
            this.Controls.Add(this.draw_label);
            this.Controls.Add(this.player_win_label);
            this.Controls.Add(this.ai_win_label);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label ai_win_label;
        private System.Windows.Forms.Label player_win_label;
        private System.Windows.Forms.Label draw_label;
        private System.Windows.Forms.Label ai_win_num;
        private System.Windows.Forms.Label player_win_num;
        private System.Windows.Forms.Label draw_num;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.Label Algorithm_label;
        private System.Windows.Forms.Label Algorithm_Val;
    }
}

