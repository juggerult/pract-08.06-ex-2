namespace Zad2_04._06._23
{
    partial class frmDiagrams
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.txtMinAge = new System.Windows.Forms.TextBox();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(488, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для гистограммы";
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Location = new System.Drawing.Point(327, 25);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(187, 58);
            this.btCreateMasGist.TabIndex = 5;
            this.btCreateMasGist.Text = "Сгенерировать пустой массив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(7, 91);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.Size = new System.Drawing.Size(507, 139);
            this.dgvMasGist.TabIndex = 4;
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(217, 61);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(104, 26);
            this.txtMasGist.TabIndex = 3;
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(217, 25);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(104, 26);
            this.txtMinYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество лет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите начальный год:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCreateMasRound);
            this.groupBox2.Controls.Add(this.dgvMasRound);
            this.groupBox2.Controls.Add(this.txtMinAge);
            this.groupBox2.Controls.Add(this.txtMasRound);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(488, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для круговой диаграммы";
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Location = new System.Drawing.Point(327, 66);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(187, 58);
            this.btCreateMasRound.TabIndex = 6;
            this.btCreateMasRound.Text = "Сгенерировать пустой массив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(7, 133);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.Size = new System.Drawing.Size(507, 129);
            this.dgvMasRound.TabIndex = 5;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Location = new System.Drawing.Point(203, 103);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(104, 26);
            this.txtMinAge.TabIndex = 4;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(203, 42);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(104, 26);
            this.txtMasRound.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "Введите минимальный возраст:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите количество возрастных категорий:";
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.PeachPuff;
            this.chartDiagrams.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea11.Name = "ChartArea1";
            chartArea12.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea11);
            this.chartDiagrams.ChartAreas.Add(chartArea12);
            legend11.Name = "Legend1";
            legend12.Name = "Legend2";
            legend12.Position.Auto = false;
            legend12.Position.Height = 19.26F;
            legend12.Position.Width = 29F;
            legend12.Position.X = 70F;
            legend12.Position.Y = 52F;
            legend12.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartDiagrams.Legends.Add(legend11);
            this.chartDiagrams.Legends.Add(legend12);
            this.chartDiagrams.Location = new System.Drawing.Point(13, 13);
            this.chartDiagrams.Name = "chartDiagrams";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Количество учеников";
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Sector";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDiagrams.Series.Add(series11);
            this.chartDiagrams.Series.Add(series12);
            this.chartDiagrams.Size = new System.Drawing.Size(469, 513);
            this.chartDiagrams.TabIndex = 2;
            this.chartDiagrams.Text = "chart1";
            // 
            // btCreateGist
            // 
            this.btCreateGist.Location = new System.Drawing.Point(13, 528);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(228, 49);
            this.btCreateGist.TabIndex = 3;
            this.btCreateGist.Text = "Построить гистограмму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Location = new System.Drawing.Point(247, 528);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(235, 49);
            this.btCreateRound.TabIndex = 4;
            this.btCreateRound.Text = "Построить секторную диаграмму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(489, 528);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(520, 49);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 577);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDiagrams";
            this.Text = "Диаграммы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMasRound;
        private System.Windows.Forms.TextBox txtMinAge;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.Button btExit;
    }
}

