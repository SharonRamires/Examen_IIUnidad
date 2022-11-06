namespace Entidades
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo{ get; set; }
        public string Descripcion { get; set; }
        public string Respuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }


    }
}
