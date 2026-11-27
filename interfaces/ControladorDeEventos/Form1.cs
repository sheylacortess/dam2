namespace ControladorDeEventos
{
    public partial class Form1 : Form
    {
        private List<Pelicula> listaPeliculas = new List<Pelicula>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarFichero();
            CrearRadioButtonsDinamicos();
        }

        private void CargarFichero()
        {
            string ruta = @"C:\\Users\\alumno\\source\\repos\\docs\Peliculas.txt";

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] partes = linea.Split('#');
                        if (partes.Length >= 4)
                        {
                            string titulo = partes[0].Trim();
                            string actores = partes[1].Trim();
                            string director = partes[2].Trim();
                            string clasificacion = partes[3].Trim();

                            listaPeliculas.Add(new Pelicula(titulo, actores, director, clasificacion));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el archivo Peliculas.txt");
            }
        }
        private void CrearRadioButtonsDinamicos()
        {
            // Lista auxiliar para no repetir clasificaciones
            List<string> clasificacionesUnicas = new List<string>();

            foreach (Pelicula p in listaPeliculas)
            {
                if (!clasificacionesUnicas.Contains(p.Clasificacion))
                {
                    clasificacionesUnicas.Add(p.Clasificacion);
                }
            }

            // Posición inicial donde empezaremos a pintar los RadioButtons
            int posX = 20;
            int posY = 20;

            foreach (string clasif in clasificacionesUnicas)
            {
                // 1. Creamos el objeto RadioButton en tiempo de ejecución
                RadioButton rb = new RadioButton();
                rb.Text = clasif;
                rb.AutoSize = true; // Para que no se corte el texto largo ("No recomendado a menores de 13 años")
                rb.Location = new Point(posX, posY);

                // 2. Asociamos su evento Click con nuestro controlador
                rb.Click += RadioButtonClasificacion_Click;

                // 3. Lo añadimos a la colección Controls del formulario
                this.Controls.Add(rb);

                // Bajamos la coordenada Y para que el siguiente salga debajo y no se pisen
                posY += 25;
            }
        }

        private void RadioButtonClasificacion_Click(object sender, EventArgs e)
        {
            // Sabemos qué RadioButton se ha pulsado gracias a 'sender'
            RadioButton rbPulsado = (RadioButton)sender;
            string clasificacionElegida = rbPulsado.Text;

            //limpiamos los listbox antes de rellenarlos
            lstTitulos.Items.Clear();
            lstActores.Items.Clear();
            lstDirectores.Items.Clear();

            // Recorremos las películas y mostramos solo las que coincidan
            foreach (Pelicula p in listaPeliculas)
            {
                if (p.Clasificacion == clasificacionElegida)
                {
                    lstTitulos.Items.Add(p.Titulo);
                    lstActores.Items.Add(p.Actores);
                    lstDirectores.Items.Add(p.Director);
                }
            }
        }
    }
}
