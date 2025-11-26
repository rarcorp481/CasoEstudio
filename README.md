# 📚 Sistema de Búsqueda - Biblioteca Digital Estudiantil

![Estado del Proyecto](https://img.shields.io/badge/Estado-Prototipo-blue)
![Lenguaje](https://img.shields.io/badge/C%23-.NET%208.0-purple)
![Plataforma](https://img.shields.io/badge/Windows-Forms-blue)

Este repositorio contiene el código fuente de un prototipo funcional para el sistema de búsqueda de la futura **Biblioteca Digital Estudiantil**. El proyecto demuestra la implementación práctica de algoritmos de búsqueda fundamentales y estructuras de datos en C#.

---

## 📋 Tabla de Contenidos

- [Descripción del Proyecto](#-descripción-del-proyecto)
- [Funcionalidades Principales](#-funcionalidades-principales)
- [Algoritmos Implementados](#-algoritmos-implementados)
- [Tecnologías Utilizadas](#-tecnologías-utilizadas)
- [Instalación y Uso](#-instalación-y-uso)
- [Estructura del Proyecto](#-estructura-del-proyecto)

---

## 📖 Descripción del Proyecto

El objetivo de este caso de estudio es aplicar conceptos teóricos de **Eficiencia Algorítmica** y **Estructuras de Datos** en un entorno de desarrollo real. La aplicación permite gestionar y consultar una colección simulada de libros y autores, ofreciendo herramientas para localizar información específica mediante diferentes estrategias de búsqueda.

## 🚀 Funcionalidades Principales

La aplicación cuenta con una interfaz gráfica basada en pestañas (`TabControl`) que organiza las distintas operaciones:

1.  **Base de Datos Visual:** Vista general de todos los libros y autores disponibles en el sistema.
2.  **Búsqueda de Libros:** Localización exacta por título.
3.  **Búsqueda de Autores:** Localización rápida en listas ordenadas.
4.  **Análisis de Colección:** Identificación automática de obras por antigüedad.
5.  **Búsqueda Contextual:** Rastreo de palabras clave dentro de las descripciones de las obras.

## 🧠 Algoritmos Implementados

Este proyecto implementa manualmente los siguientes algoritmos para fines educativos:

| Algoritmo | Tipo | Complejidad (Big O) | Descripción |
| :--- | :--- | :--- | :--- |
| **Búsqueda Lineal** | Secuencial | $O(n)$ | Recorre la lista de libros uno por uno hasta encontrar el título exacto. |
| **Búsqueda Binaria** | Divide y Vencerás | $O(\log n)$ | Algoritmo optimizado para buscar autores en una lista previamente ordenada. |
| **Recorrido Min/Max** | Lineal | $O(n)$ | Itera sobre la colección para encontrar el libro más antiguo y el más reciente simultáneamente. |
| **Búsqueda de Patrones** | String Matching | $O(n \cdot m)$ | Busca coincidencias parciales de texto dentro de las descripciones de los libros. |

## 🛠 Tecnologías Utilizadas

* **Lenguaje:** C# (C Sharp)
* **Framework:** .NET 8.0
* **Tipo de Aplicación:** Windows Forms (WinForms)
* **IDE Recomendado:** Visual Studio 2022

## 💻 Instalación y Uso

### Prerrequisitos
* Tener instalado el [.NET SDK 8.0](https://dotnet.microsoft.com/download) o superior.
* Visual Studio 2022 (con la carga de trabajo de desarrollo de escritorio .NET).

### Pasos
1.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/tu-usuario/CasoEstudio.git](https://github.com/tu-usuario/CasoEstudio.git)
    ```
2.  **Abrir el proyecto:**
    Navega a la carpeta y abre el archivo `BibliotecaDigital.slnx` o `BibliotecaDigital.csproj` con Visual Studio.
3.  **Compilar y Ejecutar:**
    Presiona `F5` o el botón de "Iniciar" en Visual Studio.

## 📂 Estructura del Proyecto

```text
BibliotecaDigital/
├── Modelos/
│   ├── Libro.cs       # Definición de la clase Libro (Título, Autor, Año, Descripción)
│   └── Autor.cs       # Definición de la clase Autor (ID, Nombre)
├── Form1.cs           # Lógica principal y algoritmos de búsqueda
├── Form1.Designer.cs  # Código generado de la interfaz gráfica
├── Program.cs         # Punto de entrada de la aplicación
└── BibliotecaDigital.csproj