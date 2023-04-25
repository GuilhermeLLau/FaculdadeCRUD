using FaculdadeCRUD;

namespace FaculdadeCRUD
{
    public partial class Form1 : Form
    {
        Agenda FrmAgenda;
        CEP FrmCep;
        Sobre FrmSobre;
        public Form1()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FrmAgenda == null)
            {
                FrmAgenda = new Agenda();
                FrmAgenda.MdiParent = this;
                FrmAgenda.WindowState = FormWindowState.Maximized;
                FrmAgenda.Show();
            }
            else
            {
                FrmAgenda.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmCep == null)
            {
                FrmCep = new CEP();
                FrmCep.MdiParent = this;
                FrmCep.WindowState = FormWindowState.Maximized;
                FrmCep.Show();
            }
            else
            {
                FrmCep.Activate();
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSobre == null)
            {
                FrmSobre = new Sobre();
                FrmSobre.ShowDialog();
            }
            else
            {
                FrmSobre.Activate();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}