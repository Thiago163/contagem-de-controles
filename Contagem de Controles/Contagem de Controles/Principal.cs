using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contagem_de_Controles
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            int qtdeControles = 0;

            foreach (Control item in grpAluno.Controls)
            {
                qtdeControles += 1;
            }
            foreach (Control item in grpCursos.Controls)
             {
                 qtdeControles += 1;
             }

            foreach (Control item in grpEnsinoMedio.Controls)
             {

             qtdeControles += 1;

             }

            MessageBox.Show(qtdeControles.ToString());
        }

        private void BtnResponsavel_Click(object sender, EventArgs e)
        {
            int qtdeControles1 = 0;

            foreach (Control item in grpResponsavel.Controls)
            {
                    qtdeControles1 += 1;
            }

            MessageBox.Show(qtdeControles1.ToString());
        }

        private void BtnFormulario_Click(object sender, EventArgs e)
        {
            int qtdeControles2= 0;

            foreach (Control item in grpAluno.Controls)
            {
                qtdeControles2+= 1;
            }
            foreach (Control item in grpCursos.Controls)
            {
                qtdeControles2+= 1;
            }

            foreach (Control item in grpEnsinoMedio.Controls)
            {

                qtdeControles2+= 1;

            }

            foreach (Control item in grpResponsavel.Controls)
            {
                qtdeControles2 += 1;
            }

            foreach (Control item in grpComandos.Controls)
            {
                qtdeControles2 += 1;
            }

            foreach (Control item in this.Controls)
            {
                qtdeControles2 += 1;
            }

            MessageBox.Show(qtdeControles2.ToString());
        }

        private void BtnControles_Click(object sender, EventArgs e)
        {
            string Nomes = "";

            foreach (Control item in grpAluno.Controls)
            {
                Nomes += item.Name + " " + Environment.NewLine;
                Nomes += item.Text + " ";

            }

            foreach (Control item in grpResponsavel.Controls)
            {
                Nomes += item.Name + " " + Environment.NewLine;
                Nomes += item.Text + " ";

            }

            foreach (Control item in grpEnsinoMedio.Controls)
            {
                Nomes += item.Name + " " + Environment.NewLine;
                Nomes += item.Text + " ";

            }

            foreach (Control item in grpCursos.Controls)
            {
                Nomes += item.Name + " " + Environment.NewLine;
                Nomes += item.Text + " ";

            }

            MessageBox.Show(Nomes.ToString());
        }
    }
}
