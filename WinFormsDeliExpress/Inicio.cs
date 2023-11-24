namespace WinFormsDeliExpress
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Centro();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotCambiar1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        private void Centro()
        {
            int centroX = groupBox1.Width / 2;
            int centroY = groupBox1.Height / 2;
            int posX = centroX - textBox1.Width / 2;
            int posY = centroY - textBox1.Height / 2;
            textBox1.Location = new System.Drawing.Point(posX, posY);
            textBox2.Location = new System.Drawing.Point(posX, posY + 30);
        }

        private void Inicio_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}