
namespace TesteChartCurvaNormal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Chart = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbCaras = new System.Windows.Forms.CheckBox();
            this.cbCoroas = new System.Windows.Forms.CheckBox();
            this.txtMoedas = new System.Windows.Forms.NumericUpDown();
            this.txtSorteios = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSorteios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moedas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sorteios:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Chart);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 338);
            this.tabControl1.TabIndex = 7;
            // 
            // Chart
            // 
            this.Chart.Controls.Add(this.chart1);
            this.Chart.Location = new System.Drawing.Point(4, 22);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(3);
            this.Chart.Size = new System.Drawing.Size(635, 312);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart";
            this.Chart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.Size = new System.Drawing.Size(639, 316);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbCaras
            // 
            this.cbCaras.AutoSize = true;
            this.cbCaras.Checked = true;
            this.cbCaras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCaras.Location = new System.Drawing.Point(380, 8);
            this.cbCaras.Name = "cbCaras";
            this.cbCaras.Size = new System.Drawing.Size(53, 17);
            this.cbCaras.TabIndex = 8;
            this.cbCaras.Text = "Caras";
            this.cbCaras.UseVisualStyleBackColor = true;
            this.cbCaras.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbCoroas
            // 
            this.cbCoroas.AutoSize = true;
            this.cbCoroas.Checked = true;
            this.cbCoroas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCoroas.Location = new System.Drawing.Point(380, 25);
            this.cbCoroas.Name = "cbCoroas";
            this.cbCoroas.Size = new System.Drawing.Size(59, 17);
            this.cbCoroas.TabIndex = 9;
            this.cbCoroas.Text = "Coroas";
            this.cbCoroas.UseVisualStyleBackColor = true;
            this.cbCoroas.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // txtMoedas
            // 
            this.txtMoedas.Location = new System.Drawing.Point(12, 22);
            this.txtMoedas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtMoedas.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtMoedas.Name = "txtMoedas";
            this.txtMoedas.Size = new System.Drawing.Size(87, 20);
            this.txtMoedas.TabIndex = 10;
            this.txtMoedas.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // txtSorteios
            // 
            this.txtSorteios.Location = new System.Drawing.Point(136, 22);
            this.txtSorteios.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtSorteios.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtSorteios.Name = "txtSorteios";
            this.txtSorteios.Size = new System.Drawing.Size(87, 20);
            this.txtSorteios.TabIndex = 11;
            this.txtSorteios.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 385);
            this.Controls.Add(this.txtSorteios);
            this.Controls.Add(this.txtMoedas);
            this.Controls.Add(this.cbCoroas);
            this.Controls.Add(this.cbCaras);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSorteios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbCaras;
        private System.Windows.Forms.CheckBox cbCoroas;
        private System.Windows.Forms.NumericUpDown txtMoedas;
        private System.Windows.Forms.NumericUpDown txtSorteios;
    }
}

