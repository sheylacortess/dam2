namespace Juego
{
    public partial class Form1 : Form
    {

        private int direccion = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direccion)
            {
                case 1:
                    pcbBola.Top = pcbBola.Top - 1;
                    pcbBola.Left = pcbBola.Left + 1;
                    if (pcbBola.Top < 0) direccion = 2; // choque con el techo 
                    if (pcbBola.Left + pcbBola.Width >= ClientSize.Width) direccion = 4;
                    break;
                
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A)) pcbPaleta.Left = pcbBola.Left - 1;
            if ((e.KeyCode == Keys.D)) pcbPaleta.Left = pcbBola.Left +  1;
        }
    }
}
