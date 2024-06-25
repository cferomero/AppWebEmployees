using AppWebEmployees.Datos;
using AppWebEmployees.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppWebEmployees.Pages.Productos
{
    public class CrearModel : PageModel
    {
        // TRABAJANDO LA LÓGICA DEL MODELO DEL NEGOCIO
        private readonly ApplicationDBContext _contexto;
        public CrearModel(ApplicationDBContext contexto)
        {
            _contexto = contexto; // inyeccion de depencias
        }

        [BindProperty]
        public Producto Producto { get; set; }
        public void OnGet()
        {
        }
    }
}
