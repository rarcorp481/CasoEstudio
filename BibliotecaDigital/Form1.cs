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
            string autorBusqueda = txtBusquedaBinaria.Text.Trim();

            if (string.IsNullOrEmpty(autorBusqueda)) return;

            int bajo = 0;
            int alto = listaAutores.Count - 1;
            int centro;
            Autor encontrado = null;
            int iteraciones = 0;

            while (bajo <= alto)
            {
                iteraciones++;
                centro = (bajo + alto) / 2;

                // Comparamos alfabéticamente
                int comparacion = string.Compare(listaAutores[centro].Nombre, autorBusqueda, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0) // Encontrado
                {
                    encontrado = listaAutores[centro];
                    break;
                }
                else if (comparacion < 0) // El buscado está en la mitad superior
                {
                    bajo = centro + 1;
                }
                else // El buscado está en la mitad inferior
                {
                    alto = centro - 1;
                }
            }

            if (encontrado != null)
                lblResultadoBinaria.Text = $"Autor ID {encontrado.Id}: {encontrado.Nombre}\nPasos realizados: {iteraciones}";
            else
                lblResultadoBinaria.Text = $"Autor no encontrado en la base de datos.\nPasos realizados: {iteraciones}";
        }

        private void btnAnalizarAnio_Click(object sender, EventArgs e)
        {
            if (listaLibros.Count == 0) return;

            Libro masAntiguo = listaLibros[0];
            Libro masReciente = listaLibros[0];

            foreach (var libro in listaLibros)
            {
                if (libro.AnioPublicacion < masAntiguo.AnioPublicacion)
                    masAntiguo = libro;

                if (libro.AnioPublicacion > masReciente.AnioPublicacion)
                    masReciente = libro;
            }

            lblLibroAntiguo.Text = $"Más Antiguo:\n{masAntiguo.Titulo} ({masAntiguo.AnioPublicacion})";
            lblLibroReciente.Text = $"Más Reciente:\n{masReciente.Titulo} ({masReciente.AnioPublicacion})";
        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
