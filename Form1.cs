using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MedidorDeNotas
{
    public partial class FrmPrincipal : Form
    {
        float n1, n2, n3, n4, media;

       

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Today.ToString();
            lblNome.Text = Program.usuario;
        }

        public void resultado()
        {
            n1 = float.Parse(txtMat.Text);
            n2 = float.Parse(txtPort.Text);
            n3 = float.Parse(txtBio.Text);
            n4 = float.Parse(txtHis.Text);
            media = (n1 + n2 + n3 + n4) / 4;
            lblMedia.Text = media.ToString();

            
        }

        public void mediaAluno()
        {
            if (media > 7)
            {
                lblSituacao.Text = "Aprovado 😀";
                lblSituacao.ForeColor = Color.Green;

            }

            else if (media == 7)
            {
                lblSituacao.Text = "Aprovado com o minimo 😬  ";
                lblSituacao.ForeColor = Color.Yellow;
            }

            else if (media < 7)
            {
                lblSituacao.Text = "Reprovado 😞";
                lblSituacao.ForeColor= Color.Red;
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {

            resultado();
            mediaAluno();


        }
       
    }
}
