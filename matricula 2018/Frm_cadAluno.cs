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
    public partial class Frm_cadAluno : Form
    {
        public Frm_cadAluno()
        {
            InitializeComponent();
        }

        private void Frm_cadAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.CadAluno'. Você pode movê-la ou removê-la conforme necessário.
            this.cadAlunoTableAdapter.Fill(this.escolaDataSet.CadAluno);
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.CadAluno'. Você pode movê-la ou removê-la conforme necessário.
            this.cadAlunoTableAdapter.Fill(this.escolaDataSet.CadAluno);

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void cadAlunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);

        }
    }
}
