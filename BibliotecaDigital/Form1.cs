using BibliotecaDigital.Modelos;

namespace BibliotecaDigital
{
    public partial class Form1 : Form
    {
        private List<Libro> listaLibros;
        private List<Autor> listaAutores;

        public Form1()
        {
            InitializeComponent();
            CargarDatosDePrueba();
            ConfigurarTablas();

        }
        private void CargarDatosDePrueba()
        {
            listaLibros = new List<Libro>
            {
                new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, "Una novela sobre la familia Buendía en Macondo."),
                new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "La historia de un hidalgo que enloquece leyendo libros de caballería."),
                new Libro("1984", "George Orwell", 1949, "Una crítica política sobre el totalitarismo y la vigilancia masiva."),
                new Libro("El Principito", "Antoine de Saint-Exupéry", 1943, "Un cuento poético sobre la soledad, la amistad y el amor."),
                new Libro("Fahrenheit 451", "Ray Bradbury", 1953, "Una distopía donde los libros están prohibidos y son quemados."),
                new Libro("Crimen y castigo", "Fiódor Dostoyevski", 1866, "Un análisis psicológico sobre la culpa y la redención."),
                new Libro("Clean Code", "Robert C. Martin", 2008, "Manual de estilo para el desarrollo ágil de software."),
                new Libro("La Odisea", "Homero", -800, "Poema épico griego sobre el regreso de Odiseo a Ítaca.")
            };

            listaAutores = new List<Autor>
            {
                new Autor(1, "Antoine de Saint-Exupéry"),
                new Autor(2, "Fiódor Dostoyevski"),
                new Autor(3, "Gabriel García Márquez"),
                new Autor(4, "George Orwell"),
                new Autor(5, "Homero"),
                new Autor(6, "Miguel de Cervantes"),
                new Autor(7, "Ray Bradbury"),
                new Autor(8, "Robert C. Martin")
            };
        }

        private void ConfigurarTablas()
        {
            dgvLibros.DataSource = listaLibros;
            dgvAutores.DataSource = listaAutores;
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBusquedaLineal_Click(object sender, EventArgs e)
        {
            string tituloBusqueda = txtBusquedaLineal.Text.Trim();

            if (string.IsNullOrEmpty(tituloBusqueda))
            {
                MessageBox.Show("Por favor ingrese un título.");
                return;
            }

            Libro encontrado = null;
            int iteraciones = 0;

            // Recorremos uno por uno hasta encontrar coincidencia
            for (int i = 0; i < listaLibros.Count; i++)
            {
                iteraciones++;
                // Comparación ignorando mayúsculas/minúsculas
                if (listaLibros[i].Titulo.Equals(tituloBusqueda, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = listaLibros[i];
                    break;
                }
            }

            if (encontrado != null)
                lblResultadoLineal.Text = $"Encontrado: '{encontrado.Titulo}' ({encontrado.AnioPublicacion})\nIteraciones: {iteraciones}";
            else
                lblResultadoLineal.Text = $"No se encontró el libro.\nIteraciones: {iteraciones}";
        }

        private void btnBusquedaBinaria_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenamientoBurbuja_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalizarAnio_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
