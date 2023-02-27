namespace lab1
{
    partial class FormLab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTask1 = new System.Windows.Forms.NumericUpDown();
            this.chartTask1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonTask4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTask4 = new System.Windows.Forms.NumericUpDown();
            this.chartTask4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTask1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTask1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTask4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTask4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonTask1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownTask1);
            this.tabPage1.Controls.Add(this.chartTask1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(710, 72);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(182, 44);
            this.buttonTask1.TabIndex = 3;
            this.buttonTask1.Text = "Выполнить";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(706, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во эксперементов";
            // 
            // numericUpDownTask1
            // 
            this.numericUpDownTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numericUpDownTask1.Location = new System.Drawing.Point(710, 43);
            this.numericUpDownTask1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTask1.Name = "numericUpDownTask1";
            this.numericUpDownTask1.Size = new System.Drawing.Size(182, 23);
            this.numericUpDownTask1.TabIndex = 1;
            // 
            // chartTask1
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTask1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTask1.Legends.Add(legend3);
            this.chartTask1.Location = new System.Drawing.Point(0, 0);
            this.chartTask1.Name = "chartTask1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTask1.Series.Add(series3);
            this.chartTask1.Size = new System.Drawing.Size(697, 531);
            this.chartTask1.TabIndex = 0;
            this.chartTask1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonTask4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDownTask4);
            this.tabPage2.Controls.Add(this.chartTask4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonTask4
            // 
            this.buttonTask4.Location = new System.Drawing.Point(709, 71);
            this.buttonTask4.Name = "buttonTask4";
            this.buttonTask4.Size = new System.Drawing.Size(182, 44);
            this.buttonTask4.TabIndex = 7;
            this.buttonTask4.Text = "Выполнить";
            this.buttonTask4.UseVisualStyleBackColor = true;
            this.buttonTask4.Click += new System.EventHandler(this.buttonTask4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(705, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во эксперементов";
            // 
            // numericUpDownTask4
            // 
            this.numericUpDownTask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numericUpDownTask4.Location = new System.Drawing.Point(709, 42);
            this.numericUpDownTask4.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTask4.Name = "numericUpDownTask4";
            this.numericUpDownTask4.Size = new System.Drawing.Size(182, 23);
            this.numericUpDownTask4.TabIndex = 5;
            // 
            // chartTask4
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTask4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTask4.Legends.Add(legend4);
            this.chartTask4.Location = new System.Drawing.Point(0, 0);
            this.chartTask4.Name = "chartTask4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTask4.Series.Add(series4);
            this.chartTask4.Size = new System.Drawing.Size(697, 531);
            this.chartTask4.TabIndex = 4;
            this.chartTask4.Text = "chart1";
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLab2";
            this.Text = "FormLab2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTask1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTask1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTask4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTask4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTask1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask1;
        private System.Windows.Forms.Button buttonTask4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTask4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask4;
    }
}