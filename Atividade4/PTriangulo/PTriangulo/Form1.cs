using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        private void mTxtBoxA_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mTxtBoxA.Text, out ladoA))
            {
                errPladoA.SetError(mTxtBoxA, "Valor invalido!");
                mTxtBoxA.Focus();
            }
        }

        private void mTxtBoxB_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mTxtBoxB.Text, out ladoB))
            {
                errPLadoB.SetError(mTxtBoxB, "Valor invalido!");
                mTxtBoxB.Focus();
            }
        }

        private void mTxtBoxC_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mTxtBoxC.Text, out ladoC))
            {
                errPLadoC.SetError(mTxtBoxC, "Valor invalido!");
                mTxtBoxC.Focus();
            }
        }

        private void btnConfere_Click(object sender, EventArgs e)
        {
            if ((ladoA > Math.Abs(ladoB - ladoC) && ladoA < ladoB + ladoC) &&
                (ladoB > Math.Abs(ladoC - ladoA) && ladoB < ladoC + ladoA) &&
                (ladoC > Math.Abs(ladoA - ladoB) && ladoC < ladoA + ladoB))
            {
                if ((ladoA == ladoB) && (ladoB == ladoC))
                    mTxtBoxResulado.Text = "É Equilatero";
                else if ((ladoA != ladoB) && (ladoB == ladoC) ||
                        (ladoB != ladoC) && (ladoC == ladoA) ||
                        (ladoC != ladoA) && (ladoA == ladoB))
                    mTxtBoxResulado.Text = "É Isosceles";
                else
                    mTxtBoxResulado.Text = "É Escaleno";
            }
            else
            {
                MessageBox.Show("Os valores inseridos não formam um triângulo!");
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            mTxtBoxA.Clear();
            mTxtBoxB.Clear();
            mTxtBoxC.Clear();
            mTxtBoxResulado.Clear();
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
            mTxtBoxA.Focus();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
