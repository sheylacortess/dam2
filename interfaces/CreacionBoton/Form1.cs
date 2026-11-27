namespace CreacionBoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manejadorBotones(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("Hola soy " + sender.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button miBoton = new Button();
            miBoton.Text = "Boton2";
            miBoton.Left = 10;
            miBoton.Top = 10;
            this.Controls.Add(miBoton);
            miBoton.Click += new System.EventHandler(manejadorBotones);
        }
    }
}
