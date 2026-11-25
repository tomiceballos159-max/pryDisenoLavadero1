namespace pryDisenoLavadero1
{
    internal class RegistroLavado : Button
    {
        public string Cliente { get; set; }
        public string Patente { get; set; }
        public string Servicio { get; set; }
        public string TipoEntrega { get; set; }
        public int Cantidad { get; set; }
        public bool EsFrecuente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Recargo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
    }
}