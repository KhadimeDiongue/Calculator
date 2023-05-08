
namespace Calc
{
    partial class CalculatorForm
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
            this.NumberOneTextBox = new System.Windows.Forms.TextBox();
            this.NumberTwoTextBox = new System.Windows.Forms.TextBox();
            this.NumberOneLabel = new System.Windows.Forms.Label();
            this.NumberTwoLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.dividebutton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // NumberOneTextBox
            // 
            this.NumberOneTextBox.Location = new System.Drawing.Point(158, 52);
            this.NumberOneTextBox.Name = "NumberOneTextBox";
            this.NumberOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOneTextBox.TabIndex = 0;
            // 
            // NumberTwoTextBox
            // 
            this.NumberTwoTextBox.Location = new System.Drawing.Point(158, 101);
            this.NumberTwoTextBox.Name = "NumberTwoTextBox";
            this.NumberTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTwoTextBox.TabIndex = 1;
            // 
            // NumberOneLabel
            // 
            this.NumberOneLabel.AutoSize = true;
            this.NumberOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOneLabel.Location = new System.Drawing.Point(58, 55);
            this.NumberOneLabel.Name = "NumberOneLabel";
            this.NumberOneLabel.Size = new System.Drawing.Size(95, 13);
            this.NumberOneLabel.TabIndex = 2;
            this.NumberOneLabel.Text = "Enter Number 1";
            // 
            // NumberTwoLabel
            // 
            this.NumberTwoLabel.AutoSize = true;
            this.NumberTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTwoLabel.Location = new System.Drawing.Point(58, 101);
            this.NumberTwoLabel.Name = "NumberTwoLabel";
            this.NumberTwoLabel.Size = new System.Drawing.Size(93, 13);
            this.NumberTwoLabel.TabIndex = 3;
            this.NumberTwoLabel.Text = "Enter number 2";
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(128, 208);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(61, 49);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(58, 151);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(48, 13);
            this.AnswerLabel.TabIndex = 5;
            this.AnswerLabel.Text = "Answer";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(158, 151);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerTextBox.TabIndex = 6;
            // 
            // dividebutton
            // 
            this.dividebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebutton.Location = new System.Drawing.Point(128, 263);
            this.dividebutton.Name = "dividebutton";
            this.dividebutton.Size = new System.Drawing.Size(61, 49);
            this.dividebutton.TabIndex = 7;
            this.dividebutton.Text = "/";
            this.dividebutton.UseVisualStyleBackColor = true;
            this.dividebutton.Click += new System.EventHandler(this.dividebutton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(61, 263);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(61, 49);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(61, 208);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(61, 49);
            this.PlusButton.TabIndex = 9;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(195, 208);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(63, 104);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(312, 345);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.dividebutton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.NumberTwoLabel);
            this.Controls.Add(this.NumberOneLabel);
            this.Controls.Add(this.NumberTwoTextBox);
            this.Controls.Add(this.NumberOneTextBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOneTextBox;
        private System.Windows.Forms.TextBox NumberTwoTextBox;
        private System.Windows.Forms.Label NumberOneLabel;
        private System.Windows.Forms.Label NumberTwoLabel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button dividebutton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

