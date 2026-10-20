namespace ReproductorMusica;

public partial class FrmReproductor : Form
{
    // ================= LAS 3 ESTRUCTURAS DE DATOS =================

    // 1) VECTOR (arreglo): cuenta cuántas veces se ha reproducido una canción de cada género.
    //    La posición 0 es "Pop", la 1 es "Rock", y así sucesivamente.
    string[] generos = { "Pop", "Rock", "Reguetón", "Salsa", "Otros" };
    int[] reproduccionesPorGenero = new int[5];

    // 2) LIST (igual que un ArrayList): guarda el catálogo de canciones.
    List<Cancion> catalogo = new List<Cancion>();

    // 3) LISTA DOBLE (la hicimos en Clases.cs): guarda las canciones de la reproducción.
    ListaReproduccion lista = new ListaReproduccion();

    // Lo que se está mostrando en las listas de la pantalla.
    // Sirven para saber cuál canción eligió el usuario.
    List<Cancion> cancionesEnCatalogo = new List<Cancion>();
    List<Cancion> cancionesEnLista = new List<Cancion>();

    public FrmReproductor()
    {
        InitializeComponent();
    }

    // Se ejecuta una vez, cuando se abre el formulario
    private void FrmReproductor_Load(object sender, EventArgs e)
    {
        // Poner el vector en cero
        for (int i = 0; i < reproduccionesPorGenero.Length; i++)
        {
            reproduccionesPorGenero[i] = 0;
        }

        // Llenar el combo con los géneros
        for (int i = 0; i < generos.Length; i++)
        {
            cmbGenero.Items.Add(generos[i]);
        }
        cmbGenero.SelectedIndex = 0;

        ActualizarTodo();
    }

    // ================= MÉTODOS DE AYUDA =================

    // Convierte los segundos a texto, por ejemplo 234 -> "3:54"
    string FormatoDuracion(int segundos)
    {
        int minutos = segundos / 60;
        int resto = segundos % 60;
        return minutos + ":" + resto.ToString("00");
    }

    // Arma el texto de una canción para mostrarla en las listas
    string TextoCancion(Cancion c)
    {
        return c.Codigo + "  |  " + c.Titulo + "  |  " + c.Artista + "  |  " + c.Genero
            + "  |  " + FormatoDuracion(c.Duracion);
    }

    // Muestra una lista de canciones en la lista del catálogo
    void MostrarCatalogo(List<Cancion> canciones)
    {
        cancionesEnCatalogo = canciones;
        lstCatalogo.Items.Clear();

        foreach (Cancion c in canciones)
        {
            lstCatalogo.Items.Add(TextoCancion(c));
        }
    }

    // Muestra una lista de canciones en la lista de reproducción.
    // La canción que está sonando se marca con ">>"
    void MostrarLista(List<Cancion> canciones)
    {
        cancionesEnLista = canciones;
        lstLista.Items.Clear();
        Cancion sonando = lista.Actual();

        foreach (Cancion c in canciones)
        {
            string marca = "      ";
            if (c == sonando)
            {
                marca = ">>   ";
            }
            lstLista.Items.Add(marca + TextoCancion(c));
        }
    }

    // Recorre el vector y muestra las reproducciones de cada género
    void MostrarResumen()
    {
        string texto = "Reproducciones por género:" + Environment.NewLine;
        for (int i = 0; i < generos.Length; i++)
        {
            texto = texto + Environment.NewLine + generos[i] + ": " + reproduccionesPorGenero[i];
        }
        lblResumen.Text = texto;
    }

    // Muestra qué canción está sonando
    void MostrarAhora()
    {
        Cancion c = lista.Actual();
        if (c == null)
        {
            lblAhora.Text = "Reproduciendo: (ninguna)";
        }
        else
        {
            lblAhora.Text = "Reproduciendo: " + c.Titulo + " - " + c.Artista + " (" + FormatoDuracion(c.Duracion) + ")";
        }
    }

    // Vuelve a mostrar todo en pantalla
    void ActualizarTodo()
    {
        MostrarCatalogo(catalogo);
        MostrarLista(lista.Recorrer());
        MostrarResumen();
        MostrarAhora();
    }

    // Borra lo escrito en los cuadros
    void LimpiarCampos()
    {
        txtCodigo.Clear();
        txtTitulo.Clear();
        txtArtista.Clear();
        txtDuracion.Clear();
        cmbGenero.SelectedIndex = 0;
        txtCodigo.Focus();
    }

    // Busca una canción del catálogo por su código. Devuelve null si no existe.
    Cancion BuscarCancion(string codigo)
    {
        foreach (Cancion c in catalogo)
        {
            if (c.Codigo.ToLower() == codigo.ToLower())
            {
                return c;
            }
        }
        return null;
    }

    // Crea una canción y la guarda en el catálogo (el List)
    void CrearCancion(string codigo, string titulo, string artista, string genero, int duracion)
    {
        Cancion c = new Cancion();
        c.Codigo = codigo;
        c.Titulo = titulo;
        c.Artista = artista;
        c.Genero = genero;
        c.Duracion = duracion;

        catalogo.Add(c);
    }

    // Se llama cada vez que empieza a sonar una canción:
    // suma 1 en la posición de su género en el vector
    void RegistrarReproduccion()
    {
        Cancion c = lista.Actual();
        int posicion = Array.IndexOf(generos, c.Genero);
        reproduccionesPorGenero[posicion]++;

        MostrarResumen();
        MostrarAhora();
        MostrarLista(lista.Recorrer());
    }

    // ================= BOTONES DEL CATÁLOGO =================

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        // Revisar que no estén vacíos
        if (txtCodigo.Text.Trim() == "" || txtTitulo.Text.Trim() == "" || txtArtista.Text.Trim() == "")
        {
            MessageBox.Show("Escriba el código, el título y el artista.");
            return;
        }

        // Revisar que la duración sea un número entero mayor que 0
        int duracion;
        if (!int.TryParse(txtDuracion.Text, out duracion) || duracion <= 0)
        {
            MessageBox.Show("La duración debe ser un número entero de segundos, mayor que 0.");
            return;
        }

        // Revisar que el código no se repita
        if (BuscarCancion(txtCodigo.Text.Trim()) != null)
        {
            MessageBox.Show("Ya existe una canción con ese código.");
            return;
        }

        CrearCancion(txtCodigo.Text.Trim(), txtTitulo.Text.Trim(), txtArtista.Text.Trim(), cmbGenero.Text, duracion);
        LimpiarCampos();
        ActualizarTodo();
        MessageBox.Show("Canción registrada.");
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        Cancion c = BuscarCancion(txtCodigo.Text.Trim());
        if (c == null)
        {
            MessageBox.Show("Elija una canción del catálogo para modificarla.");
            return;
        }

        if (txtTitulo.Text.Trim() == "" || txtArtista.Text.Trim() == "")
        {
            MessageBox.Show("Escriba el título y el artista.");
            return;
        }

        int duracion;
        if (!int.TryParse(txtDuracion.Text, out duracion) || duracion <= 0)
        {
            MessageBox.Show("La duración debe ser un número entero de segundos, mayor que 0.");
            return;
        }

        c.Titulo = txtTitulo.Text.Trim();
        c.Artista = txtArtista.Text.Trim();
        c.Genero = cmbGenero.Text;
        c.Duracion = duracion;

        ActualizarTodo();
        MessageBox.Show("Canción modificada.");
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (catalogo.Count == 0)
        {
            MessageBox.Show("No hay canciones para eliminar.");
            return;
        }

        Cancion c = BuscarCancion(txtCodigo.Text.Trim());
        if (c == null)
        {
            MessageBox.Show("Elija una canción del catálogo para eliminarla.");
            return;
        }

        DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar " + c.Titulo + "?", "Confirmar", MessageBoxButtons.YesNo);
        if (respuesta == DialogResult.No)
        {
            return;
        }

        // Si estaba en la lista de reproducción, también se quita de ahí
        lista.Eliminar(c.Codigo);
        catalogo.Remove(c);

        LimpiarCampos();
        ActualizarTodo();
    }

    // Borra los cuadros y vuelve a mostrar todo (quita búsquedas)
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCampos();
        txtBuscar.Clear();
        ActualizarTodo();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // Al elegir una canción del catálogo, sus datos pasan a los cuadros de texto
    private void lstCatalogo_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstCatalogo.SelectedIndex < 0)
        {
            return;     // no hay nada elegido
        }

        Cancion c = cancionesEnCatalogo[lstCatalogo.SelectedIndex];
        txtCodigo.Text = c.Codigo;
        txtTitulo.Text = c.Titulo;
        txtArtista.Text = c.Artista;
        cmbGenero.Text = c.Genero;
        txtDuracion.Text = c.Duracion.ToString();
    }

    // ================= BUSCAR Y ORDENAR =================

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        if (catalogo.Count == 0)
        {
            MessageBox.Show("No hay canciones registradas.");
            return;
        }

        string texto = txtBuscar.Text.Trim().ToLower();
        if (texto == "")
        {
            MessageBox.Show("Escriba un código, título o artista para buscar.");
            return;
        }

        // Guardar en una lista aparte las canciones que coinciden
        List<Cancion> encontradas = new List<Cancion>();
        foreach (Cancion c in catalogo)
        {
            if (c.Codigo.ToLower().Contains(texto) || c.Titulo.ToLower().Contains(texto) || c.Artista.ToLower().Contains(texto))
            {
                encontradas.Add(c);
            }
        }

        MostrarCatalogo(encontradas);

        if (encontradas.Count == 0)
        {
            MessageBox.Show("No se encontró ninguna canción.");
        }
    }

    // Ordena el List por título (método de la burbuja)
    private void btnOrdenarTitulo_Click(object sender, EventArgs e)
    {
        if (catalogo.Count == 0)
        {
            MessageBox.Show("No hay canciones para ordenar.");
            return;
        }

        for (int i = 0; i < catalogo.Count - 1; i++)
        {
            for (int j = 0; j < catalogo.Count - 1 - i; j++)
            {
                // Si el de la izquierda va después en el abecedario, se intercambian
                if (string.Compare(catalogo[j].Titulo, catalogo[j + 1].Titulo, true) > 0)
                {
                    Cancion temporal = catalogo[j];
                    catalogo[j] = catalogo[j + 1];
                    catalogo[j + 1] = temporal;
                }
            }
        }

        MostrarCatalogo(catalogo);
    }

    // Ordena el List por duración, de la más corta a la más larga (método de la burbuja)
    private void btnOrdenarDuracion_Click(object sender, EventArgs e)
    {
        if (catalogo.Count == 0)
        {
            MessageBox.Show("No hay canciones para ordenar.");
            return;
        }

        for (int i = 0; i < catalogo.Count - 1; i++)
        {
            for (int j = 0; j < catalogo.Count - 1 - i; j++)
            {
                if (catalogo[j].Duracion > catalogo[j + 1].Duracion)
                {
                    Cancion temporal = catalogo[j];
                    catalogo[j] = catalogo[j + 1];
                    catalogo[j + 1] = temporal;
                }
            }
        }

        MostrarCatalogo(catalogo);
    }

    // ================= LISTA DE REPRODUCCIÓN (LISTA DOBLE) =================

    // Agrega al final de la lista de reproducción la canción elegida del catálogo
    private void btnAgregarLista_Click(object sender, EventArgs e)
    {
        Cancion c = BuscarCancion(txtCodigo.Text.Trim());
        if (c == null)
        {
            MessageBox.Show("Elija una canción del catálogo primero.");
            return;
        }

        if (lista.Buscar(c.Codigo) != null)
        {
            MessageBox.Show("Esa canción ya está en la lista de reproducción.");
            return;
        }

        lista.Insertar(c);
        ActualizarTodo();
    }

    // Quita de la lista de reproducción la canción elegida en esa lista
    private void btnQuitarLista_Click(object sender, EventArgs e)
    {
        if (lista.EstaVacia())
        {
            MessageBox.Show("La lista de reproducción está vacía.");
            return;
        }

        if (lstLista.SelectedIndex < 0)
        {
            MessageBox.Show("Elija una canción de la lista de reproducción primero.");
            return;
        }

        Cancion c = cancionesEnLista[lstLista.SelectedIndex];
        lista.Eliminar(c.Codigo);
        ActualizarTodo();
    }

    // Muestra la lista de reproducción de la última canción a la primera
    private void btnAlReves_Click(object sender, EventArgs e)
    {
        if (lista.EstaVacia())
        {
            MessageBox.Show("La lista de reproducción está vacía.");
            return;
        }

        MostrarLista(lista.RecorrerAlReves());
    }

    // Empieza a reproducir desde la primera canción
    private void btnReproducir_Click(object sender, EventArgs e)
    {
        if (lista.EstaVacia())
        {
            MessageBox.Show("La lista de reproducción está vacía.");
            return;
        }

        lista.Iniciar();
        RegistrarReproduccion();
    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        if (lista.EstaVacia())
        {
            MessageBox.Show("La lista de reproducción está vacía.");
            return;
        }

        if (lista.Actual() == null)
        {
            MessageBox.Show("Presione Reproducir primero.");
            return;
        }

        if (!lista.IrAlSiguiente())
        {
            MessageBox.Show("Ya está en la última canción.");
            return;
        }

        RegistrarReproduccion();
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
        if (lista.EstaVacia())
        {
            MessageBox.Show("La lista de reproducción está vacía.");
            return;
        }

        if (lista.Actual() == null)
        {
            MessageBox.Show("Presione Reproducir primero.");
            return;
        }

        if (!lista.IrAlAnterior())
        {
            MessageBox.Show("Ya está en la primera canción.");
            return;
        }

        RegistrarReproduccion();
    }

    // ================= DATOS DE EJEMPLO =================

    private void btnEjemplo_Click(object sender, EventArgs e)
    {
        if (catalogo.Count > 0)
        {
            MessageBox.Show("Ya hay datos cargados.");
            return;
        }

        CrearCancion("C001", "Bohemian Rhapsody", "Queen", "Rock", 354);
        CrearCancion("C002", "Despacito", "Luis Fonsi", "Reguetón", 229);
        CrearCancion("C003", "Billie Jean", "Michael Jackson", "Pop", 294);
        CrearCancion("C004", "Hotel California", "Eagles", "Rock", 391);
        CrearCancion("C005", "Vivir mi vida", "Marc Anthony", "Salsa", 252);
        CrearCancion("C006", "Shape of You", "Ed Sheeran", "Pop", 234);
        CrearCancion("C007", "Gasolina", "Daddy Yankee", "Reguetón", 192);
        CrearCancion("C008", "Imagine", "John Lennon", "Otros", 187);

        // Dejar 4 canciones ya puestas en la lista de reproducción
        lista.Insertar(BuscarCancion("C001"));
        lista.Insertar(BuscarCancion("C003"));
        lista.Insertar(BuscarCancion("C002"));
        lista.Insertar(BuscarCancion("C004"));

        ActualizarTodo();
    }
}
