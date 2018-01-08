using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matricula_2018
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_cadAluno frm = new Frm_cadAluno();
            frm.ShowDialog();
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tbx_senha.Text == "123456")
            {
                Frm_cadAluno frm = new Frm_cadAluno();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou senha errada", "Ocorreu um erro na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
