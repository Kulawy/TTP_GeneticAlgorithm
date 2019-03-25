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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneticAlgorythmChar));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MediumRadioButton2 = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton1 = new System.Windows.Forms.RadioButton();
            this.HardRadioButton3 = new System.Windows.Forms.RadioButton();
            this.HardRadioButton2 = new System.Windows.Forms.RadioButton();
            this.EasyRadioButton3 = new System.Windows.Forms.RadioButton();
            this.EasyRadioButton2 = new System.Windows.Forms.RadioButton();
            this.HardRadioButton1 = new System.Windows.Forms.RadioButton();
            this.EasyRadioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrossingMethod = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MinValue = new System.Windows.Forms.Label();
            this.UniformRadioButton = new System.Windows.Forms.RadioButton();
            this.OX1RadioButton = new System.Windows.Forms.RadioButton();
            this.WorkingGuard1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CrossingMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "max";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "min";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "avg";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1258, 595);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(3, 604);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(96, 48);
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
            this.MaxValue.Location = new System.Drawing.Point(890, 651);
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
            this.label1.Location = new System.Drawing.Point(742, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Best Max Value: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(1063, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "population count:";
            // 
            // PopCount
            // 
            this.PopCount.AutoSize = true;
            this.PopCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PopCount.Location = new System.Drawing.Point(1185, 606);
            this.PopCount.Name = "PopCount";
            this.PopCount.Size = new System.Drawing.Size(13, 13);
            this.PopCount.TabIndex = 5;
            this.PopCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(1063, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "generation size:";
            // 
            // GenSize
            // 
            this.GenSize.AutoSize = true;
            this.GenSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenSize.Location = new System.Drawing.Point(1185, 622);
            this.GenSize.Name = "GenSize";
            this.GenSize.Size = new System.Drawing.Size(13, 13);
            this.GenSize.TabIndex = 7;
            this.GenSize.Text = "0";
            // 
            // MutRatio
            // 
            this.MutRatio.AutoSize = true;
            this.MutRatio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MutRatio.Location = new System.Drawing.Point(1186, 639);
            this.MutRatio.Name = "MutRatio";
            this.MutRatio.Size = new System.Drawing.Size(13, 13);
            this.MutRatio.TabIndex = 8;
            this.MutRatio.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(1063, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "mutate ratio";
            // 
            // CrossRatio
            // 
            this.CrossRatio.AutoSize = true;
            this.CrossRatio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CrossRatio.Location = new System.Drawing.Point(1186, 656);
            this.CrossRatio.Name = "CrossRatio";
            this.CrossRatio.Size = new System.Drawing.Size(13, 13);
            this.CrossRatio.TabIndex = 8;
            this.CrossRatio.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(1063, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "cross ratio";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.MediumRadioButton2);
            this.groupBox1.Controls.Add(this.MediumRadioButton1);
            this.groupBox1.Controls.Add(this.HardRadioButton3);
            this.groupBox1.Controls.Add(this.HardRadioButton2);
            this.groupBox1.Controls.Add(this.EasyRadioButton3);
            this.groupBox1.Controls.Add(this.EasyRadioButton2);
            this.groupBox1.Controls.Add(this.HardRadioButton1);
            this.groupBox1.Controls.Add(this.EasyRadioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(105, 604);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InputData";
            // 
            // MediumRadioButton2
            // 
            this.MediumRadioButton2.AutoSize = true;
            this.MediumRadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MediumRadioButton2.Location = new System.Drawing.Point(267, 35);
            this.MediumRadioButton2.Name = "MediumRadioButton2";
            this.MediumRadioButton2.Size = new System.Drawing.Size(73, 17);
            this.MediumRadioButton2.TabIndex = 7;
            this.MediumRadioButton2.Text = "medium_2";
            this.MediumRadioButton2.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton1
            // 
            this.MediumRadioButton1.AutoSize = true;
            this.MediumRadioButton1.Checked = true;
            this.MediumRadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MediumRadioButton1.Location = new System.Drawing.Point(267, 12);
            this.MediumRadioButton1.Name = "MediumRadioButton1";
            this.MediumRadioButton1.Size = new System.Drawing.Size(73, 17);
            this.MediumRadioButton1.TabIndex = 6;
            this.MediumRadioButton1.TabStop = true;
            this.MediumRadioButton1.Text = "medium_1";
            this.MediumRadioButton1.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton3
            // 
            this.HardRadioButton3.AutoSize = true;
            this.HardRadioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardRadioButton3.Location = new System.Drawing.Point(141, 35);
            this.HardRadioButton3.Name = "HardRadioButton3";
            this.HardRadioButton3.Size = new System.Drawing.Size(58, 17);
            this.HardRadioButton3.TabIndex = 5;
            this.HardRadioButton3.Text = "hard_3";
            this.HardRadioButton3.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton2
            // 
            this.HardRadioButton2.AutoSize = true;
            this.HardRadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardRadioButton2.Location = new System.Drawing.Point(76, 35);
            this.HardRadioButton2.Name = "HardRadioButton2";
            this.HardRadioButton2.Size = new System.Drawing.Size(58, 17);
            this.HardRadioButton2.TabIndex = 4;
            this.HardRadioButton2.Text = "hard_2";
            this.HardRadioButton2.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton3
            // 
            this.EasyRadioButton3.AutoSize = true;
            this.EasyRadioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EasyRadioButton3.Location = new System.Drawing.Point(141, 12);
            this.EasyRadioButton3.Name = "EasyRadioButton3";
            this.EasyRadioButton3.Size = new System.Drawing.Size(59, 17);
            this.EasyRadioButton3.TabIndex = 3;
            this.EasyRadioButton3.Text = "easy_3";
            this.EasyRadioButton3.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton2
            // 
            this.EasyRadioButton2.AutoSize = true;
            this.EasyRadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EasyRadioButton2.Location = new System.Drawing.Point(76, 12);
            this.EasyRadioButton2.Name = "EasyRadioButton2";
            this.EasyRadioButton2.Size = new System.Drawing.Size(59, 17);
            this.EasyRadioButton2.TabIndex = 2;
            this.EasyRadioButton2.Text = "easy_2";
            this.EasyRadioButton2.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton1
            // 
            this.HardRadioButton1.AutoSize = true;
            this.HardRadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardRadioButton1.Location = new System.Drawing.Point(7, 35);
            this.HardRadioButton1.Name = "HardRadioButton1";
            this.HardRadioButton1.Size = new System.Drawing.Size(58, 17);
            this.HardRadioButton1.TabIndex = 1;
            this.HardRadioButton1.Text = "hard_1";
            this.HardRadioButton1.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton1
            // 
            this.EasyRadioButton1.AutoSize = true;
            this.EasyRadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EasyRadioButton1.Location = new System.Drawing.Point(7, 12);
            this.EasyRadioButton1.Name = "EasyRadioButton1";
            this.EasyRadioButton1.Size = new System.Drawing.Size(59, 17);
            this.EasyRadioButton1.TabIndex = 0;
            this.EasyRadioButton1.Text = "easy_1";
            this.EasyRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(459, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 75);
            this.label3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(739, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(3, 75);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1058, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(3, 75);
            this.label6.TabIndex = 13;
            // 
            // CrossingMethod
            // 
            this.CrossingMethod.Controls.Add(this.OX1RadioButton);
            this.CrossingMethod.Controls.Add(this.UniformRadioButton);
            this.CrossingMethod.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CrossingMethod.Location = new System.Drawing.Point(468, 604);
            this.CrossingMethod.Name = "CrossingMethod";
            this.CrossingMethod.Size = new System.Drawing.Size(265, 65);
            this.CrossingMethod.TabIndex = 14;
            this.CrossingMethod.TabStop = false;
            this.CrossingMethod.Text = "CrossingMethod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(742, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Worst Min Value: ";
            // 
            // MinValue
            // 
            this.MinValue.AutoSize = true;
            this.MinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinValue.Location = new System.Drawing.Point(890, 606);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(18, 20);
            this.MinValue.TabIndex = 15;
            this.MinValue.Text = "0";
            // 
            // UniformRadioButton
            // 
            this.UniformRadioButton.AutoSize = true;
            this.UniformRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UniformRadioButton.Location = new System.Drawing.Point(7, 14);
            this.UniformRadioButton.Name = "UniformRadioButton";
            this.UniformRadioButton.Size = new System.Drawing.Size(108, 17);
            this.UniformRadioButton.TabIndex = 1;
            this.UniformRadioButton.Text = "Uniform-extended";
            this.UniformRadioButton.UseVisualStyleBackColor = true;
            // 
            // OX1RadioButton
            // 
            this.OX1RadioButton.AutoSize = true;
            this.OX1RadioButton.Checked = true;
            this.OX1RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OX1RadioButton.Location = new System.Drawing.Point(6, 35);
            this.OX1RadioButton.Name = "OX1RadioButton";
            this.OX1RadioButton.Size = new System.Drawing.Size(46, 17);
            this.OX1RadioButton.TabIndex = 2;
            this.OX1RadioButton.TabStop = true;
            this.OX1RadioButton.Text = "OX1";
            this.OX1RadioButton.UseVisualStyleBackColor = true;
            // 
            // WorkingGuard1
            // 
            this.WorkingGuard1.AccessibleName = "ActiveLabel";
            this.WorkingGuard1.BackColor = System.Drawing.Color.White;
            this.WorkingGuard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkingGuard1.Location = new System.Drawing.Point(5, 656);
            this.WorkingGuard1.Name = "WorkingGuard1";
            this.WorkingGuard1.Size = new System.Drawing.Size(92, 15);
            this.WorkingGuard1.TabIndex = 17;
            // 
            // GeneticAlgorythmChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.WorkingGuard1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.CrossingMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneticAlgorythmChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic";
            this.Load += new System.EventHandler(this.GeneticAlgorythmChar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CrossingMethod.ResumeLayout(false);
            this.CrossingMethod.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HardRadioButton1;
        private System.Windows.Forms.RadioButton EasyRadioButton1;
        private System.Windows.Forms.RadioButton EasyRadioButton3;
        private System.Windows.Forms.RadioButton EasyRadioButton2;
        private System.Windows.Forms.RadioButton HardRadioButton3;
        private System.Windows.Forms.RadioButton HardRadioButton2;
        private System.Windows.Forms.RadioButton MediumRadioButton2;
        private System.Windows.Forms.RadioButton MediumRadioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox CrossingMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MinValue;
        private System.Windows.Forms.RadioButton OX1RadioButton;
        private System.Windows.Forms.RadioButton UniformRadioButton;
        private System.Windows.Forms.Label WorkingGuard1;
    }
}

