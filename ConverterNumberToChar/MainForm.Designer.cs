﻿namespace ConverterNumberToChar
{
    partial class MainForm
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
            displayTextBox = new TextBox();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonStar = new Button();
            buttonZero = new Button();
            buttonHash = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(12, 20);
            displayTextBox.Multiline = true;
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(297, 80);
            displayTextBox.TabIndex = 0;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Segoe UI", 20F);
            buttonOne.Location = new Point(12, 130);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(95, 55);
            buttonOne.TabIndex = 1;
            buttonOne.Tag = "";
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += this.NumberButton_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Segoe UI", 20F);
            buttonTwo.Location = new Point(113, 130);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(95, 55);
            buttonTwo.TabIndex = 2;
            buttonTwo.Tag = "";
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += this.NumberButton_Click;
            // 
            // buttonThree
            // 
            buttonThree.Font = new Font("Segoe UI", 20F);
            buttonThree.Location = new Point(214, 130);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(95, 55);
            buttonThree.TabIndex = 3;
            buttonThree.Tag = "";
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += this.NumberButton_Click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Segoe UI", 20F);
            buttonFour.Location = new Point(12, 191);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(95, 55);
            buttonFour.TabIndex = 4;
            buttonFour.Tag = "";
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += this.NumberButton_Click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Segoe UI", 20F);
            buttonFive.Location = new Point(113, 191);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(95, 55);
            buttonFive.TabIndex = 5;
            buttonFive.Tag = "";
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += this.NumberButton_Click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Segoe UI", 20F);
            buttonSix.Location = new Point(214, 191);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(95, 55);
            buttonSix.TabIndex = 6;
            buttonSix.Tag = "";
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += this.NumberButton_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Segoe UI", 20F);
            buttonSeven.Location = new Point(12, 252);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(95, 55);
            buttonSeven.TabIndex = 7;
            buttonSeven.Tag = "";
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += NumberButton_Click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Segoe UI", 20F);
            buttonEight.Location = new Point(113, 252);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(95, 55);
            buttonEight.TabIndex = 8;
            buttonEight.Tag = "";
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += this.NumberButton_Click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Segoe UI", 20F);
            buttonNine.Location = new Point(214, 252);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(95, 55);
            buttonNine.TabIndex = 9;
            buttonNine.Tag = "";
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += this.NumberButton_Click;
            // 
            // buttonStar
            // 
            buttonStar.Font = new Font("Segoe UI", 20F);
            buttonStar.Location = new Point(12, 313);
            buttonStar.Name = "buttonStar";
            buttonStar.Size = new Size(95, 55);
            buttonStar.TabIndex = 10;
            buttonStar.Tag = "";
            buttonStar.Text = "*";
            buttonStar.UseVisualStyleBackColor = true;
            buttonStar.Click += this.btnStar_Click;
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("Segoe UI", 20F);
            buttonZero.Location = new Point(113, 313);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(95, 55);
            buttonZero.TabIndex = 11;
            buttonZero.Tag = "";
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += this.NumberButton_Click;
            // 
            // buttonHash
            // 
            buttonHash.Font = new Font("Segoe UI", 20F);
            buttonHash.Location = new Point(214, 313);
            buttonHash.Name = "buttonHash";
            buttonHash.Size = new Size(95, 55);
            buttonHash.TabIndex = 12;
            buttonHash.Tag = "";
            buttonHash.Text = "#";
            buttonHash.UseVisualStyleBackColor = true;
            buttonHash.Click += this.btnHash_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 389);
            Controls.Add(buttonHash);
            Controls.Add(buttonZero);
            Controls.Add(buttonStar);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(displayTextBox);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTextBox;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonStar;
        private Button buttonZero;
        private Button buttonHash;
    }
}
