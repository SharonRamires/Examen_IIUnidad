namespace Entidades
{
    public class DetaaleTicket
    {
        public int Id { get; set; }
        public int IdTicket { get; set; }
        public string TipoSoporte { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
    }
}
