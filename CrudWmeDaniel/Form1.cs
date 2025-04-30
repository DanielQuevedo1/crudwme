namespace CrudWmeDaniel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opcoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadusuarios add = new cadusuarios();
            add.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro de Clientes\nDesenvolvido por Daniel Quevedo", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
