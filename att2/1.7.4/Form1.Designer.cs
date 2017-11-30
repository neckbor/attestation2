namespace _1._7._4
{
    partial class Task1Block7
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
            this.Input = new System.Windows.Forms.GroupBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.ArrInp = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.GroupBox();
            this.ResultLable = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.Input.SuspendLayout();
            this.Result.SuspendLayout();
            this.MainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Controls.Add(this.StartBtn);
            this.Input.Controls.Add(this.ArrInput);
            this.Input.Controls.Add(this.ArrInp);
            this.Input.Location = new System.Drawing.Point(12, 6);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(469, 161);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            this.Input.Text = "Входные данные";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(145, 105);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(192, 40);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Рассчитать произведение";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ArrInput
            // 
            this.ArrInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrInput.Location = new System.Drawing.Point(6, 44);
            this.ArrInput.Multiline = true;
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(457, 48);
            this.ArrInput.TabIndex = 1;
            // 
            // ArrInp
            // 
            this.ArrInp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrInp.AutoSize = true;
            this.ArrInp.Location = new System.Drawing.Point(6, 27);
            this.ArrInp.Name = "ArrInp";
            this.ArrInp.Size = new System.Drawing.Size(90, 13);
            this.ArrInp.TabIndex = 0;
            this.ArrInp.Text = "Введите массив";
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Controls.Add(this.ResultLable);
            this.Result.Controls.Add(this.ResultText);
            this.Result.Location = new System.Drawing.Point(12, 174);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(469, 94);
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            this.Result.Text = "Результат";
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Location = new System.Drawing.Point(9, 20);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(365, 13);
            this.ResultLable.TabIndex = 1;
            this.ResultLable.Text = "Произведение нечетных элементов, имеющих четные индексы равно:";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(12, 36);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(127, 20);
            this.ResultText.TabIndex = 0;
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.Result);
            this.MainBox.Controls.Add(this.Input);
            this.MainBox.Location = new System.Drawing.Point(12, 12);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(492, 381);
            this.MainBox.TabIndex = 2;
            this.MainBox.TabStop = false;
            // 
            // Task1Block7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 411);
            this.Controls.Add(this.MainBox);
            this.Name = "Task1Block7";
            this.Text = "Раздел 7 номер 4";
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.MainBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label ArrInp;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.GroupBox MainBox;
    }
}

