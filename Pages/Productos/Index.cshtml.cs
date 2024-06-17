using AppWebEmployees.Datos;
using AppWebEmployees.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppWebEmployees.Pages.Productos
{
    public class IndexModel : PageModel
    {
        // TRABAJANDO LA LÓGICA DEL MODELO DEL NEGOCIO
        private readonly ApplicationDBContext _contexto;
        public IndexModel(ApplicationDBContext contexto)
        {
            _contexto = contexto; // inyeccion de depencias
        }
        public IEnumerable<Producto> Productos { get; set; }
        public async Task OnGet()
        {
            // accedemos al _contexto para acceder al producto y lo volcamos a una lista asincrona
            // Quedan guardados en Productos listados con todos sus nombres
            Productos = await _contexto.Producto.ToListAsync();
        }
    }
}
