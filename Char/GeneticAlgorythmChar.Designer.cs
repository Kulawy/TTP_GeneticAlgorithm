namespace Char
{
    partial class GeneticAlgorythmChar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start_button = new System.Windows.Forms.Button();
            this.MaxValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PopCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenSize = new System.Windows.Forms.Label();
            this.MutRatio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CrossRatio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "max";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "min";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "avg";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1188, 486);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(12, 504);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(96, 59);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // MaxValue
            // 
            this.MaxValue.AutoSize = true;
            this.MaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaxValue.Location = new System.Drawing.Point(264, 504);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(18, 20);
            this.MaxValue.TabIndex = 2;
            this.MaxValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(114, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Best Max Value: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(929, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "population count:";
            // 
            // PopCount
            // 
            this.PopCount.AutoSize = true;
            this.PopCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PopCount.Location = new System.Drawing.Point(1051, 502);
            this.PopCount.Name = "PopCount";
            this.PopCount.Size = new System.Drawing.Size(13, 13);
            this.PopCount.TabIndex = 5;
            this.PopCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(929, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "generation size:";
            // 
            // GenSize
            // 
            this.GenSize.AutoSize = true;
            this.GenSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenSize.Location = new System.Drawing.Point(1051, 518);
            this.GenSize.Name = "GenSize";
            this.GenSize.Size = new System.Drawing.Size(13, 13);
            this.GenSize.TabIndex = 7;
            this.GenSize.Text = "0";
            // 
            // MutRatio
            // 
            this.MutRatio.AutoSize = true;
            this.MutRatio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MutRatio.Location = new System.Drawing.Point(1052, 535);
            this.MutRatio.Name = "MutRatio";
            this.MutRatio.Size = new System.Drawing.Size(13, 13);
            this.MutRatio.TabIndex = 8;
            this.MutRatio.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(929, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "mutate ratio";
            // 
            // CrossRatio
            // 
            this.CrossRatio.AutoSize = true;
            this.CrossRatio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CrossRatio.Location = new System.Drawing.Point(1052, 552);
            this.CrossRatio.Name = "CrossRatio";
            this.CrossRatio.Size = new System.Drawing.Size(13, 13);
            this.CrossRatio.TabIndex = 8;
            this.CrossRatio.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(929, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "cross ratio";
            // 
            // GeneticAlgorythmChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1212, 575);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CrossRatio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MutRatio);
            this.Controls.Add(this.GenSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PopCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.chart1);
            this.Name = "GeneticAlgorythmChar";
            this.Text = "Genetic";
            this.Load += new System.EventHandler(this.GeneticAlgorythmChar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label MaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PopCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GenSize;
        private System.Windows.Forms.Label MutRatio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CrossRatio;
        private System.Windows.Forms.Label label9;
    }
}

