namespace _2._6._4
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
            this.InputX = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.Label();
            this.InputE = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.GroupBox();
            this.InputTextE = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InputTextN = new System.Windows.Forms.TextBox();
            this.InputTextX = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.GroupBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.Input.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputX
            // 
            this.InputX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputX.AutoSize = true;
            this.InputX.Location = new System.Drawing.Point(6, 25);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(112, 13);
            this.InputX.TabIndex = 0;
            this.InputX.Text = "Введите значение X:";
            // 
            // InputN
            // 
            this.InputN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputN.AutoSize = true;
            this.InputN.Location = new System.Drawing.Point(6, 84);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(113, 13);
            this.InputN.TabIndex = 1;
            this.InputN.Text = "Введите значение N:";
            // 
            // InputE
            // 
            this.InputE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputE.AutoSize = true;
            this.InputE.Location = new System.Drawing.Point(6, 141);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(111, 13);
            this.InputE.TabIndex = 2;
            this.InputE.Text = "Введите значение e:";
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Controls.Add(this.InputTextX);
            this.Input.Controls.Add(this.InputTextN);
            this.Input.Controls.Add(this.InputTextE);
            this.Input.Controls.Add(this.StartBtn);
            this.Input.Controls.Add(this.InputE);
            this.Input.Controls.Add(this.InputN);
            this.Input.Controls.Add(this.InputX);
            this.Input.Location = new System.Drawing.Point(9, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(652, 269);
            this.Input.TabIndex = 3;
            this.Input.TabStop = false;
            this.Input.Text = "Входные данные";
            // 
            // InputTextE
            // 
            this.InputTextE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextE.Location = new System.Drawing.Point(6, 157);
            this.InputTextE.Name = "InputTextE";
            this.InputTextE.Size = new System.Drawing.Size(637, 20);
            this.InputTextE.TabIndex = 2;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(214, 208);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(242, 39);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Рассчитать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputTextN
            // 
            this.InputTextN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextN.Location = new System.Drawing.Point(6, 100);
            this.InputTextN.Name = "InputTextN";
            this.InputTextN.Size = new System.Drawing.Size(637, 20);
            this.InputTextN.TabIndex = 1;
            // 
            // InputTextX
            // 
            this.InputTextX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextX.Location = new System.Drawing.Point(6, 41);
            this.InputTextX.Name = "InputTextX";
            this.InputTextX.Size = new System.Drawing.Size(637, 20);
            this.InputTextX.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Controls.Add(this.ResultText);
            this.Result.Location = new System.Drawing.Point(9, 287);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(652, 200);
            this.Result.TabIndex = 0;
            this.Result.TabStop = false;
            this.Result.Text = "Результат";
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.Location = new System.Drawing.Point(9, 24);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(637, 170);
            this.ResultText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 520);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InputX;
        private System.Windows.Forms.Label InputN;
        private System.Windows.Forms.Label InputE;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.TextBox InputTextE;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox InputTextN;
        private System.Windows.Forms.TextBox InputTextX;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.TextBox ResultText;
    }
}

