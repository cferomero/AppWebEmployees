using AppWebEmployees.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AppWebEmployees.Datos
{
    public class ApplicationDBContext : DbContext
    {
        // inyectamos todas las clases en el constructor de la clase
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        
        // PONER AQUI LOS MODELOS
        public DbSet<Producto> Productos { get; set; }
    }
}
