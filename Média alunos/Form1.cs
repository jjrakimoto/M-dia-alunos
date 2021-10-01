using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média_alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal MediaAluno(params decimal[] notas)
        {
            decimal soma = 0;
            for (int i = 0; i <= notas.GetLength(0) - 1; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            lBResul.Items.Clear();
            string nome = tbNome.Text;
            string nascimento = dTPNascimento.Value.Tostring();
            decimal nota1 = nAtiv01.Value;
            decimal nota2 = nAtiv02.Value;
            decimal nota3 = nAtiv03.Value;
            decimal nota4 = nAtiv04.Value;

            lBResul.Items.Add(
                "Aluno: " + nome
                );

            lBRResul.Items.Add(
                "Data de Nascimento" + nascimento
                );
            lBResul.Items.Add("Notas das atividades");

            lBResul.Items.Add("Atividades 01:" + nota1);
            lBResul.Items.Add("Atividades 02:" + nota2);
            lBResul.Items.Add("Atividades 03:" + nota3);
            lBResul.Items.Add("Atividades 04:" + nota4);
            lBResul.Itens.Add(""Média Final: " + MediaAluno(nota1, nota2, nota3, nota4));
                decimal media = MediaAluno(nota1, nota2, nota3, nota4);
            // nMedia.Value = media;
            deciamal valormedia = nMedia.Value;
            if(MediaAluno >= valormedia)
            {
                MessageBox.Show("Aluno Aprovado");
            }
            else
            {
                MessageBox.Show("Aluno Reprovado");
            }
         }
    }
}
