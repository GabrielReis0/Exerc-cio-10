namespace Exercício_10
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

        private void button1_Click(object sender, EventArgs e)
        {
            string senhaInserida = Microsoft.VisualBasic.Interaction.InputBox("Digite sua senha:", "Validação de Senha");

            if (senhaInserida == "Gabrielreis0") 
            {
                MessageBox.Show("Acesso validado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha incorreta. Acesso não validado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}