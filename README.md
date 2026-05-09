# ArqSoft-S01-MarceloMedina - Catálogo de Videojuegos 🎮

Este proyecto es una aplicación web desarrollada con **ASP.NET Core MVC** como parte de la Actividad #02 de la materia Arquitectura de Software. Consiste en un catálogo dinámico de videojuegos que permite gestionar una lista de elementos en memoria.

## 🚀 Funcionalidades

- **Visualización de Catálogo:** Lista completa de videojuegos con información relevante (Título, Género, Año).
- **Filtrado Dinámico:** Sistema de botones que permite filtrar los juegos por su categoría/género de forma instantánea.
- **Detalle de Ítems:** Página específica para ver toda la información detallada de cada videojuego, incluyendo la consola y descripción.
- **Gestión de Datos (Agregar):** Formulario con validaciones para añadir nuevos videojuegos a la lista durante la sesión.
- **Diseño Responsivo:** Interfaz moderna utilizando **Bootstrap**, con botones estilizados, tarjetas (cards) y una barra de navegación oscura.

## 🛠️ Tecnologías Utilizadas

- **Framework:** .NET 10.0 (ASP.NET Core MVC)
- **Lenguaje:** C#
- **Frontend:** HTML5, CSS3, Razor Pages
- **Estilos:** Bootstrap 5.3
- **Patrón de Arquitectura:** Model-View-Controller (MVC)

## 📂 Estructura del Proyecto

- **Models:** Contiene la clase `Item.cs` que define las propiedades de los videojuegos (Id, Titulo, Genero, Ano, etc.).
- **Controllers:** El `CatalogoController.cs` maneja la lógica de filtrado, visualización y el proceso de guardado.
- **Views:** - `Index`: La galería principal.
  - `Detalle`: La ficha técnica del juego.
  - `Agregar`: El formulario de registro.
  - `_Layout`: El diseño global y menú de navegación.

## 💻 Instalación y Ejecución

1. Clonar el repositorio:
   ```bash
   https://github.com/Marcelo-30/ArqSoft-S01-Marcelo/tree/master
