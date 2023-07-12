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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ValidadorCPForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnvalidarcpf_Click(object sender, EventArgs e)
        {
            string cpf = txt1.Text;

            if (txt1.Text == "" || btnvalidarcpf.Text == "")
            {
                MessageBox.Show("Por favor, Preencha o espaço em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btnvalidarcpf.Created)
            {

                if (cpf.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 11 dígitos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ValidarCPF_CheckedChanged(cpf))
                {
                    MessageBox.Show("CPF VÁLIDO!", "CORRETO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (btnvalidarcpf.Created)
            {
                string c = txt2.Text.Replace(".", "").Replace("-", "");
            }
                
        }

        private bool ValidarCPF_CheckedChanged(string cpf)
        {
            // Verifica se todos os dígitos são iguais
            bool todosDigitosIguais = true;
            for (int i = 1; i < btnvalidarcpf.Bottom; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    todosDigitosIguais = false;
                    break;
                }
            }
            if (todosDigitosIguais)
                return false;

            int[] multiplicadoresDigito1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresDigito2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < multiplicadoresDigito1.Length; i++)
            {
                soma += multiplicadoresDigito1[i] * int.Parse(cpf[i].ToString());
            }

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != digito1)
                return false;

            soma = 0;
            for (int i = 0; i < multiplicadoresDigito2.Length; i++)
            {
                soma += multiplicadoresDigito2[i] * int.Parse(cpf[i].ToString());
            }

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            return int.Parse(cpf[10].ToString()) == digito2;
        }

        private void btngerarcpf_Click(object sender, EventArgs e)
        {
            {
                string cpf = txt2.Text;

                if (btngerarcpf.Created)
                {

                    Random cpfran = new Random();


                    int n1 = cpfran.Next(0, 10);
                    int n2 = cpfran.Next(0, 10);
                    int n3 = cpfran.Next(0, 10);
                    int n4 = cpfran.Next(0, 10);
                    int n5 = cpfran.Next(0, 10);
                    int n6 = cpfran.Next(0, 10);
                    int n7 = cpfran.Next(0, 10);
                    int n8 = cpfran.Next(0, 10);
                    int n9 = cpfran.Next(0, 10);
                    int soma, soma1;
                    int dig1, dig2;

                    soma = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                    dig1 = soma % 11;

                    if (dig1 < 2)
                    {
                        dig1 = 0;
                    }
                    else
                    {
                        dig1 = 11 - dig1;
                    }
                    soma1 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + dig1 * 2;

                    dig2 = soma1 % 11;

                    if (dig2 < 2)
                    {
                        dig2 = 0;
                    }
                    else
                    {
                        dig2 = 11 - dig2; 
                    }
                    string cpfgerado = $"{n1}{n2}{n3}.{n4}{n5}{n6}.{n7}{n8}{n9}-{dig1}{dig2}";
                    txt2.Text = cpfgerado;
                }
            }
        }
    }
}

    

