namespace _2._7._4
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
            this.InpGroupBox = new System.Windows.Forms.GroupBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.InpGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InpGroupBox
            // 
            this.InpGroupBox.Controls.Add(this.StartBtn);
            this.InpGroupBox.Controls.Add(this.InputText);
            this.InpGroupBox.Location = new System.Drawing.Point(13, 13);
            this.InpGroupBox.Name = "InpGroupBox";
            this.InpGroupBox.Size = new System.Drawing.Size(259, 119);
            this.InpGroupBox.TabIndex = 0;
            this.InpGroupBox.TabStop = false;
            this.InpGroupBox.Text = "Введите массив";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(7, 32);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(246, 20);
            this.InputText.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(55, 71);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(143, 32);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Обработать массив";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultText);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Максимальное количество одинаковых элементов";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(6, 32);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(111, 20);
            this.ResultText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InpGroupBox);
            this.Name = "Form1";
            this.Text = "Раздел 7 номер 35";
            this.InpGroupBox.ResumeLayout(false);
            this.InpGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InpGroupBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ResultText;
    }
}

