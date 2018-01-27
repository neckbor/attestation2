namespace Game
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gameFieldGrid = new System.Windows.Forms.DataGridView();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.addLineTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFieldGrid
            // 
            this.gameFieldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameFieldGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameFieldGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.gameFieldGrid.Location = new System.Drawing.Point(13, 13);
            this.gameFieldGrid.MultiSelect = false;
            this.gameFieldGrid.Name = "gameFieldGrid";
            this.gameFieldGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gameFieldGrid.Size = new System.Drawing.Size(240, 150);
            this.gameFieldGrid.TabIndex = 0;
            this.gameFieldGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameFieldGrid_CellClick);
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeProgressBar.Location = new System.Drawing.Point(12, 260);
            this.timeProgressBar.MarqueeAnimationSpeed = 200;
            this.timeProgressBar.Maximum = 15;
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(400, 10);
            this.timeProgressBar.Step = 1;
            this.timeProgressBar.TabIndex = 1;
            this.timeProgressBar.Value = 12;
            // 
            // addLineTimer
            // 
            this.addLineTimer.Interval = 1000;
            this.addLineTimer.Tick += new System.EventHandler(this.addLineTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 282);
            this.Controls.Add(this.timeProgressBar);
            this.Controls.Add(this.gameFieldGrid);
            this.Name = "Form1";
            this.Text = "Тетрис наоборот";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameFieldGrid;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.Timer addLineTimer;
    }
}

