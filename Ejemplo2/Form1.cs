namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            foreach (string item in lstbMiLista.SelectedItems)
            {
                MessageBox.Show(item);
            }

        }

        private void lstbMiLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void lstbMiLista_Enter(object sender, EventArgs e)
        {
            lstbMiLista.BackColor = Color.LightYellow;
        }

        private void lstbMiLista_Leave(object sender, EventArgs e)
        {
            lstbMiLista.BackColor = Color.White;
        }
    }
}