using System;
using System.Windows.Forms;

namespace GameRace
{
    partial class TractorRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TractorRace));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Tractor1 = new System.Windows.Forms.PictureBox();
            this.tractor4 = new System.Windows.Forms.PictureBox();
            this.tractor3 = new System.Windows.Forms.PictureBox();
            this.tractor2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radiobutton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tractor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(41, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(724, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(41, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(724, 10);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(41, 215);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(724, 10);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // Tractor1
            // 
            this.Tractor1.BackColor = System.Drawing.Color.Transparent;
            this.Tractor1.Image = ((System.Drawing.Image)(resources.GetObject("Tractor1.Image")));
            this.Tractor1.Location = new System.Drawing.Point(41, 12);
            this.Tractor1.Name = "Tractor1";
            this.Tractor1.Size = new System.Drawing.Size(84, 55);
            this.Tractor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tractor1.TabIndex = 2;
            this.Tractor1.TabStop = false;
            this.Tractor1.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // tractor4
            // 
            this.tractor4.BackColor = System.Drawing.Color.Transparent;
            this.tractor4.Image = ((System.Drawing.Image)(resources.GetObject("tractor4.Image")));
            this.tractor4.Location = new System.Drawing.Point(41, 231);
            this.tractor4.Name = "tractor4";
            this.tractor4.Size = new System.Drawing.Size(84, 55);
            this.tractor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tractor4.TabIndex = 2;
            this.tractor4.TabStop = false;
            this.tractor4.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // tractor3
            // 
            this.tractor3.BackColor = System.Drawing.Color.Transparent;
            this.tractor3.Image = ((System.Drawing.Image)(resources.GetObject("tractor3.Image")));
            this.tractor3.Location = new System.Drawing.Point(41, 159);
            this.tractor3.Name = "tractor3";
            this.tractor3.Size = new System.Drawing.Size(84, 55);
            this.tractor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tractor3.TabIndex = 2;
            this.tractor3.TabStop = false;
            this.tractor3.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // tractor2
            // 
            this.tractor2.BackColor = System.Drawing.Color.Transparent;
            this.tractor2.Image = ((System.Drawing.Image)(resources.GetObject("tractor2.Image")));
            this.tractor2.Location = new System.Drawing.Point(41, 89);
            this.tractor2.Name = "tractor2";
            this.tractor2.Size = new System.Drawing.Size(84, 55);
            this.tractor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tractor2.TabIndex = 2;
            this.tractor2.TabStop = false;
            this.tractor2.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblWinner);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.radiobutton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(41, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 134);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(305, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(456, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(252, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(456, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 20);
            this.textBox4.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(168, 10);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(35, 13);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "label5";
            this.lblWinner.Click += new System.EventHandler(this.lblWinner_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "On Which Tractor Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bettor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(305, 83);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // radiobutton3
            // 
            this.radiobutton3.AutoSize = true;
            this.radiobutton3.Location = new System.Drawing.Point(26, 92);
            this.radiobutton3.Name = "radiobutton3";
            this.radiobutton3.Size = new System.Drawing.Size(75, 17);
            this.radiobutton3.TabIndex = 5;
            this.radiobutton3.TabStop = true;
            this.radiobutton3.Text = "Anil Kumar";
            this.radiobutton3.UseVisualStyleBackColor = true;
            this.radiobutton3.CheckedChanged += new System.EventHandler(this.radioButton3);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Gaganpreet Singh";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Harmanpreet Singh";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Place Bet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Race";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(635, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TractorRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tractor2);
            this.Controls.Add(this.tractor3);
            this.Controls.Add(this.tractor4);
            this.Controls.Add(this.Tractor1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TractorRace";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.radioButton1_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tractor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractor2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Tractor1;
        private System.Windows.Forms.PictureBox tractor4;
        private System.Windows.Forms.PictureBox tractor3;
        private System.Windows.Forms.PictureBox tractor2;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radiobutton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblWinner;
        private TextBox textBox5;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private Timer timer1;
        private Timer timer2;
    }
}

