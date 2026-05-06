using Catalogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        // Lista estática para persistir los datos durante la sesión
        private static List<Item> _items = new()
        {
            new Item {
                Id = 1,
                Titulo = "Devil May Cry",
                Genero = "Hack and Slash",
                Ano = 2001,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador de demonios llamado Dante."
            },
            new Item {
                Id = 2,
                Titulo = "Castlevania: Symphony of the Night",
                Genero = "Metroidvania",
                Ano = 1997,
                Consola = "PlayStation 1",
                Descripcion = "Alucard explora el castillo de Drácula en esta obra maestra lateral."
            },
            new Item {
                Id = 3,
                Titulo = "NieR: Automata",
                Genero = "Action RPG",
                Ano = 2017,
                Consola = "PlayStation 4",
                Descripcion = "Una guerra entre androides y máquinas en un futuro distópico."
            },
            new Item {
                Id = 4,
                Titulo = "Hollow Knight",
                Genero = "Metroidvania",
                Ano = 2017,
                Consola = "PC / Nintendo Switch",
                Descripcion = "Explora un reino de insectos en ruinas lleno de secretos y jefes desafiantes."
            },
            new Item {
                Id = 5,
                Titulo = "God of War",
                Genero = "Acción-Aventura",
                Ano = 2018,
                Consola = "PlayStation 4",
                Descripcion = "Kratos y su hijo Atreus viajan por las tierras de la mitología nórdica."
            }
        };

        // Acción Principal: Index (con filtro por género)
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
                ? _items
                : _items.Where(i => i.Genero?.Equals(genero, System.StringComparison.OrdinalIgnoreCase) == true).ToList();

            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;

            return View(resultado);
        }

        // Acción: Ver Detalle
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        // Acción: Formulario Agregar (Vista GET)
        public IActionResult Agregar()
        {
            return View();
        }

        // Acción: Guardar Nuevo Juego (POST)
        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            if (ModelState.IsValid)
            {
                // Asignar ID basado en el máximo actual para evitar duplicados
                item.Id = _items.Any() ? _items.Max(i => i.Id) + 1 : 1;
                _items.Add(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }
    }
}
