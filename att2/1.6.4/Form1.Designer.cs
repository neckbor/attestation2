namespace _1._6._4
{
    partial class Block6Task4
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.LblStrInp = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.GroupBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.Input.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Controls.Add(this.StartBtn);
            this.Input.Controls.Add(this.InputText);
            this.Input.Controls.Add(this.LblStrInp);
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(446, 157);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            this.Input.Text = "Входные данные";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(115, 126);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(217, 25);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Переделать строку";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(6, 65);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(431, 20);
            this.InputText.TabIndex = 1;
            // 
            // LblStrInp
            // 
            this.LblStrInp.AutoSize = true;
            this.LblStrInp.Location = new System.Drawing.Point(6, 37);
            this.LblStrInp.Name = "LblStrInp";
            this.LblStrInp.Size = new System.Drawing.Size(43, 13);
            this.LblStrInp.TabIndex = 0;
            this.LblStrInp.Text = "Строка";
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Controls.Add(this.ResultText);
            this.Result.Location = new System.Drawing.Point(12, 169);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(446, 159);
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            this.Result.Text = "Результат";
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.Location = new System.Drawing.Point(6, 36);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(431, 20);
            this.ResultText.TabIndex = 0;
            // 
            // Block6Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 333);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Name = "Block6Task4";
            this.Text = "Раздел 6 номер 4";
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label LblStrInp;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.TextBox ResultText;
    }
}

