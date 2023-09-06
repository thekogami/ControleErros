﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Array de números inteiros
            int[] num = { 10, 20, 30, 40, 50 };

            try
            {
                string res = "";
                // Loop para concatenar os números em uma string
                for (int i = 0; i < 5; i++)
                {
                    res += num[i] + " ";
                }
                // Exibe a string resultante na etiqueta
                label1.Text = res;
            }
            catch (Exception ex)
            {
                label1.Text = $"Erro!\n {ex.Message}";
            }
            finally
            {
                MessageBox.Show("Operação finalizada.");
            }
        }
    }
}
