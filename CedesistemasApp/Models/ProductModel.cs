using System;
namespace CedesistemasApp.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public Guid RestauranteId { get; set; }
        public string Nombre { get; set; }
        public long Precio { get; set; }
        public string Descripcion { get; set; }
        public object Restaurante { get; set; }
    }
}
