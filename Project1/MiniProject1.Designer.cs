﻿namespace Project1
{
    partial class MiniProject1
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(12, 13);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ShortcutsEnabled = false;
            this.txtResult.Size = new System.Drawing.Size(318, 36);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Tag = "0";
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 58);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 62);
            this.btn7.TabIndex = 1;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(93, 58);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 62);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(174, 58);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 62);
            this.btn9.TabIndex = 3;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(255, 58);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 62);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Tag = "4";
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(255, 126);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 62);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Tag = "3";
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(174, 126);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 62);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(93, 126);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 62);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 126);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 62);
            this.btn4.TabIndex = 5;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(255, 194);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 62);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Tag = "2";
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(174, 194);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 62);
            this.btn3.TabIndex = 11;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 194);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 62);
            this.btn2.TabIndex = 10;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 194);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 62);
            this.btn1.TabIndex = 9;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(255, 262);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 62);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Tag = "1";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(174, 262);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 62);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Tag = "0";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 62);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(12, 262);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 62);
            this.btnNum.TabIndex = 13;
            this.btnNum.Tag = "0";
            this.btnNum.Text = "0";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // MiniProject1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 332);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.Name = "MiniProject1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDiv;
        private Button btnMulti;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMinus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnClear;
        private Button btnNum;
    }
}