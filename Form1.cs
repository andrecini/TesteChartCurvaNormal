using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TesteChartCurvaNormal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Dados dados = new Dados(int.Parse(txtMoedas.Text), int.Parse(txtSorteios.Text));

            BindingSource bsG = new BindingSource();
            bsG.DataSource = dados.RetornaDataTable();
            dataGridView1.DataSource = bsG;

            chart1.DataSource = dados.RetornaDataTable();

            VerificaCheckBox();
                    }

        private int numSeries = 0;

        private void VerificaCheckBox()
        {
            if (cbCaras.Checked && cbCoroas.Checked)
            {
                numSeries = 1;
            }
            else if (cbCaras.Checked)
            {
                numSeries = 2;
            }
            else if (cbCoroas.Checked)
            {
                numSeries = 3;
            }

            CriaChart();
        }

        private void CriaChart()
        {
            if (numSeries == 1)
            {
                CriaSerie("Caras", "Crimson");
                CriaSerie("Coroas", "DeepSkyBlue");
            }
            else if (numSeries == 2)
            {
                DeletaSerie("Coroas");
                CriaSerie("Caras", "Crimson");
            }
            else if (numSeries == 3)
            {
                DeletaSerie("Caras");
                CriaSerie("Coroas", "DeepSkyBlue");
            }
            else
            {
                DeletaSerie("Caras");
                DeletaSerie("Coroas");
            }
        }

        private void CriaSerie(string tipo, string color)
        {
            DeletaSerie(tipo.ToLower());
            chart1.Series.Add(tipo.ToLower());
            chart1.Series[tipo.ToLower()].LegendText = tipo;
            chart1.Series[tipo.ToLower()].XValueMember = "ID";
            chart1.Series[tipo.ToLower()].YValueMembers = tipo.ToLower();
            chart1.Series[tipo.ToLower()].Color = Color.FromName(color);
        }

        private void DeletaSerie(string tipo)
        {
            try
            {
                chart1.Series.Remove(chart1.Series[tipo.ToLower()]);
            }
            catch (Exception)
            {
            }
            
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            VerificaCheckBox();
        }
    }
}

