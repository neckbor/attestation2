namespace _1._9._4_form_
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(68, 69);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(385, 300);
            this.gridView.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(288, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(216, 39);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Обработать данные";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InpBtn
            // 
            this.InpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InpBtn.Location = new System.Drawing.Point(12, 12);
            this.InpBtn.Name = "InpBtn";
            this.InpBtn.Size = new System.Drawing.Size(216, 39);
            this.InpBtn.TabIndex = 3;
            this.InpBtn.Text = "Считать данные";
            this.InpBtn.UseVisualStyleBackColor = true;
            this.InpBtn.Click += new System.EventHandler(this.InpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 407);
            this.Controls.Add(this.InpBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.gridView);
            this.Name = "Form1";
            this.Text = "Раздел 9 номер 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button InpBtn;
    }
}

