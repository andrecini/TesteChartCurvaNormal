using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteChartCurvaNormal
{
    class Moeda
    {
        private double lados; //Cara = 0 & Coroa = 1
        private int qtddSorteios;
        private static Random rdm = new Random();
        private static Stopwatch sw = new Stopwatch();

        public double Lados
        {
            get => lados;
        }

        private double CaraOuCoroa()
        {
            return SorteiaNumeros();
        }

        private double SorteiaNumeros()
        {
            sw.Start();
            sw.Stop();

            if (sw.ElapsedTicks < 5)
                return AtrasaTimerTick(sw.ElapsedTicks);
            else
                return AtrasaTimerTick(rdm.Next(5));
        }
       
        private double AtrasaTimerTick(double num)
        {
            sw.Start();
            #region Atraso qualquer
            for (int i = 0; i < num; i++)
            {
                int x = 0;
            }
            #endregion
            sw.Stop();

            return sw.ElapsedTicks;
        }

        public Moeda(int qtddSorteios)
        {
            this.qtddSorteios = qtddSorteios;
            lados = CaraOuCoroa();
        }
    }

    class Sorteio
    {
        private int qtddSorteios;
        private int caras = 0;
        private int coroas = 0;

        public int Caras
        {
            get => caras;
        }

        public int Coroas
        {
            get => coroas;
        }

        private void RealizaSorteios()
        {
            for (int i = 0; i < qtddSorteios; i++)
            {
                Moeda Moeda = new Moeda(qtddSorteios);

                if (Moeda.Lados%2 == 0)
                    caras++;
                else
                    coroas++;
            }
        }

        public Sorteio(int qtddSorteios)
        {
            this.qtddSorteios = qtddSorteios;
            RealizaSorteios();
        }
    }

    class Dados
    {
        private List<int> ResultadosCaras = new List<int>();
        private List<int> ResultadosCoroas = new List<int>();
        private int qtddMoedas;
        private int qtddSorteios;

        private void PreencheLista()
        {
            for (int i = 0; i < qtddMoedas; i++)
            {
                 Sorteio sorteio = new Sorteio(qtddSorteios);
                 ResultadosCaras.Add(sorteio.Caras);
                 ResultadosCoroas.Add(sorteio.Coroas);
            }
        }

        private void ZeraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = 0;
            }
        }

        public int[] RetornaVetorFinalCaras()
        {
            int[] vetorFinal = new int[qtddSorteios + 1];
            ZeraVetor(vetorFinal);

            foreach (var item in ResultadosCaras)
            {
                vetorFinal[item] += 1;
            }

            return vetorFinal;
        }

        public int[] RetornaVetorFinalCoroas()
        {
            int[] vetorFinal = new int[qtddSorteios + 1];
            ZeraVetor(vetorFinal);

            foreach (var item in ResultadosCoroas)
            {
                vetorFinal[item] += 1;
            }

            return vetorFinal;
        }

        public Dados(int qtddMoedas, int qtddSorteios)
        {
            this.qtddMoedas = qtddMoedas;
            this.qtddSorteios = qtddSorteios;

            PreencheLista();
        }

        public DataTable RetornaDataTable()
        {
            DataTable dados = new DataTable();

            dados.Columns.Add("ID");
            dados.Columns.Add("caras");
            dados.Columns.Add("coroas");

            PreencheDataTable(ref dados, RetornaVetorFinalCaras(), RetornaVetorFinalCoroas());

            return dados;
        }

        private void PreencheDataTable(ref DataTable dados, int[] caras, int[] coroas)
        {
            for (int i = 0; i < caras.Length; i++)
            {
                dados.Rows.Add(i.ToString(), caras[i], coroas[i]);
            }
        }

    }
}
