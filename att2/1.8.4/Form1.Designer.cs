namespace _1._8._4
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
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.List1InpLbl = new System.Windows.Forms.Label();
            this.List1Input = new System.Windows.Forms.TextBox();
            this.List2InpLbl = new System.Windows.Forms.Label();
            this.List2Input = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.InputGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.StartBtn);
            this.InputGroup.Controls.Add(this.List2Input);
            this.InputGroup.Controls.Add(this.List2InpLbl);
            this.InputGroup.Controls.Add(this.List1Input);
            this.InputGroup.Controls.Add(this.List1InpLbl);
            this.InputGroup.Location = new System.Drawing.Point(13, 13);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(308, 165);
            this.InputGroup.TabIndex = 0;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "Входные данные";
            // 
            // List1InpLbl
            // 
            this.List1InpLbl.AutoSize = true;
            this.List1InpLbl.Location = new System.Drawing.Point(7, 20);
            this.List1InpLbl.Name = "List1InpLbl";
            this.List1InpLbl.Size = new System.Drawing.Size(129, 13);
            this.List1InpLbl.TabIndex = 0;
            this.List1InpLbl.Text = "Введите первый список";
            // 
            // List1Input
            // 
            this.List1Input.Location = new System.Drawing.Point(10, 37);
            this.List1Input.Name = "List1Input";
            this.List1Input.Size = new System.Drawing.Size(292, 20);
            this.List1Input.TabIndex = 1;
            // 
            // List2InpLbl
            // 
            this.List2InpLbl.AutoSize = true;
            this.List2InpLbl.Location = new System.Drawing.Point(7, 79);
            this.List2InpLbl.Name = "List2InpLbl";
            this.List2InpLbl.Size = new System.Drawing.Size(126, 13);
            this.List2InpLbl.TabIndex = 2;
            this.List2InpLbl.Text = "Введите второй список";
            // 
            // List2Input
            // 
            this.List2Input.Location = new System.Drawing.Point(6, 95);
            this.List2Input.Name = "List2Input";
            this.List2Input.Size = new System.Drawing.Size(295, 20);
            this.List2Input.TabIndex = 3;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(82, 122);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(139, 37);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Обработать списки";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список элементов, которых нет во 2м списке";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(6, 37);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(295, 20);
            this.ResultText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputGroup);
            this.Name = "Form1";
            this.Text = "Раздел 8 номер 4";
            this.InputGroup.ResumeLayout(false);
            this.InputGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox List2Input;
        private System.Windows.Forms.Label List2InpLbl;
        private System.Windows.Forms.TextBox List1Input;
        private System.Windows.Forms.Label List1InpLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label1;
    }
}

