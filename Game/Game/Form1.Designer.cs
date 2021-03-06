﻿namespace Game
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameFieldGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.gameFieldGrid.Location = new System.Drawing.Point(13, 13);
            this.gameFieldGrid.MultiSelect = false;
            this.gameFieldGrid.Name = "gameFieldGrid";
            this.gameFieldGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gameFieldGrid.Size = new System.Drawing.Size(240, 150);
            this.gameFieldGrid.TabIndex = 0;
            this.gameFieldGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameFieldGrid_CellClick);
            this.gameFieldGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gameFieldGrid_CellPainting);
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeProgressBar.Location = new System.Drawing.Point(12, 260);
            this.timeProgressBar.MarqueeAnimationSpeed = 200;
            this.timeProgressBar.Maximum = 10;
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(400, 10);
            this.timeProgressBar.Step = 1;
            this.timeProgressBar.TabIndex = 1;
            this.timeProgressBar.Value = 5;
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

