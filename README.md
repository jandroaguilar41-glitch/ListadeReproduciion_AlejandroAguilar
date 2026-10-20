# Lista de reproducción

- **Estudiante:** _(Minor Alejandro Aguilar Mora)_
- **Curso:** ISB-08 Organización de Archivos y Estructura de Datos, UISIL
- **Proyecto:** Opción 5, Lista de reproducción
- **Lenguaje:** C# con Windows Forms (.NET 8)

## Qué hace el programa

- Registrar, modificar y eliminar canciones del catálogo.
- Buscar canciones por código, título o artista.
- Ordenar el catálogo por título o por duración.
- Armar una lista de reproducción: agregar y quitar canciones.
- Reproducir con navegación **Anterior** y **Siguiente**, marcando con `>>` la canción que suena.
- Ver la lista de reproducción al revés.
- Contar cuántas veces se ha reproducido una canción de cada género.
- Avisar con mensajes cuando los datos están mal o cuando no hay nada que mostrar.

## Cómo ejecutarlo

1. Instalar Visual Studio 2022 con la carga de trabajo "Desarrollo de escritorio de .NET" (o el SDK de .NET 8).
2. Abrir el archivo `ListaReproduccion.csproj`.
3. Presionar F5.

Para la demostración: presionar el botón **"Datos de ejemplo"**. Carga 8 canciones y deja 4 ya puestas en la lista de reproducción. Después presionar **Reproducir** y usar **Siguiente** y **Anterior**.

## Estructuras de datos usadas

| Estructura | Uso dentro de la aplicación | Ubicación en el código |
|---|---|---|
| Vector (`int[]`) | Guarda cuántas veces se ha reproducido una canción de cada género. Se inicializa en cero, se accede por índice para sumar 1 y se recorre para mostrar el resumen. | `FrmReproductor.cs`: variable `reproduccionesPorGenero`. Se inicializa en `FrmReproductor_Load()`, se actualiza en `RegistrarReproduccion()` y se recorre en `MostrarResumen()` |
| ArrayList (`List<Cancion>`) | Guarda el catálogo de canciones. Permite agregar, consultar, modificar, eliminar y ordenar. | `FrmReproductor.cs`: variable `catalogo`. Se usa en `CrearCancion()`, `BuscarCancion()`, `btnModificar_Click()`, `btnEliminar_Click()`, `btnBuscar_Click()` y los botones de ordenar |
| Lista doble | Guarda las canciones de la lista de reproducción. Cada nodo apunta a la canción siguiente y a la anterior, y por eso se puede navegar en los dos sentidos y recorrer al revés. | `Clases.cs`: clases `NodoCancion` y `ListaReproduccion` con los métodos `Insertar`, `Buscar`, `Eliminar`, `Recorrer`, `RecorrerAlReves`, `Iniciar`, `IrAlSiguiente` e `IrAlAnterior` |

## Archivos

- `Clases.cs`: Cancion, NodoCancion y ListaReproduccion (la lista doble).
- `FrmReproductor.cs`: el código del formulario.
- `FrmReproductor.Designer.cs`: los botones, cuadros de texto y listas del formulario.
- `Program.cs`: inicia el programa.
